namespace idk_whayt_to_maek.Internals.Modules
{
    internal class OptionsOP1
    {
        public static void Start()
        {
            Console.Clear();

            string opt1sel = "/C pip list";
            System.Diagnostics.Process.Start("CMD.exe", opt1sel);

            Console.WriteLine();
            Console.WriteLine("hit any key to exit");

            Console.ReadKey();

            Console.Clear();
        }
    }
}