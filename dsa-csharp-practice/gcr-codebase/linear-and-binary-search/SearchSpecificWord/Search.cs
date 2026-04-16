using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.SearchSpecificWord
{
    internal class Search
    {
        string[] arr;

         public void Input()
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = int.Parse(Console.ReadLine());

            arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the {i + 1} of the Array");
                arr[i] = (Console.ReadLine());
            }
        }

        public void FindWord()
        {
            Input();

            Console.WriteLine("Enter the Word you have to search");
            string keyWord = Console.ReadLine();

            foreach(string word in arr)
            {
                if (word.Equals(keyWord))
                {
                    Console.WriteLine($"Found!!" +
                        $"you have search for the\" {word}\" in\n {String.Join(", ", arr)}");
                    return;
                }
            }
            Console.WriteLine("Word was not  found");
        }
    }
}
