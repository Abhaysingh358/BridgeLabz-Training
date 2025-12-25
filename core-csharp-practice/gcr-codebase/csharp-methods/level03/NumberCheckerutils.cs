using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class NumberCheckerutils
    {
        // count the digits in a number
        public static int Count(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }

        // store digits of a number in an array
        public static int[] StoreDigits(int num)
        {
            int size = Count(num);
            int[] digits = new int[size];
            int idx = size - 1;
            while (num != 0)
            {
                int digit = num % 10;
                digits[idx] = digit;
                idx--;
                num = num / 10;
            }
            return digits;
        }
        // reverse the digits of a number stored in an array
        public static int[] reverseDigitsArray(int[] digit)
        {
            int[] reversedDigit = new int[digit.Length];
            int idx = 0;
            int lastIdx = digit.Length - 1;
            while (idx < digit.Length)
            {
                reversedDigit[idx] = digit[lastIdx];
                idx++;
                lastIdx--;
            }
            return reversedDigit;
        }

        // check if two arrays are equal
        public static bool IsArrayEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        // check Palindrome number
        public static bool  IsPalindrome(int num)
        {
            int newNum = 0;
            while (num != 0)
            {

                newNum = num % 10 + newNum*10 ;
                num = num / 10;

            }
            if(num == newNum) {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check Duck number
        public static bool IsDuckNumber(int num)
        {
            while (num != 0)
            {
                int digit = num % 10;
                if (digit == 0)
                {
                    return true;
                }
                num = num / 10;
            }
            return false;
        }



        static void Main(string[] args)
        {
            // taking input from user
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            int totaldigits = Count(num);
            Console.WriteLine("Total digits in the number : " + totaldigits);

            int[] digits = StoreDigits(num);
            for(int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i] + " ");
            }

            // assigning methods and displaying reverse the digits array
            int[] reversedDigits = reverseDigitsArray(digits);
            Console.WriteLine("\n Reversed digits are : ");
            for(int i = 0; i < reversedDigits.Length; i++)
            {
                Console.Write(reversedDigits[i] + " ");
            }

            //  displaying equal number
            bool isEqual = IsArrayEqual(digits, reversedDigits);
            if(isEqual)
            {
                Console.WriteLine(" \nThe number is a Palindrome number");
            }
            else
            {
                Console.WriteLine("\nThe number is not a Palindrome number");
            }

            // displaying Duck number
            bool isDuck = IsDuckNumber(num);
            if(isDuck)
            {
                Console.WriteLine("\nThe number is a Duck number");
            }
            else
            {
                Console.WriteLine("\nThe number is not a Duck number");
            }
        }
    }
}
