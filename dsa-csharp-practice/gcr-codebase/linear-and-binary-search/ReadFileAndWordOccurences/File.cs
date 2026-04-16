using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.ReadFileAndWordOccurences
{
    internal class CountOccurences
    {
        public object StringComparision { get; private set; }

        public void Count()
        {
            Console.WriteLine("enter the file path");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("File not found"); return;
            }

            Console.Write("Enter the word to search: ");
            string word = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine(" Word cannot be empty!");
                return;
            }

            int count = 0;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t' },
                            StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (words[i].Equals(word, StringComparison.OrdinalIgnoreCase))
                            {
                                count++;
                            }
                        }
                    }

                }
                Console.WriteLine($"\nThe word '{word}' appeared {count} time(s) in the file.");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
