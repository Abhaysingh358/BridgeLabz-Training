using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class Roots
    {
        public static double[] CalCulatingRoots(double a , double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);

            //if delta is positive 
            if(delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }

            else if(delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[] {  };
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of b ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of c ");
            double c = double.Parse(Console.ReadLine());

            double[] roots = CalCulatingRoots(a, b, c);
            // displaying result according to the condition
            if(roots.Length == 2)
            {
                Console.WriteLine("Roote 1 : " + roots[0]);
                Console.WriteLine("Roote 2 : " + roots[1]);
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("there is only one roots : " + roots[0]);
            }
            else
            {
                Console.WriteLine("no real  roots exists");
            }

        }
    }
}
