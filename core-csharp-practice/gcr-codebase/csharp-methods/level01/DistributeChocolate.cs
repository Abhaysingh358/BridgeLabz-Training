using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level01
{
    internal class DistributeChocolate
    {
        public int[]  ChocolatesPerStudent(int chocolates, int children)
        {
            // Calculate chocolates per student
            // Calculate remaining chocolates
            // Return both values as an array
            int chocolatesperchild = chocolates / children;
            int remainingChocolates = chocolates % children;


            return new int[] { chocolatesperchild, remainingChocolates };
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number of chocolates: ");
            int chocolates = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of children: ");
            int children = int.Parse(Console.ReadLine());

            DistributeChocolate distributeChocolate = new DistributeChocolate();

            // storing both values in  result
            int[] result = distributeChocolate.ChocolatesPerStudent(chocolates, children);

            // Displaying the result
            Console.WriteLine("Chocolates per child: " + result[0]);
            Console.WriteLine("Remaining chocolates: " + result[1]);
        }
    }
}
