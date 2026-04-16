using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.ZeroSumSubarrays
{ 

        internal class Program
        {
            static void Main(string[] args)
            {
                int[] arr = { 3, 4, -7,50,45,77,-89, 3, 1, 3, 1, -4 };

                ZeroSumSubarrayFinder finder = new ZeroSumSubarrayFinder();
                finder.FindAllZeroSumSubarrays(arr);

                Console.ReadLine();
            }
        }
}

