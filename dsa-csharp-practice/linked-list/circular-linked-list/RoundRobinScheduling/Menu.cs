using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.RoundRobinScheduling
{
    internal class Menu
    {
        private RoundRobinLinkedList list = new RoundRobinLinkedList();
        private ProcessUtility util = new ProcessUtility();

        public void Start()
        {
            Console.Write("Enter Time Quantum: ");
            int tq = int.Parse(Console.ReadLine());

            int choice;
            do
            {
                Console.WriteLine("\n1.AddProcess 2.Display 3.Simulate 4.Averages 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddProcess(util.CreateProcess());
                        break;

                    case 2:
                        list.Display(util);
                        break;

                    case 3:
                        list.Simulate(tq, util);
                        break;

                    case 4:
                        list.CalculateAverageTimes();
                        break;
                }

            } while (choice != 0);
        }
    }
}
