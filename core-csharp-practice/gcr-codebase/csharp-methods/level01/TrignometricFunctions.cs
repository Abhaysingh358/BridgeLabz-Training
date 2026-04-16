using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class TrignometricFunctions
    {
        public double[] calculateTrigonometricFunctions(double angle)
        {
            double radians = angle * (Math.PI / 180); // this will convert the angle into radians

            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);

            return new double[] { sin, cos, tan };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the angle(degrees) : ");
            double angle = double.Parse(Console.ReadLine());

            TrignometricFunctions fun = new TrignometricFunctions(); // create an object of TrignometricFunctions class

            // store the sin , cos , and tan values in results array
            double[] results = fun.calculateTrigonometricFunctions(angle);

            Console.WriteLine("Sin : " + results[0]);
            Console.WriteLine("Cos : " + results[1]);
            Console.WriteLine("Tan  : " + results[2]); ;
        }
    }
}
