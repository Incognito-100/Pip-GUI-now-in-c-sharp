using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipGUI
{
	class optionsOP4
	{
		public static void opt4()
		{
			Console.Clear();
			string opt4sel;

			Console.Write("drag requirements file to install on to the console > ");
			string userimpot3 = Console.ReadLine();

			opt4sel = "/C pip install -r " + userimpot3;
			System.Diagnostics.Process.Start("CMD.exe", opt4sel);
			Console.ReadKey();
			Console.Clear();
		}
	}
}
