using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.PairWithGivenSum
{
   
        public class PairSumChecker
        {
            public bool HasPairWithSum(int[] arr, int target)
            {
                Dictionary<int, bool> visited = new Dictionary<int, bool>();

                foreach (int num in arr)
                {
                    int needed = target - num;

                    // Check if required number already exists
                    if (visited.ContainsKey(needed))
                    {
                        Console.WriteLine(
                            $"Pair found: {num} + {needed} = {target}"
                        );
                        return true;
                    }

                    // Store current number as visited
                    if (!visited.ContainsKey(num))
                    {
                        visited[num] = true;
                    }
                }

                return false;
            }
        }
}


