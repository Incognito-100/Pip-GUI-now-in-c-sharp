using System.Diagnostics;

namespace pipGUI
{
    internal class optionsOP4
    {
        public static void opt4()
        {
            Console.Clear();
            string opt4sel;

            Console.Write("drag requirements file to install on to the console > ");
            string userimpot3 = Console.ReadLine();

            opt4sel = "/C pip install -r " + userimpot3;
            Process.Start("CMD.exe", opt4sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}