using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class YoungestAndTallest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n first you have to provide the Amar's , Akbar's ,and Anmthony's ages and heights : ");
            double[] height = new double[3];
            double[] age = new double[3];
            String[] names = { "Amar", "Akbar", "Anthony" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the height and age of  " + names[i]);
                double ht = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Age");
                double ageVal = double.Parse(Console.ReadLine());

                if(ht <=0 || ageVal <=0)
                {
                    Console.WriteLine("please enter the valid height and age");
                    i--;
                    continue;
                }

                height[i] = ht;
                age[i] = ageVal;

            }
            // making index of tallest and youngest
            int youngestIdx = 0;
            int tallestIdx = 0;

            // calculating tallest and youngest
            for (int i = 0; i < 3; i++)
            {
                if (age[i] < age[youngestIdx])
                {
                    youngestIdx = i;
                }

                if(height[i] < height[tallestIdx])
                {
                    tallestIdx = i;
                }


            }

            // displaying the result

            Console.WriteLine(names[youngestIdx] + " is youngest in three of them");
            Console.WriteLine(names[tallestIdx] + " is the tallest in three of them");

        }
    }
}
