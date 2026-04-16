using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackImpl;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.StackSortRecursion
{
    internal class StackSortMenu
    {
        public void Run()
        {
            Stack stack = new Stack();
            StackSorter sorter = new StackSorter(stack);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Sort Stack Using Recursion ---");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Sort Stack");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        stack.Push(value);
                        Console.WriteLine("Pushed");
                        break;

                    case 2:
                        sorter.SortStack();
                        Console.WriteLine("Stack sorted successfully");
                        break;

                    case 3:
                        Console.WriteLine("Stack elements:");
                        stack.Display();
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
