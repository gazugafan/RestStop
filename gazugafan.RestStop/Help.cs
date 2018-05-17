using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gazugafan.RestStop
{
	partial class Help:Form
	{
		public Help()
		{
			InitializeComponent();
			richTextBox1.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "help.rtf"));
			logoPictureBox.Image = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "about.bmp"));
		}
	}
}
