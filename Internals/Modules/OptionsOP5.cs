using System.Diagnostics;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class OptionsOP5
    {
        public static void Start()
        {
            Console.Clear();

            Console.Write("drag requirements file to uninstall on to the console");
            Console.Write("> ");

            string userimpot4 = Console.ReadLine();

            string opt5sel = "/C pip uninstall -r " + userimpot4 + " -y";
            Process.Start("CMD.exe", opt5sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}