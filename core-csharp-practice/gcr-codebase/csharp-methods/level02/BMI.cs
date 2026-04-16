using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{

    



internal class BmiTwoDimension
{
        //this method calculate and return the bmi
        public static double calculateBMI(double  weight , double height)
        {
            return weight / (height * height);
        }

        //this method catehorize and return the status 
        public static string Status(double bmi)
        {
            if (bmi <= 18.4)
            {
                return "UnderWeight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal";
            }
            else if (bmi >= 25.0 && bmi <= 39.9)
            {
                return "OverWeight";
            }
            else if (bmi >= 40.0)
            {
                return "Obese";
            }
            else
            {
                return "Invalid BMI";
            }
        }
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

            // calculating BMI using method
            persondata[i, 2] = calculateBMI(persondata[i, 0], persondata[i, 1]);
            // getting status using method
            wtStatus[i] = Status(persondata[i, 2]);

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
