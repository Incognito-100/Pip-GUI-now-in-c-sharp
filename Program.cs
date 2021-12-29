using Console = Colorful.Console;

namespace pipGUI
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
            Console.Write("> ");

            //==========================================|get key imput|==========================================
            string userinput = Console.ReadLine();

            //==========================================|choice 1|==========================================
            if (userinput == "1")
            {
                optionsOP1.opt1();
                goto start;
            }

            //==========================================|choice 2|==========================================
            if (userinput == "2")
            {
                optionsOP2.opt2();
                goto start;
            }

            //==========================================|choice 3|==========================================
            if (userinput == "3")
            {
                optionsOP3.opt3();
                goto start;
            }

            //==========================================|choice 4|==========================================
            if (userinput == "4")
            {
                optionsOP4.opt4();
                goto start;
            }

            //==========================================|choice 5|==========================================
            if (userinput == "5")
            {
                optionsOP5.opt5();
                goto start;
            }

            //==========================================|choice 6|==========================================
            if (userinput == "6")
            {
                optionsOP6.opt6();
                goto start;
            }

            //==========================================|choice 7|==========================================
            if (userinput == "7")
            {
                optionsOP7.opt7();
                goto start;
            }

            //==========================================|choice 8|==========================================
            if (userinput == "8")
            {
                optionsOP8.opt8();
            }
        }
    }
}