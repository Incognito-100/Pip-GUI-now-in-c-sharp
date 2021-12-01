namespace pipGUI
{
    internal class optionsOP1
    {
        public static void opt1()
        {
            Console.Clear();
            string opt1sel;
            opt1sel = "/C pip list";
            System.Diagnostics.Process.Start("CMD.exe", opt1sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}