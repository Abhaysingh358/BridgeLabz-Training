using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.RotaionPointInRotatedArray
{
    internal class RotationPoint
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

        public void FindRotation()
        {
            Input();

            int left = 0 , right = arr.Length-1;

            while(left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] > arr[right])
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid;
                }
            }

            Console.WriteLine($"The rotated Pointer in a rotated array is : {left}");
            Console.WriteLine($"The rotated array is : {String.Join(",", arr)}");
        }
    }
}
