using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class WordCount
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.ToLower().Split(
                            new char[] { ' ', '\t', ',', '.', ';', ':', '!', '?' },
                            StringSplitOptions.RemoveEmptyEntries
                        );

                        foreach (string word in words)
                        {
                            if (wordCount.ContainsKey(word))
                                wordCount[word]++;
                            else
                                wordCount[word] = 1;
                        }
                    }
                }

                var topWords = wordCount
                    .OrderByDescending(w => w.Value)
                    .Take(5);

                Console.WriteLine("Top 5 most frequent words:");
                foreach (var word in topWords)
                {
                    Console.WriteLine($"{word.Key} : {word.Value}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
