using System.Diagnostics;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class OptionsOP4
    {
        public static void Start()
        {
            Console.Clear();

            Console.Write("drag requirements file to install on to the console");
            Console.Write("> ");

            string userimpot3 = Console.ReadLine();

            string opt4sel = $"/C pip install -r {userimpot3}";
            Process.Start("CMD.exe", opt4sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}