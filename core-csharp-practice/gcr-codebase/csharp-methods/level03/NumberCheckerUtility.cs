using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{

    internal class NumberCheckerUtility
    {
        // Method to count digits in a number
        public static int countDigit(int num)
        {
            int temp = num;
            int count = 0;
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }

            return count;
        }
        // Method to store digits in an array
        public static int[] Storedigits(int num)
        {
            int size = countDigit(num);
            int[] digits = new int[size];
            int idx = size -1;

            while (num != 0)
            {
                digits[idx] = num % 10;
                num /= 10;
                idx--;
            }

            return digits;
        }

        // Method to check Duck number
        public static bool IsDuckNumber(int num)
        {
            int[] digits = Storedigits(num);
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                {
                    return true; // Duck number found
                }
            }
            return false; // Not a duck number

        }
        // Method to check Armstrong number
        public static bool CheckArmStrongNumber(int num)
        {
            int[] digits = Storedigits(num);
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], digits.Length);
            }
            if (sum == num)
            {
                return true; // Armstrong number
            }
            else
            {
                return false; // Not an Armstrong number
            }
        }

        // Method to find largest and second largest digits
        public static int[] FindLargestAndSeconLargest(int num)
        {
            int[] digits = Storedigits(num);
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            for (int i = 0; i < digits.Length; i++)  
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }
            return new int[] { largest, secondLargest };
        }

        // Method to find smallest and second smallest digits
        public static int[] FindSmallestAndSecondSmallest(int num)
        {
            int[] digits = Storedigits(num);

            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;

            for (int i = 0; i < digits.Length; i++)   
            {
                if (digits[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits[i];
                }
                else if (digits[i] < secondSmallest && digits[i] != smallest)
                {
                    secondSmallest = digits[i];
                }
            }
            return new int[] { smallest, secondSmallest };
        }

        static void Main(string[] args)
        {
            NumberCheckerUtility numberChecker = new NumberCheckerUtility();
            Console.WriteLine("Enter a number to count its digits:");
            int num = int.Parse(Console.ReadLine());

            int totalDigits = countDigit(num);
            Console.WriteLine(num + " has " + totalDigits + " digits.");

            int[] digits = Storedigits(num);
            for (int i = 0; i < digits.Length; i++)
            {
                Console.WriteLine("At index  " + i + ": " + digits[i] + " is present");
            }

            bool isDuck = IsDuckNumber(num);
            Console.WriteLine(num + " is Duck Number : " + isDuck);

            bool isArmstrong = CheckArmStrongNumber(num);
            Console.WriteLine(num + " is Armstrong Number : " + isArmstrong);

            int[] largestAndSecondLargest = FindLargestAndSeconLargest(num);
            Console.WriteLine("Largest digit : " + largestAndSecondLargest[0]);
            Console.WriteLine("Second Largest digit : " + largestAndSecondLargest[1]);

            int[] smallestAndSecondSmallest = FindSmallestAndSecondSmallest(num);
            Console.WriteLine("Smallest digit : " + smallestAndSecondSmallest[0]);
            Console.WriteLine("Second Smallest digit : " + smallestAndSecondSmallest[1]);


        }
    }
}
