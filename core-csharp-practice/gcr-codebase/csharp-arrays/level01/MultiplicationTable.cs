using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level01
{
    internal class MultiplicationTable
    {
        static void Main()
        {
            // 1. Get an integer input
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // 2. Define an integer array to store results from 1 to 10
            int[] results = new int[10];

            // 3. Run a loop to calculate and store results
            for (int i = 1; i <= 10; i++)
            {
                // Array indices start at 0, so result of (number * 1) goes to index 0
                results[i - 1] = num * i;
            }

            // 4. Display the result from the array in the specified format
            Console.WriteLine($"\nMultiplication Table for {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} *{i} = {results[i - 1]}");
            }
        }

    }
}
