using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class LargestAndSecondLargest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  the Number : ");
            int num = int.Parse(Console.ReadLine());

            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int idx = 0;

            // this block of code calculate and store last digit of number
            for (int i = num; i > 0; i /= 10)
            {
                int digit = i % 10;
                digits[idx] = digit;
                idx++;

                if (idx == maxDigit)
                {
                    break;
                }


            }

            // this below block of code extract largest and second largest code
            int largestDigit = 0;
            int SecondLargestDigit = 0;

            for (int i = 0; i < idx; i++)
            {
                if (digits[i] > largestDigit)
                {
                    SecondLargestDigit = largestDigit;
                    largestDigit = digits[i];

                }

                if (digits[i] > SecondLargestDigit && digits[i] != largestDigit)
                {
                    SecondLargestDigit = digits[i];
                }
            }

            // displaying the result
            Console.WriteLine($"\n Largest digit : {largestDigit}");
            Console.WriteLine($"\n Second  Largest digit : {SecondLargestDigit}");

        }
    }
}
