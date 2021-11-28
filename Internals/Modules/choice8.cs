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

			string fuck = "/C pip freeze > requirements.txt";

			System.Diagnostics.Process.Start("CMD.exe", fuck);

			string filee = "/C pip uninstall -r requirements.txt -y";
			System.Diagnostics.Process.Start("CMD.exe", filee);

			string jackass = "/C pip cache purge";
			System.Diagnostics.Process.Start("CMD.exe", jackass);

			string milf = "/C del requirements.txt";
			System.Diagnostics.Process.Start("CMD.exe", milf);

			Console.ReadKey();
			Console.Clear();
		}
	}
}
