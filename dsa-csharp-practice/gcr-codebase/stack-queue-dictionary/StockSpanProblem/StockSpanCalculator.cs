using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackImpl;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StockSpanProblem
{
    internal class StockSpanCalculator
    {
        public int[] CalculateSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];

            Stack stack = new Stack(); // stores indices

            for (int i = 0; i < n; i++)
            {
                // Pop while current price is greater or equal
                while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                span[i] = stack.IsEmpty() ? (i + 1) : (i - stack.Peek());

                stack.Push(i);
            }

            return span;
        }
    }
}

