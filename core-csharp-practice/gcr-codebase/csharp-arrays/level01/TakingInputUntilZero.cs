using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level01
{
    internal class TakingInputUntilZero
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];
            double sum = 0.0;
            int idx = 0;
            Console.WriteLine("Enetr the input up to 10 if user enetrs zero or negative value it will not be taken any more");
            // used to take infinite input but we set the range 10
            while (true)
            {
                if (idx == arr.Length)
                {
                    Console.WriteLine("input  can be taken up  size 10 ");
                }

                Console.WriteLine("enter the " + (idx + 1) + " :");
                double num = double.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    break;
                }

                arr[idx] = num; // assigned the number to array
                idx++;


            }

            // displaying the result
            Console.Write("Numbers entred : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Number {0}: {1}", i + 1, arr[i]);
                sum += arr[i];

            }

            Console.WriteLine("the total sum is : " + sum);

        }
    }
}
