//8.Write a program to find the smallest and the largest of the 3 numbers.
//Hint => 
//Take user input for 3 numbers
//Write a single method to find the smallest and largest of the three numbers
//public static int[] FindSmallestAndLargest(int number1, int number2, int number3)

// 25 Dec 2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class FindLargest
    {
        // using inbuilt standard libraries methods (Maths.Min , Maths.Max) to compare numbers 
        public int[] SmallestAndLargest(int num1 , int num2 , int num3) // array to store smallest and largest number
        {
            int smallest = Math.Min(num1, Math.Min(num2, num3));

            int largest = Math.Max(num1, Math.Max(num2, num3));
                                                                                         
            return new int[] { smallest, largest };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            FindLargest findLargest = new FindLargest();

            // calling method to find smallest and largest number
            int[] result = findLargest.SmallestAndLargest(num1, num2, num3);

            Console.WriteLine("Smallest number is :  " +  result[0]);
            Console.WriteLine("largest number is :  " + result[1]);
        }
    }
}
