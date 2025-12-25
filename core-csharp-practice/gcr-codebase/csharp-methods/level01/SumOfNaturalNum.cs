using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class SumOfNaturalNum
    {
        // Method to calculate sum of first n natural numbers
        public int Sum(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }

            return sum;
        }

        // Main method to test the Sum method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number: ");
            int num = int.Parse(Console.ReadLine());

            SumOfNaturalNum total = new SumOfNaturalNum();

            int result = total.Sum(num);

            Console.WriteLine($"The sum of the first {num} natural numbers is: {result}");
        }
    }
}
