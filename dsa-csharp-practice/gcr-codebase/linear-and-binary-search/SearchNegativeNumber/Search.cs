using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.SearchNegativeNumber
{
    internal class Search
    {
        int[] arr;
        public void Input()
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = int.Parse(Console.ReadLine());

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the {i+1} of the Array");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void FindFirstNegative()
        {
            Input();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    Console.WriteLine($"The first negative number is : {arr[i] } in " +
                        $"the {String.Join("," , arr)}");
                    return;
                        
                }
                
            }

            Console.WriteLine("There is No Negative Number in the Array");
        }
    }
}
