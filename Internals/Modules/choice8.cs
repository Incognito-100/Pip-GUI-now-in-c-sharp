using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipGUI
{
	class optionsOP8
	{
		public static void opt8()
		{
			Console.Clear();

			string com1 = "/C pip freeze > requirements.txt";

			System.Diagnostics.Process.Start("CMD.exe", com1);

			string filee = "/C pip uninstall -r requirements.txt -y";
			System.Diagnostics.Process.Start("CMD.exe", filee);

			string com2 = "/C pip cache purge";
			System.Diagnostics.Process.Start("CMD.exe", com2);

			string com3 = "/C del requirements.txt";
			System.Diagnostics.Process.Start("CMD.exe", com3);

			Console.ReadKey();
			Console.Clear();
		}
	}
}
