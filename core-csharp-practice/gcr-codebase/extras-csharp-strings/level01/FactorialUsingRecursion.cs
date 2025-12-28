using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class FactorialUsingRecursion
    {
        public static long Factorial(int n)
        {

            // base case
            if (n == 0 || n == 1)
            {
                return 1;
            }

            // recursive case
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int num = int.Parse(Console.ReadLine());

            // calling the method to calculate factorial
            long result = Factorial(num);
            Console.WriteLine($"Factorial of {num} is: {result}");
        }
    }
}
