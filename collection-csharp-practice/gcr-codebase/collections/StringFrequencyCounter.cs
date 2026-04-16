using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class StringFrequencyCounter
    {
        static Dictionary<string, int> Frequency(List<string> list)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string item in list)
            {
                if (map.ContainsKey(item)) map[item]++;
                else map[item] = 1;
            }

            return map;
        }

        static void Main()
        {
            Console.Write("Enter number of strings: ");
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            Console.WriteLine("Enter strings:");
            for (int i = 0; i < n; i++)
                list.Add(Console.ReadLine());

            var result = Frequency(list);

            Console.WriteLine("Frequencies:");
            foreach (var kv in result)
                Console.WriteLine(kv.Key + " -> " + kv.Value);
        }
    }

}
