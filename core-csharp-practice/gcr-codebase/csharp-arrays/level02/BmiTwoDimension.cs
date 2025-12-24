using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class BmiTwoDimension
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of persons");
            int num = int.Parse(Console.ReadLine());
            double[,] persondata = new double[num, 3];
            String[] wtStatus = new string[num];


            // taking input and calculating bmi and store in array
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the  weight  and height of the person " + (i + 1));
                Console.WriteLine("Enter the Weight in kgs");
                persondata[i, 0] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Height in meters");
                persondata[i, 1] = double.Parse(Console.ReadLine());
                persondata[i, 2] = persondata[i, 0] / (persondata[i, 1] * persondata[i, 1]);
            }

            for (int i = 0; i < num; i++)
            {
                if (persondata[i, 2] <= 18.4)
                {
                    wtStatus[i] = "UnderWeight";
                }
                else if (persondata[i, 2] >= 18.5 && persondata[i, 2] <= 24.9)
                {
                    wtStatus[i] = "Normal";
                }
                else if (persondata[i, 2] >= 25.0 && persondata[i, 2] <= 39.9)
                {
                    wtStatus[i] = "OverWeight";
                }
                else if (persondata[i, 2] >= 40.0)
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
                Console.WriteLine("The height : " + persondata[i, 1]);
                Console.WriteLine("The weight : " + persondata[i, 0]);
                Console.WriteLine("The BMI : " + persondata[i, 2]);
                Console.WriteLine("The wtStatus : " + wtStatus[i]);

            }
        }
    }
}
