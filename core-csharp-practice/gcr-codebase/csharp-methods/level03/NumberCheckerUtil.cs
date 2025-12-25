using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class NumberCheckerUtil
    {
        // count the digits in a number
        public static int count(int num)
        {
            int count = 0;
            while(num != 0)
            {
                num = num / 10;
                count++;
            }   
      
            return count;
        }

        // store digits of a number in an array
        public static int[] StoreDigits(int num)
        {
            int size = count(num);

            int[] digits = new int[size];
            int idx = size - 1;
            while(num != 0)
            {
                int digit = num % 10;
                digits[idx] = digit;
                idx--;
                num = num / 10;
            }
            return digits;
        }

        // sum of digits of a number
        public static int SumOfDigits(int num)
        {
            int [] digit = StoreDigits(num);
            int sum = 0;
            for(int i = 0; i < digit.Length; i++)
            {
                sum +=  digit[i];
            }
            return sum;


        }

        // sum of square of digits of a number
        public static int SumOfSqrDigits(int num)
        {
            int[] digit = StoreDigits(num);

            int sqrSum = 0;
            for(int i = 0; i < digit.Length; i++)
            {
                sqrSum += (int)Math.Pow(digit[i] , 2);
            }
            return sqrSum;
        }

        // check if a number is a Harshad number
        public static bool isHarshadNumber(int num)
        {
            int sum = SumOfDigits(num);
            if(num % sum == 0)
            {
                return true;
            }
            return false;
        }

        public static int[,] frequencyDigit(int num)
        {
            int[] digit = StoreDigits(num);
            int sum = 0;

            // size of a integer is 10 so we are creating an array of size 10
            int[,] freq = new int[10, 2];

            for(int i = 0; i < 10; i++)
            {
                freq[i, 0] = i; // storing digit
                freq[i, 1] = 0; // initializing frequency to 0
            }

            for(int i = 0; i < digit.Length; i++)
            {
                freq[digit[i], 1]++; // incrementing frequency of the digit
            }
            return freq;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            int totalDigits = count(num);
            Console.WriteLine("Total digits in " + num + " is : " + totalDigits);

            // storing digits and displaying with index
            int[] digits = StoreDigits(num);

            for (int i = 0; i < digits.Length; i++)
            {
              
                Console.WriteLine(digits[i] + " " + " is at index " + i);
                
            }

            // sum of digits displaying
            int sum = SumOfDigits(num);
            Console.WriteLine("Sum of digits of " + num + " is : " + sum);

            // sum of square of digits displaying
            int sqrSum = SumOfSqrDigits(num);
            Console.WriteLine("Sum of square of digits of " + num + " is : " + sqrSum);

            // Harshad number checking
            Console.WriteLine(num + " is a Harshad number  : " + isHarshadNumber(num));

            // frequency of digits in a number displaying
            int[,] freq = frequencyDigit(num);
            Console.WriteLine("Digit Frequency : ");
            for(int i = 0; i < 10; i++)
            {
                if(freq[i, 1] != 0)
                {
                    Console.WriteLine("Digit " + freq[i, 0] + " has frequency " + freq[i, 1]);
                }
            }


        }




    }
}
