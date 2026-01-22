using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class RemoveDuplicatesApp
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            HashSet<int> seen = new HashSet<int>();

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(Console.ReadLine());
                if (!seen.Contains(val))
                {
                    seen.Add(val);
                    list.Add(val);
                }
            }

            Console.WriteLine("After removing duplicates:");
            foreach (var x in list) Console.Write(x + " ");
        }
    }

}
