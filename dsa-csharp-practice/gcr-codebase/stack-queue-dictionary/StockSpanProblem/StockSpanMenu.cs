using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StockSpanProblem
{
    internal class StockSpanMenu
    {
        public void Run()
        {
            StockSpanCalculator calculator = new StockSpanCalculator();

            Console.Write("Enter number of days: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] prices = new int[n];

            Console.WriteLine("Enter stock prices:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter stock prices " + (i+1));
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] span = calculator.CalculateSpan(prices);

            Console.WriteLine("\nStock Span:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(span[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

