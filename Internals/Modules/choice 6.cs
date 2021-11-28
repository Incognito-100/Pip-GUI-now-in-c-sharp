using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipGUI
{
	class optionsOP6
	{
		public static void opt6()
		{
			Console.Clear();
			string cmdopt6;

			Console.Write("type directory path to project > ");
			string userimpot5 = Console.ReadLine();

			System.IO.Directory.SetCurrentDirectory(userimpot5);
			cmdopt6 = "/C dir";
			System.Diagnostics.Process.Start("CMD.exe", cmdopt6);

			Console.WriteLine("please imput the name of the python file with extention");

			Console.WriteLine("will add later");

			Console.ReadKey();
			Console.Clear();
		}
	}
}
