using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.PeakElement
{
    internal class PeakElement
    {

        int[] arr;
        public void Input()
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = int.Parse(Console.ReadLine());

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the {i + 1} of the Array");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void FindPeakElement()
        {
            Input();
            int left = 0, right = arr.Length - 1;

            if (arr[0] >= arr[1])
            {
                Console.WriteLine($"Peak Element: {arr[0]} at index 0");
                return;
            }

            // Edge case: check last index
            if (arr[arr.Length - 1] >= arr[arr.Length - 2])
            {
                Console.WriteLine($"Peak Element: {arr[arr.Length - 1]} at index {arr.Length - 1}");
                return;
            }

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] > arr[mid+1])
                {
                    right = mid;
                }

                else
                {
                    left = mid+1;
                }
            }

            Console.WriteLine($"The Peak Element in array is {arr[left]}" +
                $" in {String.Join(",",arr)}");
        }
    }
}
