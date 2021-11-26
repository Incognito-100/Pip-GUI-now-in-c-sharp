namespace classes
{
	class Program
	{
		static void Main(string[] args)
		{

		start:;
			Console.Title = "pip GUI now in C#";

			Console.WriteLine(" [1] list all packages");
			
			Console.WriteLine(" [2] install a package");

			Console.WriteLine(" [3] uninstall a package");
			
			Console.WriteLine(" [4] installs a requirements file");
			
			Console.WriteLine(" [5] uninstall a requirements file");
			
			Console.WriteLine(" [6] generate a requirements file");
			
			Console.WriteLine(" [7] uninstall all packages");

			Console.WriteLine(" [8] exits the program");
			Console.Write("> ");

			//==========================================|gets key imput|==========================================
			ConsoleKeyInfo inpdetc = Console.ReadKey();


			//==========================================|choice 1|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad1)
			{
				goto opt1;
			}


			//==========================================|choice 2|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad2)
			{
				goto opt2;
			}


			//==========================================|choice 3|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad3)
			{
				goto opt3;
			}


			//==========================================|choice 4|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad4)
			{
				goto opt4;
			}


			//==========================================|choice 5|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad5)
			{
				goto opt5;
			}


			//==========================================|choice 6|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad6)
			{
				goto opt6;
			}


			//==========================================|choice 7|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad7)
			{
				goto opt7;
			}


			//==========================================|choice 8|==========================================
			if (inpdetc.Key == ConsoleKey.NumPad8)
			{;
				goto opt8;
			}



			//==========================================|choice 1 internals|==========================================
		opt1:;
				Console.Clear();
				string opt1sel;
				opt1sel = "/C pip list";
				System.Diagnostics.Process.Start("CMD.exe", opt1sel);
				Console.ReadKey();
				Console.Clear();
				goto start;


		//==========================================|choice 2 internals|==========================================
		opt2:;
				Console.Clear();
				string opt2sel;

				Console.Write("imput a pacage you want to install > ");
				string userimpot1 = Console.ReadLine();

				opt2sel = "/C pip install " + userimpot1;
				System.Diagnostics.Process.Start("CMD.exe", opt2sel);
				Console.ReadKey();
				Console.Clear();
				goto start;


		//==========================================|choice 3 internals|==========================================
		opt3:;
				Console.Clear();
				string opt3sel;

				Console.Write("imput a pacage you want to unininstall > ");
				string userimpot2 = Console.ReadLine();

				opt3sel = "/C pip uninstall " + userimpot2+ " -y";
				System.Diagnostics.Process.Start("CMD.exe", opt3sel);
				Console.ReadKey();
				Console.Clear();
				goto start;


		//==========================================|choice 4 internals|==========================================
		opt4:;
				Console.Clear();
				string opt4sel;

				Console.Write("type requirements file to install must include directory path > ");
				string userimpot3 = Console.ReadLine();

				opt4sel = "/C pip install -r " + userimpot3;
				System.Diagnostics.Process.Start("CMD.exe", opt4sel);
				Console.ReadKey();
				Console.Clear();
				goto start;


		//==========================================|choice 5 internals|==========================================
		opt5:;
				Console.Clear();
				string opt5sel;

				Console.Write("type requirements file to uninstall must include directory path > ");
				string userimpot4 = Console.ReadLine();

				opt5sel = "/C pip uninstall -r " + userimpot4+" -y";
				System.Diagnostics.Process.Start("CMD.exe", opt5sel);
				Console.ReadKey();
				Console.Clear();
				goto start;


			//==========================================|choice 6 internals|==========================================
		opt6:;
				Console.Clear();
				string opsel6;
				string pipcom;

				//Console.Write("type directory path to project > ");
				//string userimpot5 = Console.ReadLine();

				//string dir = Console.ReadLine();
				//pipcom = "/C cd "+dir;


				//System.Diagnostics.Process.Start("CMD.exe", pipcom, userimpot5);

				Console.WriteLine("will add  later");
				Console.ReadKey();
				Console.Clear();
				goto start;


		//==========================================|choice 7 internals|==========================================
		opt7:;
				Console.Clear();
				Console.WriteLine("will add later");

				Console.ReadKey();
				Console.Clear();
				goto start;


		//==========================================|choice 8 internals|==========================================
		opt8:;
				Console.Clear();
				System.Environment.Exit(0);

				



		}
	}
}
