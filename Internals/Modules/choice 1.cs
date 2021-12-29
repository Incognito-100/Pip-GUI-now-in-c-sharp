namespace pipGUI
{
    internal class optionsOP1
    {
        public static void opt1()
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