using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level01
{
    internal class MeanOfHeights
    {
        static void Main(string[] args)
        {
            double[] height = new double[11];
            double sum = 0;

            for (int i = 0; i < height.Length; i++)
            {
                Console.WriteLine("enter the height of " + (i + 1) + "th player");
                height[i] = double.Parse(Console.ReadLine());
            }

// loop for calculating  total value
            for (int i = 0; i < height.Length; i++)
            {
                sum += height[i];
            }

            // using Mean formula
            double mean = sum / height.Length;

            Console.WriteLine(" Mean height of the football team is : " + mean);
        }
    }
}
