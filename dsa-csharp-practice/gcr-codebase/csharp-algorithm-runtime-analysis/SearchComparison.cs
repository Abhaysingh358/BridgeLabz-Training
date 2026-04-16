using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.csharp_algorithm_runtime_analysis
{
    internal class SearchComparison
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };
            int target = -1; // worst-case (not present)

            foreach (int size in sizes)
            {
                int[] data = GenerateData(size);

                Console.WriteLine("\nDataset Size: " + size);

                // Linear Search
                Stopwatch sw = Stopwatch.StartNew();
                LinearSearch(data, target);
                sw.Stop();
                Console.WriteLine($"Linear Search Time:" + sw.ElapsedTicks + " ticks");

                // Binary Search (sort first)
                Array.Sort(data);

                sw.Restart();
                BinarySearch(data, target);
                sw.Stop();
                Console.WriteLine("Binary Search Time: " + sw.ElapsedTicks + " ticks");
            }
        }
        static Random Random = new Random();
        static int[] GenerateData(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = Random.Next(1, size);
            return arr;
        }

        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
