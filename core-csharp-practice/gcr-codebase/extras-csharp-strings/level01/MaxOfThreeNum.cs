using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class MaxOfThreeNum
    {
        public static string MaxNumber(int num1, int num2, int num3)
        {
            // comparing three numbers to find the maximum
            if (num1 >= num2 && num1 >= num3)
            {
                return $"{num1} is the maximum number in {num1} ,{num2} ,{num3}";
            }
            // else if to check if num2 is maximum
            else if (num2 >= num1 && num2 >= num3)
            {
                return $"{num2} is the maximum number in {num1} ,{num2} ,{num3}";
            }
            // else num3 is maximum
            else
            {
                return $"{num3} is the maximum number in {num1} ,{num2} ,{num3}";
            }
        }
        static void Main(string[] args)
        {
            // taking input from user
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int num3 = int.Parse(Console.ReadLine());

            // calling the method to find maximum number
            string result = MaxNumber(num1, num2, num3);
            // displaying result
            Console.WriteLine(result);
        }
    }
}
