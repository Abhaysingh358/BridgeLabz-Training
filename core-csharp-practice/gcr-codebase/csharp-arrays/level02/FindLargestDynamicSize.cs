using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class FindLargestDynamicSize
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            // Handle the edge case where the user enters 0
            if (num == 0)
            {
                Console.WriteLine("\n Largest digit : 0");
                Console.WriteLine("\n Second  Largest digit : -1");
                return;
            }

            int maxDigit = 10;
            int[] digits = new int[10];

            int idx = 0;

            for (int i = Math.Abs(num); i > 0; i /= 10)
            {

                int digit = i % 10;
                if (idx == maxDigit)
                {
                    maxDigit = maxDigit + 10;
                    int[] tempDigits = new int[maxDigit];

                    for (int j = 0; j < digits.Length; j++)
                    {
                        tempDigits[j] = digits[j];
                    }
                    digits = tempDigits;
                }

                digits[idx] = digit;
                idx++;
            }

            //this below block of code extract largest and second largest code
            int largestDigit = -1;
            int SecondLargestDigit = -1;

            for (int i = 0; i < idx; i++)
            {
                if (digits[i] > largestDigit)
                {
                    SecondLargestDigit = largestDigit;
                    largestDigit = digits[i];

                }
                else if (digits[i] > SecondLargestDigit && digits[i] != largestDigit)
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