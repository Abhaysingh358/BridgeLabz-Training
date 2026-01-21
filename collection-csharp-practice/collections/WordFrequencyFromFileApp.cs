using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class WordFrequencyFromFileApp
    {
        static void Main()
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("File not found!");
                return;
            }

            string text = File.ReadAllText(path);

            Dictionary<string, int> map = new Dictionary<string, int>();
            string word = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsLetterOrDigit(c))
                {
                    word += char.ToLower(c);
                }
                else
                {
                    if (word.Length > 0)
                    {
                        if (map.ContainsKey(word)) map[word]++;
                        else map[word] = 1;
                        word = "";
                    }
                }
            }

            // Last word
            if (word.Length > 0)
            {
                if (map.ContainsKey(word)) map[word]++;
                else map[word] = 1;
            }

            Console.WriteLine("\nWord Frequencies:");
            foreach (var kv in map)
                Console.WriteLine(kv.Key + " -> " + kv.Value);
        }
    }

}
