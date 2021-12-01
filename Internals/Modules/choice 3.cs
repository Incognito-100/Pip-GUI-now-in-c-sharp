namespace pipGUI
{
    internal class optionsOP3
    {
        public static void opt3()
        {
            Console.Clear();
            string opt3sel;

            Console.Write("imput a pacage you want to uninstall > ");
            string userimpot2 = Console.ReadLine();

            opt3sel = "/C pip uninstall " + userimpot2 + " -y";
            System.Diagnostics.Process.Start("CMD.exe", opt3sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}