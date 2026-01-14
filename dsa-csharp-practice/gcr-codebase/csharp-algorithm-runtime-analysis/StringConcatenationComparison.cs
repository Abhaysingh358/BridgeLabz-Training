using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.csharp_algorithm_runtime_analysis
{
    internal class StringConcatenationComparison
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };

            foreach (int size in sizes)
            {
                Console.WriteLine("\nOperations Count: " + size);

                // string concatenation
                if (size <= 10000)
                {
                    Stopwatch swString = Stopwatch.StartNew();
                    ConcatUsingString(size);
                    swString.Stop();
                    Console.WriteLine("string Time: " + swString.ElapsedTicks + " ticks");
                }
                else
                {
                    Console.WriteLine("string Time: Unusable (O(N^2))");
                }

                // StringBuilder concatenation
                Stopwatch swBuilder = Stopwatch.StartNew();
                ConcatUsingStringBuilder(size);
                swBuilder.Stop();
                Console.WriteLine("StringBuilder Time: " + swBuilder.ElapsedTicks + " ticks");
            }
        }

        // O(N^2)
        static void ConcatUsingString(int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += "a";
            }
        }

        // O(N)
        static void ConcatUsingStringBuilder(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append("a");
            }
        }
    }
}

