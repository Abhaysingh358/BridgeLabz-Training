using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class UnitConvertor
    {
        // Convert kilometers to miles
        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }

        // Convert miles to kilometers
        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }

        // Convert meters to feet
        public static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters * meters2feet;
        }

        // Convert feet to meters
        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }

        // Main method for testing 
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Conversion");
            Console.WriteLine("Enetr the Kms to convert ");
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine("Enetr the miles to convert in km ");
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enetr the meters to convert in feet ");
            double meters = double.Parse(Console.ReadLine());

            Console.WriteLine("Enetr the feet to convert in meters ");
            double feet = double.Parse(Console.ReadLine());

            double km2mile = ConvertKmToMiles(km);
            Console.WriteLine(km + " in miles : " + km2mile);

            double mile2km = ConvertMilesToKm(miles);
            Console.WriteLine(miles + " in kilometers : " + mile2km);

            double meters2feet = ConvertMetersToFeet(meters);
            Console.WriteLine(meters + " in feet : " + meters2feet);

            double feet2meters = ConvertFeetToMeters(feet);
            Console.WriteLine(feet + " in feet : " + feet2meters);


        }
    }
}
