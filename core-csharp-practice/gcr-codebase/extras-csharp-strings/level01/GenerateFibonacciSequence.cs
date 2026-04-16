using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.extras_csharp_strings.level01
{
    internal class GenerateFibonacciSequence
    {
        public static void GenerateFibonacciSeries(int num)
        {
            int a = 0, b = 1, c; // c is the next term of series

            if (num <= 0)
            {
                Console.WriteLine("Please enter a positive integer greater than 0.");
                return;
            }

            if (num == 1)
            {
                Console.WriteLine("Fibonacci Series up to " + num + " term:");
                Console.WriteLine(a);
                return;
            }


            while (num-- > 0) // num-- decrements num after checking the condition
            {
                Console.Write(a + " ");
                // calculate the next term
                c = a + b;
                // update values of a and b
                a = b;
                b = c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms for Fibonacci Series:");
            int num = int.Parse(Console.ReadLine());

            // calling the method to generate Fibonacci series
            GenerateFibonacciSeries(num);
        }

    }
}
