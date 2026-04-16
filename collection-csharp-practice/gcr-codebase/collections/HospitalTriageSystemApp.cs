using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class HospitalTriageSystemApp
    {
        static void Main()
        {
            Console.Write("Enter number of patients: ");
            int n = int.Parse(Console.ReadLine());

            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter patient name: ");
                string name = Console.ReadLine();

                Console.Write("Enter severity (higher = more serious): ");
                int severity = int.Parse(Console.ReadLine());

                pq.Enqueue(name, -severity); // higher severity treated first
            }

            Console.WriteLine("\nTreatment Order:");
            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }
        }
    }

}
