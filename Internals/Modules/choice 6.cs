namespace idk_whayt_to_maek.Internals.Modules
{
    internal class optionsOP6
    {
        public static void opt6()
        {
        start:
            Console.Clear();

            Console.WriteLine("drag python file onto the console");
            Console.Write("> ");

            string filename = Console.ReadLine();

            if (filename == null)
                return;

            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] s = line.Split("import");

                //  s[0] = before delimiter
                //  s[1] = after delimiter

                Console.WriteLine(s[0]);
                Console.WriteLine(s[1]);
                Console.ReadKey();
            }
        }
    }
}