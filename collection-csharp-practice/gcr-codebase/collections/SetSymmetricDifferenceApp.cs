using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class SetSymmetricDifferenceApp
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
            Console.WriteLine("Enter Set1:");
            var set1 = ReadSet();

            Console.WriteLine("Enter Set2:");
            var set2 = ReadSet();

            HashSet<int> symDiff = new HashSet<int>(set1);
            symDiff.SymmetricExceptWith(set2);

            Console.WriteLine("Symmetric Difference: " + string.Join(" ", symDiff));
        }
    }

}
