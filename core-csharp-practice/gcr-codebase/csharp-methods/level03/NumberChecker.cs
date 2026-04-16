using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class NumberChecker
    {
        // Method to calculate factors of a number using 2 loops
        public static int[] CalculateFactors(int num)
        {
            int count = 0;

            
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            // Create array using count
            int[] factors = new int[count];
            int idx = 0;

            //storing factors in array
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factors[idx] = i;
                    idx++;
                }
            }

            return factors;
        }

        // Greatest factor
        public static int CalculateGreatestFactor(int[] factors)
        {
            int max = factors[0];
            for (int i = 1; i < factors.Length; i++)
            {
                if (factors[i] > max)
                {
                    max = factors[i];
                }
            }
            return max;
        }

        //  Sum of factors
        public static int CalculateSumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }

        //  Product of factors
        public static long CalculateProductOfFactors(int[] factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }

        //  Product of cubes of factors
        public static double CalculateProductOfCubeOfFactors(int[] factors)
        {
            double product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= Math.Pow(factors[i], 3);
            }
            return product;
        }

        //  factorial
        public static int CalculateFactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        // Perfect number check
        public static bool IsPerfectNumber(int num, int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length - 1; i++)
            {
                sum += factors[i];
            }

            return sum == num;
        }

        //  Abundant number check
        public static bool IsAbundantNumber(int num, int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length - 1; i++)
            {
                sum += factors[i];
            }

            return sum > num;
        }

        //  Deficient number check
        public static bool IsDeficientNumber(int num, int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length - 1; i++)
            {
                sum += factors[i];
            }

            return sum < num;
        }

        //  Strong number check
        public static bool IsStrongNumber(int num)
        {
            int temp = num;
            int sum = 0;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += CalculateFactorial(digit);
                temp /= 10;
            }

            return sum == num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            int[] factors = CalculateFactors(num);

            Console.WriteLine("\nFactors of " + num + ":");
            foreach (int f in factors)
            {
                Console.Write(f + " ");
            }
           

            Console.WriteLine("\nGreatest Factor : " + CalculateGreatestFactor(factors));

            int sum = CalculateSumOfFactors(factors);
            Console.WriteLine("Sum of Factors : " + sum);

            long product = CalculateProductOfFactors(factors);
            Console.WriteLine("Product of Factors : " + product);

            double cubeProduct = CalculateProductOfCubeOfFactors(factors);
            Console.WriteLine("Product of Cubes of Factors : " + cubeProduct);

            Console.WriteLine("\nPerfect Number : " + IsPerfectNumber(num, factors));
            Console.WriteLine("Abundant Number  : " + IsAbundantNumber(num, factors));
            Console.WriteLine("Deficient Number : " + IsDeficientNumber(num, factors));
            Console.WriteLine("Strong Number : " + IsStrongNumber(num));
        }
    }
}

