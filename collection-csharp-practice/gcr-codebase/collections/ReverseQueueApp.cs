using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class ReverseQueueApp
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Queue<int> q = new Queue<int>();
            Stack<int> st = new Stack<int>();

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                q.Enqueue(int.Parse(Console.ReadLine()));

            while (q.Count > 0) st.Push(q.Dequeue());
            while (st.Count > 0) q.Enqueue(st.Pop());

            Console.WriteLine("Reversed Queue:");
            Console.WriteLine(string.Join(" ", q));
        }
    }

}
