using System.Diagnostics;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class Option3
    {
        public static void Start()
        {
            Console.Clear();

            Console.Write("imput a pacage you want to uninstall");
            Console.Write("> ");

            string userimpot2 = Console.ReadLine();

            string opt3sel = $"/C pip uninstall {userimpot2} -y";
            Process.Start("CMD.exe", opt3sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}