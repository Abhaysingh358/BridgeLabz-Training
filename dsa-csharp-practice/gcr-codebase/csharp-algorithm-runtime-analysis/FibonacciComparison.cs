using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_Algorithm_Runtime_Analysis
{
    internal class FibonacciComparison
    {
        static void Main()
        {
            long[] testValues = { 10, 30, 50 };

            foreach (long n in testValues)
            {
                Console.WriteLine("\nFibonacci N: " + n);

                // Recursive Fibonacci (skip for large N)
                if (n <= 30)
                {
                    Stopwatch swRecursive = Stopwatch.StartNew();
                    long recResult = FibonacciRecursive(n);
                    swRecursive.Stop();
                    Console.WriteLine("Recursive Result: " + recResult);
                    Console.WriteLine("Recursive Time: " + swRecursive.ElapsedTicks + " ticks");
                }
                else
                {
                    Console.WriteLine("Recursive Time: Unfeasible (O(2^N))");
                }

                // Iterative Fibonacci
                Stopwatch swIterative = Stopwatch.StartNew();
                long itrResult = FibonacciIterative(n);
                swIterative.Stop();
                Console.WriteLine("Iterative Result: " + itrResult);
                Console.WriteLine("Iterative Time: " + swIterative.ElapsedTicks + " ticks");
            }
        }

        // O(2^N)
        static long FibonacciRecursive(long n)
        {
            if (n <= 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        // O(N)
        static long FibonacciIterative(long n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
