using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.LongestConsecutiveSequence
{
    
        public class LongestSequenceFinder
        {
            public int FindLongestConsecutive(int[] arr)
            {
                Dictionary<int, bool> map = new Dictionary<int, bool>();

                // Store all elements in dictionary
                foreach (int num in arr)
                {
                    if (!map.ContainsKey(num))
                    {
                        map[num] = true;
                    }
                }

                int longest = 0;

                // Find longest consecutive sequence
                foreach (int num in arr)
                {
                    // Check if num is start of sequence
                    if (!map.ContainsKey(num - 1))
                    {
                        int currentNum = num;
                        int currentLength = 1;

                        while (map.ContainsKey(currentNum + 1))
                        {
                            currentNum++;
                            currentLength++;
                        }

                        if (currentLength > longest)
                        {
                            longest = currentLength;
                        }
                    }
                }

                return longest;
            }
        }
}

