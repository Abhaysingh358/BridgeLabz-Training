using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class TotalRounds
    {
        // Method to calculate number of rounds
        public double CalculateRounds(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;   // Total distance for 1 round
            double totalDistance = 5000;                // 5 km = 5000 meters
            double rounds = totalDistance / perimeter;  // Rounds needed
            return rounds;
        }

        // Main method to test the CalculateRounds method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle (in meters):");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Create an instance of TotalRounds and calculate rounds
            TotalRounds totalRounds = new TotalRounds();

            // Calculate and display the number of rounds needed to cover 5 km
            double rounds = totalRounds.CalculateRounds(side1, side2, side3);

            // Display the result
            Console.WriteLine($"Number of rounds needed to cover 5 km: {rounds}");
            
        }
    }
}
