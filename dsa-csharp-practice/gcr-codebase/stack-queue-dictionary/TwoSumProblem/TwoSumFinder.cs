using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.TwoSumProblem
{
        public class TwoSumFinder
        {
            public int[] FindTwoSum(int[] arr, int target)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();

                for (int i = 0; i < arr.Length; i++)
                {
                    int needed = target - arr[i];

                    // Check if complement exists
                    if (map.ContainsKey(needed))
                    {
                        return new int[] { map[needed], i };
                    }

                    // Store current value with its index
                    if (!map.ContainsKey(arr[i]))
                    {
                        map[arr[i]] = i;
                    }
                }

                // If no pair found (problem usually guarantees one)
                return new int[] { -1, -1 };
            }
        }
}


