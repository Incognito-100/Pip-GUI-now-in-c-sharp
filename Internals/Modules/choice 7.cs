namespace pipGUI
{
    internal class optionsOP7
    {
        public static void opt7()
        {
            Console.Clear();

            string com = "/C pip freeze > requirements.txt";
            System.Diagnostics.Process.Start("CMD.exe", com);

            string filee = "/C pip uninstall -r requirements.txt -y";
            System.Diagnostics.Process.Start("CMD.exe", filee);

            string scom = "/C pip cache purge";
            System.Diagnostics.Process.Start("CMD.exe", scom);

            Console.WriteLine("press any key to delete file");
            Console.ReadKey();

            string rmfile = "/C del requirements.txt";
            System.Diagnostics.Process.Start("CMD.exe", rmfile);

            Console.ReadKey();
            Console.Clear();
        }
    }
}