using System.Diagnostics;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class optionsOP5
    {
        public static void opt5()
        {
            Console.Clear();
            string opt5sel;

            Console.Write("drag requirements file to uninstall on to the console > ");
            string userimpot4 = Console.ReadLine();

            opt5sel = "/C pip uninstall -r " + userimpot4 + " -y";
            Process.Start("CMD.exe", opt5sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}