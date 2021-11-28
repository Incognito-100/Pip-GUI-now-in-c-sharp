using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipGUI
{
	class optionsOP2
	{
		public static void opt2()
		{
			Console.Clear();
			string opt2sel;

			Console.Write("imput a pacage you want to install > ");
			string userimpot1 = Console.ReadLine();

			opt2sel = "/C pip install " + userimpot1;
			System.Diagnostics.Process.Start("CMD.exe", opt2sel);
			Console.ReadKey();
			Console.Clear();
		}
	}
}
