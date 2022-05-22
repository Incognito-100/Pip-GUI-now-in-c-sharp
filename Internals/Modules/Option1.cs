using System.Diagnostics;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class Option1
    {
        public static void Start()
        {
            Console.Clear();

            string opt1sel = "/C pip list";
            Process.Start("CMD.exe", opt1sel);

            Console.ReadKey();
            Console.Clear();
        }
    }
}