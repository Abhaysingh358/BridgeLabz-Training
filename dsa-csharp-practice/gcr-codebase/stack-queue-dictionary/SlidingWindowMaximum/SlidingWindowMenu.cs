using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.SlidingWindowMaximum
{
    internal class SlidingWindowMenu
    {
        public void Run()
        {
            SlidingWindowMax solver = new SlidingWindowMax();

            Console.Write("Enter array size: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter window size k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] result = solver.GetMax(arr, k);

            Console.WriteLine("\nSliding Window Maximum:");
            foreach (int val in result)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}

