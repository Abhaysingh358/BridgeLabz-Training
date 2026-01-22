using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class BinaryNumberGeneratorApp
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Queue<string> q = new Queue<string>();
            q.Enqueue("1");

            Console.WriteLine("First " + n + " Binary Numbers:");

            for (int i = 0; i < n; i++)
            {
                string curr = q.Dequeue();
                Console.Write(curr + " ");

                q.Enqueue(curr + "0");
                q.Enqueue(curr + "1");
            }
        }
    }

}
