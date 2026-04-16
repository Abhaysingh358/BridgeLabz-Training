using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class NumberCheckerUtilityExtend
    {
        // check prime number 
        public static bool isprimeNumber(int num)
        {
            if(num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // check neon number
        public static bool IsNeonNumber(int num) { 
         int sqr = (int) Math.Pow(num, 2);
        int sum = 0;
            while(sqr != 0)
            {
                int digit = sqr % 10;
                sum += digit;
                sqr = sqr / 10;
            }
            if(sum == num)
            {
                return true;
            }
            return false;
        }

        // check spy number
        public static bool isSpyNumber(int num)
        {
            int sum = 0;
            int product = 1;
            
            while(num != 0)
            {
                int digit = num % 10;
                sum += digit;
                product *= digit;
                num = num / 10;
            }
            if(sum == product)
            {
                return true;
            }
            return false;

        }

        // check automorphic number
        public static bool IsAutomorphicNumber(int num)
        {
            int sqr = (int)Math.Pow(num, 2);
            int temp = num;
            int count = 0;
            while(temp != 0)
            {
                count++;
                temp = temp / 10;
            }
            int divisor = (int)Math.Pow(10, count);

            int lastDigits = sqr % divisor;

            if(lastDigits == num)
            {
                return true;
            }
            return false;
        }

        // check buzz number
        public static bool IsBuzzNumber(int num)
        {
            if(num % 7 == 0 || num % 10 == 7)
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            // calling methods and displaying results
            Console.WriteLine("Is Prime Number : " + isprimeNumber(num));
            Console.WriteLine("Is Neon Number : " + IsNeonNumber(num));
            Console.WriteLine("Is Spy Number : " + isSpyNumber(num));
            Console.WriteLine("Is Automorphic Number : " + IsAutomorphicNumber(num));
            Console.WriteLine("Is Buzz Number : " + IsBuzzNumber(num));

        }
    }
}
