using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.FirstMissingPositiveAndTargetIndex
{
    internal class Search
    {
        int[] arr;
        int size;
        int target;

        public void Input()
        {
            Console.WriteLine("Enter the Size Of An Array");
            size = int.Parse(Console.ReadLine());

            arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " Number Of An Array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter the Target Value");
            target = int.Parse(Console.ReadLine());
        }

        public void FirstMissingPositive()
        {
            bool[] visited = new bool[size + 1];

            for (int i = 0; i < size; i++)
            {
                if (arr[i] >= 1 && arr[i] <= size)
                {
                    visited[arr[i]] = true;
                }
            }

            for (int i = 1; i <= size; i++)
            {
                if (visited[i] == false)
                {
                    Console.WriteLine("First Missing Positive Integer is : " + i);
                    return;
                }
            }

            Console.WriteLine("First Missing Positive Integer is : " + (size + 1));
        }

        public void FindTargetIndex()
        {
            Array.Sort(arr);

            int left = 0, right = size - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    Console.WriteLine($"Target Value : {target} : is at Index  : " + mid);
                    return;
                }

                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine($"Target Index of {target} is : -1");
        }

        public void Result()
        {
            Input();
            FirstMissingPositive();
            FindTargetIndex();
        }
    }
}
