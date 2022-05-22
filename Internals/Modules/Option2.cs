using System.Diagnostics;
using System.Net;

namespace idk_whayt_to_maek.Internals.Modules
{
    internal class Option2
    {
        public static void Start()
        {
        Start:
            Console.Clear();
            Console.WriteLine("imput a pacage you want to install");
            Console.Write("> ");

            string instpacname = Console.ReadLine();

            //==========================================|no package to install|==========================================
            if (instpacname == null || instpacname.Length == 0)
            {
                Console.WriteLine("no pacage given");
                Thread.Sleep(3000);
                goto Start;
            }
            //==========================================|install package|==========================================
            else
            {
                string api = $"https://pypi.org/pypi/{instpacname}/json";
                var client = new WebClient();

                try
                {
                    var res = client.DownloadString(api);
                }
                catch
                {
                    Console.WriteLine("pacage dosnt exist");
                    Thread.Sleep(3000);
                    goto Start;
                }
                //==========================================|install|==========================================
                string command = $"/C pip install {instpacname}";
                Process.Start("CMD.exe", command);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}