using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace gazugafan.RestStop
{
	class Program
	{
		static Mutex mutex = new Mutex(false, "gazugafan.RestStop");

		/// <summary>
		/// Application entry point.
		/// </summary>
		/// <param name="args">Command-line arguments.</param>
		[STAThread]
		static void Main(string[] args)
		{
			if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Wait 5 seconds if contended – in case another instance
			// of the program is in the process of shutting down.
			if (!mutex.WaitOne(TimeSpan.FromSeconds(5), false))
			{
				return;
			}

			try
			{
				var trayIcon = new TrayIcon();
				trayIcon.Show();
				Application.EnableVisualStyles();
				Application.Run();
			}
			finally
			{
				mutex.ReleaseMutex();
			}
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
	}
}
