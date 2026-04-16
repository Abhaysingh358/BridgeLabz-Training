using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.SlidingWindowMaximum
{
    internal class SlidingWindowMax
    {
        public int[] GetMax(int[] arr, int k)
        {
            int n = arr.Length;
            int[] result = new int[n - k + 1];

            Deque deque = new Deque(n);
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                // Remove indices outside the window
                if (!deque.IsEmpty() && deque.GetFront() <= i - k)
                {
                    deque.RemoveFront();
                }

                // Remove smaller elements from rear
                while (!deque.IsEmpty() && arr[deque.GetRear()] <= arr[i])
                {
                    deque.RemoveRear();
                }

                deque.AddRear(i);

                // Window is ready
                if (i >= k - 1)
                {
                    result[index++] = arr[deque.GetFront()];
                }
            }

            return result;
        }
    }
}
