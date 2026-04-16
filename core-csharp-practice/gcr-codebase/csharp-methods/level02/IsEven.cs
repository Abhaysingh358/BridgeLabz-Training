using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class IsEven
    {

        // Method to check if a number is positive
        public static bool CheckNum(int num)
        {
            if (num >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to check if a number is even
        public static bool isEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        // Method to compare two numbers

        public static int  Compare(int num1, int num2)
        {
            if(num1 > num2)
            {
                return 1;
            }
            else if(num1 == num2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }


        static void Main(string[] args)
        {
            

            int[] arr = new int[5];

            for(int i =0; i< arr.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + " :");

                arr[i] = int.Parse(Console.ReadLine());
            }


            // checking each number
            for(int i =0; i< arr.Length; i++)
            {
          
                bool isPositive = CheckNum(arr[i]);

                if(isPositive)
                {
                    // check if the number is even or not
                    if (isEven(arr[i]))
                    {
                        Console.WriteLine(arr[i] + " is Even and positive ");
                    }
                    else
                    {
                        Console.WriteLine(arr[i] + " is Odd and positive ");
                    }
                }
                else
                {
                    Console.WriteLine(arr[i] +  " is Negative ");
                }
            }

            int comp = Compare(arr[0], arr[arr.Length-1]);
            if(comp == 1)
            {
                Console.WriteLine("First number is greater than the last one ");
              }

            else if(comp == 0)
            {
                Console.WriteLine("Both numbers are equal ");
            }
            else
            {
                 Console.WriteLine("Last number is greater than the first one ");
            }
        }
    }
}
