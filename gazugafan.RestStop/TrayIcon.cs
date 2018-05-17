using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using Microsoft.Win32;

namespace gazugafan.RestStop
{
	/// <summary>
	/// The main program
	/// </summary>
	public class TrayIcon:IDisposable
	{
		#region Init
		private NotifyIcon _notifyIcon;
		private bool _isDisposed;
		private IdleTime _idleTime;
		private System.Timers.Timer _idleTimer;
		private bool _isActive = true;
		private bool _blinkTrayIsRed = false;
		private int _restsNeeded = 0;
		private int _remindersNeeded = 0;
		private int _activeTimestamp = 0;
		private Icon[] _hourglasses = new Icon[10];
		private Icon _hourglassFull;
		private Icon _hourglassEmpty;
		private Icon _hourglassRed;

		/// <summary>
		/// Initialises a new instance of this class.
		/// </summary>
		public TrayIcon()
		{
			//setup hourglass animation icons...
			_hourglassFull = new Icon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons/hourglassFull.ico"));
			_hourglassEmpty = new Icon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons/hourglassEmpty.ico"));
			_hourglassRed = new Icon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons/hourglassRed.ico"));
			for (int x = 0; x < 10; x++)
			{
				_hourglasses[x] = new Icon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icons/hourglass" + (x + 1) + ".ico"));
			}

			_notifyIcon = CreateNotifyIcon();
			_activeTimestamp = Environment.TickCount;
			_idleTime = new IdleTime();
			_idleTimer = new System.Timers.Timer();
			_idleTimer.Elapsed += new ElapsedEventHandler(OnIdleCheck);
			_idleTimer.Interval = Properties.Settings.Default.IdleCheckInterval;
			_idleTimer.Start();
		}

		/// <summary>
		/// Class destruction and cleanup.
		/// </summary>
		~TrayIcon()
		{
			Dispose(false);
		}
		#endregion Init ----------------------------------------------------------------------------------------------

		#region Public Methods
		/// <summary>
		/// Show the tray icon.
		/// </summary>
		public void Show()
		{
			if (_isDisposed) throw new ObjectDisposedException("_notifyIcon");
			_notifyIcon.Visible = true;

			//on first run, add to startup and show balloon...
			if (Properties.Settings.Default.FirstRun)
			{
				Properties.Settings.Default.FirstRun = false;
				Properties.Settings.Default.Save();
				RegistryKey startupKeys = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				startupKeys.SetValue(Application.ProductName, Application.ExecutablePath);
				ShowHelp();
			}
		}

		/// <summary>
		/// Dispose of underlying <see cref="NotifyIcon"/>.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion Public Methods ------------------------------------------------------------------------------------

		#region Non-Public Methods
		/// <summary>
		/// Dispose of underlying <see cref="NotifyIcon"/>.
		/// </summary>
		protected virtual void Dispose(bool isDisposing)
		{
			if (!_isDisposed)
			{
				if (isDisposing)
					_notifyIcon.Dispose();

				_isDisposed = true;
			}
		}

		/// <summary>
		/// Sets up the tray icon
		/// </summary>
		/// <returns>The resulting NotifyIcon</returns>
		private NotifyIcon CreateNotifyIcon()
		{
			var notifyIcon = new NotifyIcon
			{
				ContextMenu = new ContextMenu(
					new[]
					{
						new MenuItem("I swear I'm rested!", ForceRested),
						new MenuItem("-"),
						new MenuItem("Settings", ShowSettings),
						new MenuItem("Help", ShowHelp),
						new MenuItem("About", ShowAbout),
						new MenuItem("-"),
						new MenuItem("Exit", delegate { Dispose(); Application.Exit(); })
					}
				),
				Icon = _hourglassEmpty,
				Text = "Rest Stop"
			};

			notifyIcon.DoubleClick += ShowSettings;

			return notifyIcon;
		}

		private void ForceRested(object sender = null, EventArgs e = null)
		{
			_activeTimestamp = Environment.TickCount;
			_isActive = false;
			_restsNeeded = 0;
			_remindersNeeded = 0;
			Console.WriteLine("Force Rested");
			_notifyIcon.Icon = _hourglassEmpty;
		}

		private void ShowSettings(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count == 0)
			{
				new SettingsForm().ShowDialog();
			}
		}

		private void ShowHelp(object sender = null, EventArgs e = null)
		{
			if (Application.OpenForms.Count == 0)
			{
				new Help().ShowDialog();
			}
		}

