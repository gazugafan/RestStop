using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace gazugafan.RestStop
{
	/// <summary>
	/// 
	/// </summary>
	public partial class SettingsForm:Form
	{
		/// <summary>
		/// 
		/// </summary>
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			Dictionary<string, string> soundOptions = GetSoundOptions();
			SoundSelect.Items.AddRange(soundOptions.Values.ToArray());
			ReminderSoundSelect.Items.AddRange(soundOptions.Values.ToArray());

			if (soundOptions.ContainsKey(Properties.Settings.Default.SoundPath)) SoundSelect.Text = soundOptions[Properties.Settings.Default.SoundPath];
			else SoundSelect.Text = Properties.Settings.Default.SoundPath;

			if (soundOptions.ContainsKey(Properties.Settings.Default.ReminderSound)) ReminderSoundSelect.Text = soundOptions[Properties.Settings.Default.ReminderSound];
			else ReminderSoundSelect.Text = Properties.Settings.Default.ReminderSound;

			//get the windows startup value...
			RegistryKey startupKeys = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			startupCheckbox.Checked = (startupKeys.GetValue(Application.ProductName, "").ToString() != "");

			UpdateMinutes();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			//set the windows startup...
			RegistryKey startupKeys = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (startupCheckbox.Checked)
				startupKeys.SetValue(Application.ProductName, Application.ExecutablePath);
			else
				startupKeys.DeleteValue(Application.ProductName, false);

			Properties.Settings.Default.Save();

			this.Close();
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reset();
			SettingsForm_Load(null, null);
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reload();
			this.Close();
		}

		private void showTooltipOnFocus(object sender, EventArgs e)
		{
			this.toolTip1.Show(this.toolTip1.GetToolTip((Control)sender), (Control)sender);
		}

		private void hideTooltipOnBlur(object sender, EventArgs e)
		{
			this.toolTip1.Hide((Control)sender);
		}

		private void SoundSelect_Change(object sender, EventArgs e)
		{
			Dictionary<string, string> soundOptions = GetSoundOptions();

			if (SoundSelect.Text == "Custom...")
			{
				OpenFileDialog file = new OpenFileDialog();
				file.Filter = "WAV Files|*.wav";
				if (file.ShowDialog() == DialogResult.OK)
				{
					SoundSelect.Text = file.FileName;
				}
			}

			if (soundOptions.ContainsValue(SoundSelect.Text)) Properties.Settings.Default.SoundPath = soundOptions.FirstOrDefault(x => x.Value == SoundSelect.Text).Key;
			else Properties.Settings.Default.SoundPath = SoundSelect.Text;
		}

		private void ReminderSound_Change(object sender, EventArgs e)
		{
			Dictionary<string, string> soundOptions = GetSoundOptions();

			if (ReminderSoundSelect.Text == "Custom...")
			{
				OpenFileDialog file = new OpenFileDialog();
				file.Filter = "WAV Files|*.wav";
				if (file.ShowDialog() == DialogResult.OK)
				{
					ReminderSoundSelect.Text = file.FileName;
				}
			}

			if (soundOptions.ContainsValue(ReminderSoundSelect.Text)) Properties.Settings.Default.ReminderSound = soundOptions.FirstOrDefault(x => x.Value == ReminderSoundSelect.Text).Key;
			else Properties.Settings.Default.ReminderSound = ReminderSoundSelect.Text;
		}

		private Dictionary<string, string> GetSoundOptions()
		{
			Dictionary<string, string> results = new Dictionary<string, string>();
			results.Add("", "None");
			string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "Sounds", "*.wav", SearchOption.TopDirectoryOnly).Select(Path.GetFileName).ToArray();
			foreach(string file in files)
			{
				results.Add("{0}" + file, Path.GetFileNameWithoutExtension(file));
			}

			results.Add("Custom", "Custom...");

			return results;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.SoundPath != "")
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(String.Format(Properties.Settings.Default.SoundPath, AppDomain.CurrentDomain.BaseDirectory + "Sounds\\"));
				player.Play();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.ReminderSound != "")
			{
				System.Media.SoundPlayer player = new System.Media.SoundPlayer(String.Format(Properties.Settings.Default.ReminderSound, AppDomain.CurrentDomain.BaseDirectory + "Sounds\\"));
				player.Play();
			}
		}

		private void UpdateMinutes(object sender = null, EventArgs e = null)
		{
			restTimeRequiredPost.Text = "seconds (" + (int)(restTimeRequired.Value / 60) + " minutes)";
			workIntervalPost.Text = "seconds (" + (int)(workInterval.Value / 60) + " minutes)";
			reminderIntervalPost.Text = "seconds (" + (int)(reminderInterval.Value / 60) + " minutes)";
		}

		private void UpdateMinutes(object sender, KeyEventArgs e)
		{
			UpdateMinutes();
		}
	}
}
