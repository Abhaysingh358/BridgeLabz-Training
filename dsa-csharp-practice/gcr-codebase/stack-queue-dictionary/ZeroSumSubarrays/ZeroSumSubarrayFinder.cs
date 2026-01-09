using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.ZeroSumSubarrays
{
  
        public class ZeroSumSubarrayFinder
        {
            public void FindAllZeroSumSubarrays(int[] arr)
            {
                Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

                int prefixSum = 0;

                // Important base case
                map[0] = new List<int> { -1 };

                for (int i = 0; i < arr.Length; i++)
                {
                    prefixSum += arr[i];

                    if (map.ContainsKey(prefixSum))
                    {
                        foreach (int startIndex in map[prefixSum])
                        {
                            Console.WriteLine(
                                $"Zero sum subarray found from index {startIndex + 1} to {i}"
                            );
                        }
                    }

                    if (!map.ContainsKey(prefixSum))
                    {
                        map[prefixSum] = new List<int>();
                    }

                    map[prefixSum].Add(i);
                }
            }
        }
}

