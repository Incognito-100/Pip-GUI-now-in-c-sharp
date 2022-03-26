namespace idk_whayt_to_maek.Internals.Modules
{
    internal class OptionsOP2
    {
        public static void Start()
        {
            Console.Clear();

            Console.Write("imput a pacage you want to install");
            Console.Write("> ");

            string userimpot1 = Console.ReadLine();

            string opt2sel = $"/C pip install {userimpot1}";
            System.Diagnostics.Process.Start("CMD.exe", opt2sel);
            Console.ReadKey();
            Console.Clear();
        }
    }
}