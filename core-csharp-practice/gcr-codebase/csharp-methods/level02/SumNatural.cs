using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class SumNatural
    {
        // Function to calculate sum of first n natural numbers using recursion
        public int RecursiveSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + RecursiveSum(n - 1);
        }

        // Function to calculate sum of first n natural numbers using formula
        public int FormulaSum(int n)
        {
            return (n * (n + 1)) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enetr the Number ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("natural numbers are started from 1 ");
            }

            // Create an instance of SumNatural
            SumNatural sum = new SumNatural();

            
            int recursiveResult = sum.RecursiveSum(num);
            Console.WriteLine("Sum of first " + num + " natural numbers using recursion: " + recursiveResult);
            int formulaResult = sum.FormulaSum(num);
            Console.WriteLine("Sum of first " + num + " natural numbers using formula: " + formulaResult);


            // Compare results
            if (recursiveResult == formulaResult)
            {
                Console.WriteLine("Both methods give the same result.");
            }
            else
            {
                Console.WriteLine("Results differ between methods.");
            }
        }
    }
}
