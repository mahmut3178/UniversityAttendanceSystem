using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.UI.UI;

namespace WinForm.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		public static Lecturer lecturer { get; set; }
		public static Student student { get; set; }
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
