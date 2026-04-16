using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class ListRotator
    {
        static List<int> RotateLeft(List<int> list, int k)
        {
            int n = list.Count;
            k %= n;

            List<int> rotated = new List<int>();

            for (int i = k; i < n; i++) rotated.Add(list[i]);
            for (int i = 0; i < k; i++) rotated.Add(list[i]);

            return rotated;
        }

        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                list.Add(int.Parse(Console.ReadLine()));

            Console.Write("Rotate by k: ");
            int k = int.Parse(Console.ReadLine());

            var rotated = RotateLeft(list, k);

            Console.WriteLine("Rotated List:");
            foreach (var x in rotated) Console.Write(x + " ");
        }
    }

}
