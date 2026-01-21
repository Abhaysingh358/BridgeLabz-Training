using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    using System;
    using System.Collections.Generic;

    class InvertDictionaryApp
    {
        static void Main()
        {
            Console.Write("Enter number of key-value pairs: ");
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> original = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter key (string): ");
                string key = Console.ReadLine();

                Console.Write("Enter value (int): ");
                int value = int.Parse(Console.ReadLine());

                original[key] = value;
            }

            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

            foreach (var kv in original)
            {
                string key = kv.Key;
                int value = kv.Value;

                if (!inverted.ContainsKey(value))
                    inverted[value] = new List<string>();

                inverted[value].Add(key);
            }

            Console.WriteLine("\nInverted Dictionary:");
            foreach (var kv in inverted)
                Console.WriteLine(kv.Key + " => [" + string.Join(", ", kv.Value) + "]");
        }
    }

}
