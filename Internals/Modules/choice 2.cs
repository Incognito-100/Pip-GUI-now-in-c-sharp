namespace idk_whayt_to_maek.Internals.Modules
{
    internal class optionsOP2
    {
        public static void opt2()
        {
            Console.Clear();
            string opt2sel;

            Console.Write("imput a pacage you want to install > ");
            string userimpot1 = Console.ReadLine();

            opt2sel = "/C pip install " + userimpot1;
            System.Diagnostics.Process.Start("CMD.exe", opt2sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}