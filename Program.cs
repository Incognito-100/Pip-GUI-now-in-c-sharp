using idk_whayt_to_maek.Internals.Modules;
using idk_whayt_to_maek.Internals.visual;
using Console = Colorful.Console;

namespace idk_whayt_to_maek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        start:
            Console.Title = "pip GUI now in C# v1.5";

            Console.Clear();
            ASCI.ASCIII();

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
            string userinput = Console.ReadLine();

            //==========================================|start switch|==========================================
            switch (userinput)
            {
                //==========================================|choice 1|==========================================
                case "1":
                    optionsOP1.opt1();
                    goto start;

                //==========================================|choice 2|==========================================
                case "2":
                    optionsOP2.opt2();
                    goto start;

                //==========================================|choice 3|==========================================
                case "3":
                    optionsOP3.opt3();
                    goto start;

                //==========================================|choice 4|==========================================
                case "4":
                    optionsOP4.opt4();
                    goto start;

                //==========================================|choice 5|==========================================
                case "5":
                    optionsOP5.opt5();
                    goto start;

                //==========================================|choice 6|==========================================
                case "6":
                    optionsOP6.opt6();
                    goto start;

                //==========================================|choice 7|==========================================
                case "7":
                    optionsOP7.opt7();
                    goto start;

                //==========================================|choice 8|==========================================
                case "8":
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