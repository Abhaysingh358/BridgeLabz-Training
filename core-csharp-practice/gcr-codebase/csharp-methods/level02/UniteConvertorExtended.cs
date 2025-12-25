using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class UniteConvertorExtended
    {
        // Convert yards to feet
        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        // Convert feet to yards
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        // Convert meters to inches
        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        // Convert inches to meters
        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        // Convert inches to centimeters
        public static double ConvertInchesToCentimeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unit Conversion");

            Console.WriteLine("Enter yards to convert to feet:");
            double yards = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter feet to convert to yards:");
            double feet = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter meters to convert to inches:");
            double meters = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter inches to convert to meters:");
            double inches = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter inches to convert to centimeters:");
            double inches2CM = double.Parse(Console.ReadLine());

            Console.WriteLine(yards + " yards in feet : " + ConvertYardsToFeet(yards));
            Console.WriteLine(feet + " feet in yards : " + ConvertFeetToYards(feet));
            Console.WriteLine(meters + " meters in inches : " + ConvertMetersToInches(meters));
            Console.WriteLine(inches + " inches in meters : " + ConvertInchesToMeters(inches));
            Console.WriteLine(inches2CM + " inches in centimeters : " + ConvertInchesToCentimeters(inches2CM));
        }
    }
}
