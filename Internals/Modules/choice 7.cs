using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipGUI
{
	class optionsOP7
	{
		public static void opt7()
		{
			Console.Clear();

			string com = "/C pip freeze > requirements.txt";

			System.Diagnostics.Process.Start("CMD.exe", com);

			string filee = "/C pip uninstall -r requirements.txt -y";
			System.Diagnostics.Process.Start("CMD.exe", filee);

			string scom = "/C pip cache purge";
			System.Diagnostics.Process.Start("CMD.exe", scom);

			string rmfile = "/C del requirements.txt";
			System.Diagnostics.Process.Start("CMD.exe", rmfile);

			Console.ReadKey();
			Console.Clear();
		}
	}
}
