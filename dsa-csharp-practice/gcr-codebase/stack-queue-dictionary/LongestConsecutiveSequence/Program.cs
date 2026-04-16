using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.LongestConsecutiveSequence
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter number of elements: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[n];

                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                LongestSequenceFinder finder = new LongestSequenceFinder();
                int result = finder.FindLongestConsecutive(arr);

                Console.WriteLine("Length of longest consecutive sequence: " + result);

                Console.ReadLine();
            }
        }
}


