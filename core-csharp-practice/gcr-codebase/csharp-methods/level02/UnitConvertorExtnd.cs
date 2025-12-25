using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class UnitConvertorExtnd
    {
        //  Fahrenheit to  Celsius
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
            return fahrenheit2celsius;
        }

        // Celsius to Fahrenheit
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double celsius2fahrenheit = (celsius * 9 / 5) + 32;
            return celsius2fahrenheit;
        }

        // Pounds to Kilograms
        public static double ConvertPoundsToKilograms(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }

        // Kilograms to  Pounds
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            double kilograms2pounds = 2.20462;
            return kilograms * kilograms2pounds;
        }

        // Gallons to  Liters
        public static double ConvertGallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }

        // Liters to Gallons
        public static double ConvertLitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }

        // Main method for testing
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Conversion");

            Console.WriteLine("Enter Fahrenheit to convert to Celsius:");
            double f = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Celsius to convert to Fahrenheit:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter pounds to convert to kilograms:");
            double pounds = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter kilograms to convert to pounds:");
            double kg = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter gallons to convert to liters:");
            double gallons = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter liters to convert to gallons:");
            double liters = double.Parse(Console.ReadLine());

            Console.WriteLine(f + "fahrenheit in Celsius : " + ConvertFahrenheitToCelsius(f));
            Console.WriteLine(c + "celcius in Fahrenheit : " + ConvertCelsiusToFahrenheit(c));
            Console.WriteLine(pounds + " pounds in kilograms : " + ConvertPoundsToKilograms(pounds));
            Console.WriteLine(kg + " kilograms in pounds : " + ConvertKilogramsToPounds(kg));
            Console.WriteLine(gallons + " gallons in liters : " + ConvertGallonsToLiters(gallons));
            Console.WriteLine(liters + " liters in gallons : " + ConvertLitersToGallons(liters));
        }
    }
}

