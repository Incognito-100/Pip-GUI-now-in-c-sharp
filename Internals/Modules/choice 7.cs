using System.Diagnostics;

namespace pipGUI
{
    internal class optionsOP7
    {
        public static void opt7()
        {
            Console.Clear();

            string com = "/C pip freeze > requirements.txt";
            Process.Start("CMD.exe", com);

            string filee = "/C pip uninstall -r requirements.txt -y";
            Process.Start("CMD.exe", filee);

            string scom = "/C pip cache purge";
            Process.Start("CMD.exe", scom);

            Thread.Sleep(1000);

            string rmfile = "/C del requirements.txt";
            Process.Start("CMD.exe", rmfile);

            Console.ReadKey();
            Console.Clear();
        }
    }
}