using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class Factors
    {

        // Function to find factors of a number
        public int[] findFactors(int num)

        {
            int count = 0;

            // Count the number of factors
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
                
            }

            // Create an array to store the factors
            int[] factors = new int[count];
            int idx = 0;

            // Find and store the factors
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    factors[idx++] = i;
            }

            return factors;
            
        }

        // Function to find sum of factors
        public int findSum(int[] factors)
        {
            int sum = 0;
            for(int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }

            return sum;
        }

        // Function to find product of factors
        public int findProduct(int[] factors)
        {
            int product = 1;

            for (int i = 0; i < factors.Length; i++)
            {

                product *= factors[i];
            }

            return product;
        }

        // Function to find sum of squares of factors
        public int findSumOfSquares(int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i] * factors[i];
            }
            return sum;
        }

        // Main method
        static void Main(string[] args)
        {
            Factors fact = new Factors();
            Console.WriteLine("Enter a number :");
            int num = int.Parse(Console.ReadLine());

            int[] factors = fact.findFactors(num);

            int sum = fact.findSum(factors);

            
            int product = fact.findProduct(factors);

            int sumOfSquares = fact.findSumOfSquares(factors);

            //displaying the result

            for (int i = 0; i < factors.Length; i++)
            {
                Console.WriteLine("factor of the number : " + factors[i]);
            }

            Console.WriteLine("sum of the factors : " + sum);
            Console.WriteLine("product of the factors : " + product);
            Console.WriteLine("Sum of Squares of the factors : " + sumOfSquares);
        }
    }
}
