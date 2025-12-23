using System;

namespace BridgeLabz.arrays.level01
{
    internal class MultiplicationSixToNine
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number for multiplication
            Console.Write("Enter the value: ");
            int num = int.Parse(Console.ReadLine());

            // Create an array to store the results 
            int[] arr = new int[4];
            int idx = 0; // This index will be used to store values in the array

            // Loop from 6 to 9 (i < 10 means it stops at 9)
            for (int i = 6; i < 10; i++)
            {
                // Multiply the number with the current value of i
                arr[idx] = num * i;

                // Print the multiplication result in a clean format
                Console.WriteLine($"{num} * {i} = {arr[idx]}");

                // Move to the next index in the array
                idx++;
            }

        }
    }
}
