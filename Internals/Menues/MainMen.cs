﻿using idk_whayt_to_maek.Internals.Modules;
using idk_whayt_to_maek.Internals.visual;
using Console = Colorful.Console;

namespace idk_whayt_to_maek.Internals.Menues
{
    public class MainMen
    {
        public static void showmen()
        {
        start:
            Console.Title = "pip GUI now in C# v2.1.2";

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

            Console.WriteLine(" [x] exits the program");

            Console.Write("> ");

            //==========================================|get key imput|==========================================
            string userinput = Console.ReadLine();

            //==========================================|start switch|==========================================
            switch (userinput)
            {
                //==========================================|choice 1|==========================================
                case "1":
                    Option1.Start();
                    goto start;

                //==========================================|choice 2|==========================================
                case "2":
                    Option2.Start();
                    goto start;

                //==========================================|choice 3|==========================================
                case "3":
                    Option3.Start();
                    goto start;

                //==========================================|choice 4|==========================================
                case "4":
                    Option4.Start();
                    goto start;

                //==========================================|choice 5|==========================================
                case "5":
                    Option5.Start();
                    goto start;

                //==========================================|choice 6|==========================================
                case "6":
                    Option6.Start();
                    goto start;

                //==========================================|choice 7|==========================================
                case "7":
                    Option7.Start();
                    goto start;

                //==========================================|choice 8|==========================================
                case "x":
                    Environment.Exit(0);
                    break;

                //==========================================|if userimp is not valid|==========================================
                default:
                    goto start;
            }
        }
    }
}