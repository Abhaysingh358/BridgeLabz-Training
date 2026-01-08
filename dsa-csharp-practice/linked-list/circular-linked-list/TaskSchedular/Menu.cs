using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TaskScheduler
{
    internal class Menu
    {
        private TaskCircularLinkedList list = new TaskCircularLinkedList();
        private TaskUtility util = new TaskUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1.AddBegin 2.AddEnd 3.AddPos 4.Remove 5.NextTask 6.Display 7.SearchPriority 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddAtBeginning(util.CreateTask());
                        break;

                    case 2:
                        list.AddAtEnd(util.CreateTask());
                        break;

                    case 3:
                        Console.Write("Position: ");
                        list.AddAtPosition(util.CreateTask());
                        break;

                    case 4:
                        Console.Write("Task ID: ");
                        list.RemoveById(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Task t = list.GetNextTask();
                        if (t != null) util.Print(t);
                        break;

                    case 6:
                        list.DisplayAll(util);
                        break;

                    case 7:
                        Console.Write("Priority: ");
                        list.SearchByPriority(int.Parse(Console.ReadLine()), util);
                        break;
                }

            } while (choice != 0);
        }
    }
}

