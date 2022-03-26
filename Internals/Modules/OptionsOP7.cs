using System.Diagnostics;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class OptionsOP7
    {
        public static void Start()
        {
            Console.Clear();

            string temppath = Path.GetTempPath();
            Directory.SetCurrentDirectory(temppath);

            string com = "/C pip freeze > requirements.txt";
            Process.Start("CMD.exe", com);

            try
            {
                string filee = "/C pip uninstall -r requirements.txt -y";
                Process.Start("CMD.exe", filee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
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
}