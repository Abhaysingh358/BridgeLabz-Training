using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class PrimeNumberChecker
    {
        public static string IsPrime(int num)
        {
            // prime numbers are greater than 1
            if (num <= 1)
            {
                return $"{num} is not a prime number.";
            }

            // checking for factors from 2 to num/2 . Because the number which is
            // greater the num/2 , it cannot be a factor
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return $"{num} is not a prime number.";
                }
            }

            return $"{num} is a prime number.";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is prime:");
            int num = int.Parse(Console.ReadLine());

            // calling the method to check if the number is prime
            string result = IsPrime(num);

            Console.WriteLine(result);
        }
    }
}
