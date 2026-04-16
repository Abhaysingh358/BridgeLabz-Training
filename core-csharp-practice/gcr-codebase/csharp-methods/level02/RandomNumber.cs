using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class RandomNumber
    {
        //this will generate 4 digit random number array
        public int[] Generate4DigitRandomArray(int size)
        {
          int[] num = new int[size];

            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                num[i] = r.Next(1000, 10000); //  this will generate 4 digit number 
            }
            return num;

        }

        //this will find average , min and max from the array
        public double[] FindAverageMinMax(int[] num)
        {
            int  sum = 0;
            int min = num[0];

            int max = num[0];

            


            for (int i = 0; i < num.Length; i++)
            {

                min = Math.Min(min, num[i]);
                max = Math.Max(max, num[i]);

                sum += num[i];

               
            }

            double average = (double)sum / num.Length;
            return new double[] { average, min, max };
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array ");
            int size = int.Parse(Console.ReadLine());

            // Create an instance of RandomNumber class
            RandomNumber rd = new RandomNumber();
            // string numbers in array by method calling
            int[] randomNum = rd.Generate4DigitRandomArray(size);

            // Display the generated random numbers
            for (int i=0; i< randomNum.Length; i++)
            {
                Console.WriteLine(randomNum[i]);
            }

            double[] avg = rd.FindAverageMinMax(randomNum);
            Console.WriteLine($"Average: {avg[0]}, Min: {avg[1]}, Max: {avg[2]}");





        }
    }
}
