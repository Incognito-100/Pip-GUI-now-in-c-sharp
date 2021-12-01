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
		start:
			Console.Clear();
			string cmdopt6;

			Console.Write("drag puthon file onto the console > ");
			string userimpot5 = Console.ReadLine();


			string pfname = userimpot5;


			string text = File.ReadAllText(pfname);
			Console.WriteLine(text);

			//==========================================| ReaderWriterLockSlim the path to the file |==========================================

			 Console.WriteLine("please type or paste the lines ot text after the imput function");
			
			string inpinf = Console.ReadLine();
			Console.WriteLine(inpinf);
			Console.WriteLine("is this corret? (Y/N)");

			ConsoleKeyInfo inpdetc = Console.ReadKey();


			//==========================================|y|==========================================
			if (inpdetc.Key == ConsoleKey.Y)
			{
				System.IO.Directory.CreateDirectory("requirements files");
				System.IO.Directory.SetCurrentDirectory("requirements files");
				System.IO.File.WriteAllText("requirements.txt", inpinf);
			}

			//==========================================|n|==========================================
			if (inpdetc.Key == ConsoleKey.N)
			{
				goto start;
			}


			Console.ReadKey();
			Console.Clear();
		}
	}
}
