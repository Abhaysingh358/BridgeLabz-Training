using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TaskScheduler
{
    internal class TaskCircularLinkedList
    {
        private Task Head;
        private Task Current;

        public void AddAtBeginning(Task task)
        {
            if (Head == null)
            {
                Head = task;
                task.Next = task;
                Current = task;
                return;
            }

            Task temp = Head;
            while (temp.Next != Head)
                temp = temp.Next;

            task.Next = Head;
            temp.Next = task;
            Head = task;
        }

        public void AddAtEnd(Task task)
        {
            if (Head == null)
            {
                Head = task;
                task.Next = task;
                Current = task;
                return;
            }

            Task temp = Head;
            while (temp.Next != Head)
                temp = temp.Next;

            temp.Next = task;
            task.Next = Head;
        }

        public void AddAtPosition(Task task)
        {
            Console.WriteLine("Enter the Position");
            int position = int.Parse(Console.ReadLine());
            if (position <= 1)
            {
                AddAtBeginning(task);
                return;
            }

            Task temp = Head;
            for (int i = 1; i < position - 1 && temp.Next != Head; i++)
                temp = temp.Next;

            task.Next = temp.Next;
            temp.Next = task;
        }

        public void RemoveById(int id)
        {
            if (Head == null) return;

            Task curr = Head;
            Task prev = null;

            do
            {
                if (curr.TaskId == id)
                {
                    if (prev == null)
                    {
                        Task temp = Head;
                        while (temp.Next != Head)
                            temp = temp.Next;

                        if (temp == Head)
                        {
                            Head = null;
                            Current = null;
                            return;
                        }

                        temp.Next = Head.Next;
                        Head = Head.Next;
                        Current = Head;
                    }
                    else
                    {
                        prev.Next = curr.Next;
                    }
                    return;
                }

                prev = curr;
                curr = curr.Next;

            } while (curr != Head);
        }

        public Task GetNextTask()
        {
            if (Current == null) return null;

            Task task = Current;
            Current = Current.Next;
            return task;
        }

        public void DisplayAll(TaskUtility util)
        {
            if (Head == null) return;

            Task temp = Head;
            do
            {
                util.Print(temp);
                temp = temp.Next;
            } while (temp != Head);
        }

        public void SearchByPriority(int priority, TaskUtility util)
        {
            if (Head == null) return;

            Task temp = Head;
            bool found = false;

            do
            {
                if (temp.Priority == priority)
                {
                    util.Print(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != Head);

            if (!found)
                Console.WriteLine("No task found.");
        }
    }
}

