using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class Collinearity
    {
        // Method to check collinearity using slope formula
        public static bool AreCollinearSlope(double x1, double y1,
                                             double x2, double y2,
                                             double x3, double y3)
        {
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);

            return (slopeAB == slopeBC) && (slopeBC == slopeAC);
        }

        // Method to check collinearity using area of triangle
        public static bool AreCollinearArea(double x1, double y1,
                                            double x2, double y2,
                                            double x3, double y3)
        {
            double area = 0.5 * (
                x1 * (y2 - y3) +
                x2 * (y3 - y1) +
                x3 * (y1 - y2)
            );

            return area == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x3:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y3:");
            double y3 = double.Parse(Console.ReadLine());

            bool slopeResult = AreCollinearSlope(x1, y1, x2, y2, x3, y3);
            bool areaResult = AreCollinearArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine("\nCollinear (Slope Method): " + slopeResult);
            Console.WriteLine("Collinear (Area Method): " + areaResult);
        }
    }
}
