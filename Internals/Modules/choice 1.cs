using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipGUI
{
	class optionsOP1
	{
		public static void opt1()
		{
			Console.Clear();
			string opt1sel;
			opt1sel = "/C pip list";
			System.Diagnostics.Process.Start("CMD.exe", opt1sel);
			Console.ReadKey();
			Console.Clear();
		}
	}
}
