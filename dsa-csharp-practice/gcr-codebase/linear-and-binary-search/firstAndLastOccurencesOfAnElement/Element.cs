using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.firstAndLastOccurencesOfAnElement
{
    internal class Element
    {
        int[] arr;
        int size;
        int target;

        public void Input()
        {
            Console.WriteLine("Enter the number in sorted order.\nif not, program will sort the number "
                + " then index of the given number will be changed");

            Console.WriteLine("\n\nEnter the Size Of An Array ");
            size = int.Parse(Console.ReadLine());
            arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + " NUmber Of An Array");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter the Target Value");
            target = int.Parse(Console.ReadLine());

            Array.Sort(arr);
        }

        public void FirstOccurences()
        {

            int first = 0, left = 0, right = size - 1, ans = -1;


            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    ans = mid;

                    right = mid - 1;


                }

                else if (arr[mid] < target)
                {
                    left = mid + 1; ;
                }
                else
                {
                    right = mid - 1;
                }

            }

            Console.WriteLine(ans);
        }

        public void LastOccurences()
        {
            int last = 0, left = 0, right = size - 1, ans = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    ans = mid;

                    left = mid + 1;
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

            Console.WriteLine(ans);
        }

        public void Occurences()
        {
            Input();
            FirstOccurences();
            LastOccurences();
        }
    }
}
