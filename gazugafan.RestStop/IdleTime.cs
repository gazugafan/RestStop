using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace gazugafan.RestStop
{
	class IdleTime
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct LASTINPUTINFO
		{
			public uint cbSize;
			public uint dwTime;
		}

		[DllImport("user32.dll")]
		static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

		private int _lastSlightMovement;
		private int _lastMajorMovement;
		private Point _lastMousePoint;

		public IdleTime()
		{
			_lastMousePoint = Cursor.Position;
			_lastMajorMovement = Environment.TickCount;
			_lastSlightMovement = Environment.TickCount;
		}

		public TimeSpan? GetIdleTime()
		{
			LASTINPUTINFO info = new LASTINPUTINFO();
			info.cbSize = (uint)Marshal.SizeOf(info);
			if (GetLastInputInfo(ref info))
			{
				//if there's been any slight movement since the last check...
				if (info.dwTime > _lastSlightMovement)
				{
					_lastSlightMovement = (int)info.dwTime;

					//if the mouse moved enough, or if it was perfectly still (and therefore the activity was caused by a keypress)...
					if (Cursor.Position == _lastMousePoint || GetDistance(Cursor.Position, _lastMousePoint) > (int)Properties.Settings.Default.MouseFuzz)
					{
						//there's been major movement...
						_lastMajorMovement = (int)info.dwTime;
					}

					//whether the movement was major or minor, update the last mouse position. A very slowly moving mouse is considered inactive...
					_lastMousePoint = Cursor.Position;
				}

				//return the time since the last major movement...
				return TimeSpan.FromMilliseconds(Environment.TickCount - _lastMajorMovement);
			}
			else
				return null;
		}

		private static double GetDistance(Point p1, Point p2)
		{
			return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
		}
	}
}
