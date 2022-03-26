using idk_whayt_to_maek.Internals.visual;
using idk_whayt_to_maek.Internals.Modules;
using Console = Colorful.Console;

namespace idk_whayt_to_maek.Internals.Menues
{
    public class MainMen
    {
        public static void showmen()
        {
        start:
            Console.Title = "pip GUI now in C# v2.0";

            Console.Clear();
            ASCI.Drawasci();

            Console.WriteLine(" [1] list all packages");

            Console.WriteLine(" [2] install a package");

            Console.WriteLine(" [3] uninstall a package");

            Console.WriteLine(" [4] installs a requirements file");

            Console.WriteLine(" [5] uninstall a requirements file");

            Console.WriteLine(" [6] generate a requirements file");

            Console.WriteLine(" [7] uninstall all packages");

            Console.WriteLine();

            Console.WriteLine(" [8] exits the program");

            Console.WriteLine();
            Console.Write("> ");

            //==========================================|get key imput|==========================================
            int userinput = int.Parse(Console.ReadLine());

            //==========================================|start switch|==========================================
            switch (userinput)
            {
                //==========================================|choice 1|==========================================
                case 1:
                    OptionsOP1.Start();
                    goto start;

                //==========================================|choice 2|==========================================
                case 2:
                    OptionsOP2.Start();
                    goto start;

                //==========================================|choice 3|==========================================
                case 3:
                    OptionsOP3.Start();
                    goto start;

                //==========================================|choice 4|==========================================
                case 4:
                    OptionsOP4.Start();
                    goto start;

                //==========================================|choice 5|==========================================
                case 5:
                    OptionsOP5.Start();
                    goto start;

                //==========================================|choice 6|==========================================
                case 6:
                    OptionsOP6.Start();
                    goto start;

                //==========================================|choice 7|==========================================
                case 7:
                    OptionsOP7.Start();
                    goto start;

                //==========================================|choice 8|==========================================
                case 8:
                    Environment.Exit(0);
                    break;

                //==========================================|if userimp is not valid|==========================================
                default:
                    Console.WriteLine("invalid imput");
                    Thread.Sleep(300);
                    goto start;
            }
        }
    }
}