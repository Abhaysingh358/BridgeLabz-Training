using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level03
{
    internal class FootballPlayer
    {
        // Method to calculate mean, min, and max height
        public static double[] CalculateHeight(double[] height)
        {
            double totalHt = 0;
            for (int i = 0; i < height.Length; i++)
            {
                totalHt += height[i];
            }

            double meanHt = totalHt / height.Length;

            double minht = height[0]; double maxht = 0;

            //checking minimum and maximum height
            for (int i = 0; i < height.Length; i++)
            {
                minht= Math.Min(minht, height[i]);
                maxht= Math.Max(maxht, height[i]);
            }

            return new double[] { meanHt, minht, maxht };
        }


        // Main method to test the CalculateHeight method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of football players:");
            int players = int.Parse(Console.ReadLine());

            double[] height = new double[players];
            // takinh input for heights
            for (int i = 0; i < players; i++)
            {
                Console.WriteLine($"Enter height of player {i + 1} in cm:");
                height[i] = double.Parse(Console.ReadLine());
            }
            double[] results = CalculateHeight(height); // Calling the method

            //displaying the results
            Console.WriteLine("Mean Height : " +  results[0] + " cm");
            Console.WriteLine("Minimum Height : " + results[1] + " cm");
            Console.WriteLine(" Maximum Height: " + results[2] + " cm");
            
        }
    }
}
