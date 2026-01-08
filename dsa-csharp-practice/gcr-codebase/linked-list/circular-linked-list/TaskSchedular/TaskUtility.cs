using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TaskScheduler
{
    internal class TaskUtility
    {
        public Task CreateTask()
        {
            Console.Write("Task ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Task Name: ");
            string name = Console.ReadLine();

            Console.Write("Priority: ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Due Date (yyyy-mm-dd): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            return new Task(id, name, priority, dueDate);
        }

        public void Print(Task task)
        {
            Console.WriteLine(
                $"ID:{task.TaskId}, Name:{task.TaskName}, Priority:{task.Priority}, Due:{task.DueDate:d}");
        }
    }
}

