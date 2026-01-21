using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class SetUnionIntersectionApp
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

            HashSet<int> union = new HashSet<int>(set1);
            union.UnionWith(set2);

            HashSet<int> intersection = new HashSet<int>(set1);
            intersection.IntersectWith(set2);

            Console.WriteLine("Union: " + string.Join(" ", union));
            Console.WriteLine("Intersection: " + string.Join(" ", intersection));
        }
    }

}
