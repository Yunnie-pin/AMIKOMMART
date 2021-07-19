using System.Collections.Generic;
using System.IO;


namespace ppob
{
    public class PrintNota
    {
        private static PrintNota print;
        private readonly string path;

        public PrintNota(string path)
        {
            //path = @"Nota.txt";
            this.path = @path;
        }
        public static PrintNota Instance
        {
            get
            {
                if (print == null) print = new PrintNota("Nota.txt");
                return print;
            }
        }


        public bool WriteToFile(List<string> list)
        {
            try
            {
                File.Delete(path);
                using (var output = new StreamWriter(path))
                {
                    foreach (var line in list)
                    {
                        output.WriteLine(line);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ReadtoFile(List<string> list)
        {
            try
            {
                if (!File.Exists(path))
                {
                    return false;
                }
                else
                {
                    if (list == null)
                    {
                        list = new List<string>();
                    }
                }

                var input = File.OpenText(path);
                var scanner = string.Empty;

                while ((scanner = input.ReadLine()) != null)
                {
                    list.Add(scanner.ToString());
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}