using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class BMI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            int num = int.Parse(Console.ReadLine());

            double[] weight = new double[num];
            double[] height = new double[num];
            double[] bmi = new double[num];
            String[] wtStatus = new String[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the height and weight of person " + (i + 1));
                Console.WriteLine("Enter the height in meters");
                height[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the weight in Kgs");
                weight[i] = double.Parse(Console.ReadLine());

            }

            // in this below loop we calculation every person's bmi and adding the status accroding to bmi
            for(int i = 0; i<num; i++)
            {
                bmi[i] = weight[i] / (height[i] * height[i]);

                if (bmi[i] <= 18.4)
                {
                    wtStatus[i] = "UnderWeight";
                }
                else if (bmi[i] >= 18.5  && bmi[i] <= 24.9)
                {
                    wtStatus[i] = "Normal";
                }
                else if (bmi[i] >= 25.0 && bmi[i] <= 39.9)
                {
                    wtStatus[i] = "OverWeight";
                }
                else if (bmi[i] >= 40.0)
                {
                    wtStatus[i] = "Obese";
                }
                else
                {
                    wtStatus[i] = "you just enters invalid heigth or weight of this person";
                }
            }

            //priting the details of persons 
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nThe height and weight of person " + (i + 1));
                Console.WriteLine("The height : " + height[i]);
                Console.WriteLine("The weight : " + weight[i]);
                Console.WriteLine("The BMI : " + bmi[i]);
                Console.WriteLine("The wtStatus : " + wtStatus[i]);

            }

        }
    }
   }
