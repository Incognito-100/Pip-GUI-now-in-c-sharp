using System.Diagnostics;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class OptionsOP3
    {
        public static void Start()
        {
            Console.Clear();
            string opt3sel;

            Console.Write("imput a pacage you want to uninstall > ");
            string userimpot2 = Console.ReadLine();

            opt3sel = "/C pip uninstall " + userimpot2 + " -y";
            Process.Start("CMD.exe", opt3sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}