using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.QueueTwoStack
{
    internal class QueueTwoStackMenu
    {
        public void Run()
        {
            QueueUsingTwoStacks queue = new QueueUsingTwoStacks(); 
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Queue Using Two Stacks ---");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        queue.Enqueue(value);
                        Console.WriteLine("Enqueued successfully");
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Dequeued: " + queue.Dequeue());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Queue elements:");
                        queue.Display();
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


