namespace idk_whayt_to_maek.Internals.Modules
{
    internal class Option6
    {
        public static void Start()
        {
        stort:
            //==========================================|get file from user|==========================================
            Console.Clear();
            Console.WriteLine("drag python file onto the console");
            Console.WriteLine("NOTE: the txt file will be made in the directory of the python file");
            Console.Write("> ");
            string filename = Console.ReadLine();

            //==========================================|setup list|==========================================
            List<string> imports = new List<string>();
            List<string> cleand = new List<string>();

            //==========================================|if input empty|==========================================
            if (filename == null || filename.Length == 0)
            {
                goto stort;
            }
            //==========================================|get imports|==========================================
            else
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    if (line.Contains("import"))
                    {
                        imports.Add(line);
                    }
                }

                //==========================================|cleanup inports|==========================================
                foreach (string line in imports)
                {
                    string clen = line.Replace("from ", "").Replace("import ", "").Replace(" ", "");
                    cleand.Add(clen);
                }

                Directory.SetCurrentDirectory(Directory.GetCurrentDirectory());
                File.WriteAllLines($"{filename}-imports.txt", cleand);
            }
        }
    }
}