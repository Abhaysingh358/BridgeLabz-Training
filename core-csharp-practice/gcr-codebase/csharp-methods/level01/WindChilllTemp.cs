//.Write a program calculate the wind chill temperature given the temperature and wind speed
//Hint => 
//Write a method to calculate the wind chill temperature using the formula
//windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * windSpeed0.16
//public double CalculateWindChill(double temperature, double windSpeed)

// 25 Dec 2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class WindChilllTemp
    {
        public double CalculateWindChill(double temperature, double windSpeed)
        {
            // formula to claculate wind chill temperature
            // Math.Pow is used to calculate power of windSpeed to 0.16
            double windChill = 35.74 + (0.6215 * temperature) + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);

            return windChill;

        }

        static void Main(string[] args)
        {
            // Taking temperature and wind speed as input from user
            Console.WriteLine("Enter the temperature in Fahrenheit: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the wind speed in miles per hour: ");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            // Creating an object of WindChilllTemp class to call CalculateWindChill method
            WindChilllTemp windChillCalculator = new WindChilllTemp();
            double windChill = windChillCalculator.CalculateWindChill(temperature, windSpeed);

            Console.WriteLine("The wind chill temperature is : " +  windChill);
        }
    }
}
