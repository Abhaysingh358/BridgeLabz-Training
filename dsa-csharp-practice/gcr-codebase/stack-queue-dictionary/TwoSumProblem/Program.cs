using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.TwoSumProblem
{
  
        internal class Program
        {
            static void Main(string[] args)
            {
                // Input array size
                Console.Write("Enter number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[n];

                // Input array elements
                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Input target sum
                Console.Write("Enter target sum: ");
                int target = Convert.ToInt32(Console.ReadLine());

                TwoSumFinder finder = new TwoSumFinder();
                int[] result = finder.FindTwoSum(arr, target);

                if (result[0] != -1)
                {
                    Console.WriteLine(
                        $"Indices found: {result[0]} and {result[1]}"
                    );
                }
                else
                {
                    Console.WriteLine("No valid pair found.");
                }

               
            }
        }
}


