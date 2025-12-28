using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class TempretureConvertor
    {
        // formula to convert fahrenheit to celsius used in below method
        public static string FahrenheitToCelsius(double f)
        {
           
            double c = (f - 32) * 5 / 9;

            return $"The Tempreture in celsius : {c}";
        }

        // formula to convert celsius to fahrenheit used in below method
        public static string CelsiusToFahrenheit(double c)
        {
            double f = (c * 9 / 5) + 32;
            return $"The Tempreture in Fahrenheit : {f}";
        }

        static void Main(string[] args)
        {
            // giving choice to user to convert the tempretue according to his preferrences
            Console.WriteLine("press 1. to convert Celsius to Fahreheit");
            Console.WriteLine("press 2. to convert Fahreheit to Celsius");
            Console.WriteLine("press 3. to convert Celsius to Fahreheit and Fahrenheit to celsius ");

            Console.WriteLine("Enter the Number ");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Enter the Tempreture in celsius");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine(CelsiusToFahrenheit(c));

            }
            else if (num == 2)
            {
                Console.WriteLine("Enter the Tempreture in Fahrenheit");
                double f = double.Parse(Console.ReadLine());

                Console.WriteLine(FahrenheitToCelsius(f));
            }

            else if (num == 3) 
            {
                Console.WriteLine("Enter the Tempreture in celsius");
                double c = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter the Tempreture in Fahrenheit");
                double f = double.Parse(Console.ReadLine());

                Console.WriteLine(CelsiusToFahrenheit(c));
                Console.WriteLine(FahrenheitToCelsius(f));
            }

        }


    }
}
