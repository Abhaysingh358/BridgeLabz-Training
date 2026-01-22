using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class SetEqualityChecker
    {
        static HashSet<int> ReadSet()
        {
            Console.Write("Enter size of set: ");
            int n = int.Parse(Console.ReadLine());

            HashSet<int> set = new HashSet<int>();
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                set.Add(int.Parse(Console.ReadLine()));

            return set;
        }

        static void Main()
        {
            Console.WriteLine("Set 1:");
            var s1 = ReadSet();

            Console.WriteLine("Set 2:");
            var s2 = ReadSet();

            Console.WriteLine("Sets Equal? " + s1.SetEquals(s2));
        }
    }

}
