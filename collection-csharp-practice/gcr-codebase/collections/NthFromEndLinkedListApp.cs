using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class NthFromEndLinkedListApp
    {
        static void Main()
        {
            Console.Write("Enter number of nodes: ");
            int n = int.Parse(Console.ReadLine());

            LinkedList<string> list = new LinkedList<string>();
            Console.WriteLine("Enter values:");
            for (int i = 0; i < n; i++)
                list.AddLast(Console.ReadLine());

            Console.Write("Enter N: ");
            int k = int.Parse(Console.ReadLine());

            var fast = list.First;
            var slow = list.First;

            for (int i = 0; i < k; i++)
            {
                if (fast == null)
                {
                    Console.WriteLine("Invalid N");
                    return;
                }
                fast = fast.Next;
            }

            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            Console.WriteLine("Nth from end: " + slow.Value);
        }
    }

}
