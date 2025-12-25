using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class EuclideanLine
    {
        // Method to compute Euclidean distance
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        // Method to compute slope and y-intercept

        public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);  // slope
            
            double b = y1 - m * x1;              // y-intercept

            return new double[] { m, b };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine("\nEuclidean Distance: " + distance);


            double[] line = CalculateLineEquation(x1, y1, x2, y2);

            Console.WriteLine("Slope (m): " + line[0]);
            Console.WriteLine("Y-Intercept (b): " + line[1]);

            Console.WriteLine("\nEquation of Line: y = " + line[0] + "x + " + line[1]);
        }
    }
}