		private void ShowAbout(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count == 0)
			{
				new About().ShowDialog();
			}
		}

		/// <summary>
		/// Should run every few seconds to check to see if the user is idle, active, rested, etc.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void OnIdleCheck(object source, ElapsedEventArgs e)
		{
			var inactiveTime = _idleTime.GetIdleTime();
			if (inactiveTime == null)
			{
				Console.WriteLine("Idle time unknown");
			}
			else if (inactiveTime.Value.TotalSeconds > (int)Properties.Settings.Default.SecondsBeforeRested)
			{
				if (_isActive)
				{
					_isActive = false;
					_restsNeeded = 0;
					_remindersNeeded = 0;
					Console.WriteLine("Rested");
					_notifyIcon.Text = "Rested";
					_notifyIcon.Icon = _hourglassEmpty;
				}
			}
			else
			{
				if (!_isActive)
				{
					_isActive = true;
					_activeTimestamp = Environment.TickCount;
					Console.WriteLine("Activity has resumed");
				}

				double activeTime = TimeSpan.FromMilliseconds(Environment.TickCount - _activeTimestamp).TotalSeconds;
				Console.WriteLine(string.Format("Active for {0} seconds", activeTime));

				int restsNeeded = (int)(activeTime / (double)Properties.Settings.Default.WorkInterval);
				if (activeTime > (double)Properties.Settings.Default.WorkInterval)
				{
					if (restsNeeded > _restsNeeded)
					{
						_remindersNeeded = 0;
						_restsNeeded = restsNeeded;
						Console.WriteLine("Rest stop {0} is needed!", restsNeeded);
						RestNeededStart();
					}

					Console.WriteLine("Rest has been needed for {0} seconds", activeTime - (double)Properties.Settings.Default.WorkInterval);
					_notifyIcon.Text = string.Format("Overworked {0}m", (int)((activeTime - (double)Properties.Settings.Default.WorkInterval) / 60));

					int activeThisRestStop = (int)(activeTime - (restsNeeded * (double)Properties.Settings.Default.WorkInterval));
					int remindersNeeded = (int)(activeThisRestStop / (double)Properties.Settings.Default.ReminderInterval);

					if (remindersNeeded > _remindersNeeded)
					{
						_remindersNeeded = remindersNeeded;
						Console.WriteLine("Reminder {0} for this rest stop", remindersNeeded);
						ReminderNeeded();
					}

					if (restsNeeded == 1 && remindersNeeded == 0)
					{
						_notifyIcon.Icon = _hourglasses[9];
					}
					else
					{
						if (Properties.Settings.Default.ReminderBlinkTrayIcon)
						{
							_blinkTrayIsRed = !_blinkTrayIsRed;
							if (_blinkTrayIsRed) _notifyIcon.Icon = _hourglassRed;
							else _notifyIcon.Icon = _hourglassFull;
						}
					}
				}
				else
				{
					_notifyIcon.Text = string.Format("Active for {0}m straight", (int)(activeTime / 60));

					//update tray icon...
					int amountComplete = (int)((activeTime / (double)Properties.Settings.Default.WorkInterval) * 9);
					if (amountComplete < 0) amountComplete = 0;
					else if (amountComplete > 9) amountComplete = 9;
					_notifyIcon.Icon = _hourglasses[amountComplete];
				}

			}

		}

		private void RestNeededStart()
		{
			//attempt to play a sound...
			if (Properties.Settings.Default.SoundPath != "")
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(String.Format(Properties.Settings.Default.SoundPath, AppDomain.CurrentDomain.BaseDirectory + "Sounds\\"));
				player.Play();
			}

			//send a toast...
			if (Properties.Settings.Default.ShowToast)
			{
				SendToast("Break Time!", "It's time for a rest stop");
			}
		}

		private void ReminderNeeded()
		{
			//attempt to play a sound...
			if (Properties.Settings.Default.ReminderSound != "")
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(String.Format(Properties.Settings.Default.ReminderSound, AppDomain.CurrentDomain.BaseDirectory + "Sounds\\"));
				player.Play();
			}

			//send a toast...
			if (Properties.Settings.Default.ReminderToast)
			{
				SendToast("Hey!", "You're overdue for some rest");
			}
		}

		private void SendToast(string heading, string message)
		{
			_notifyIcon.ShowBalloonTip(0, heading, message, ToolTipIcon.Info);
		}
		#endregion Non-Public Methods --------------------------------------------------------------------------------
	}
}
