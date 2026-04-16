using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.ReadFileLineByLine
{
    internal class ReadFile
    {
        public void Readfile()
        {
            Console.WriteLine("Enter the file Path");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("File not found"); return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
