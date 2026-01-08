using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.RoundRobinScheduling
{
    internal class RoundRobinLinkedList
    {
        private Process Head;

        public void AddProcess(Process process)
        {
            if (Head == null)
            {
                Head = process;
                process.Next = process;
                return;
            }

            Process temp = Head;
            while (temp.Next != Head)
                temp = temp.Next;

            temp.Next = process;
            process.Next = Head;
        }

        public void RemoveProcess(Process process)
        {
            if (Head == null) return;

            if (Head == process && Head.Next == Head)
            {
                Head = null;
                return;
            }

            Process temp = Head;
            while (temp.Next != process)
                temp = temp.Next;

            if (process == Head)
                Head = Head.Next;

            temp.Next = process.Next;
        }

        public void Display(ProcessUtility util)
        {
            if (Head == null)
            {
                Console.WriteLine("Queue Empty");
                return;
            }

            Process temp = Head;
            do
            {
                util.Print(temp);
                temp = temp.Next;
            } while (temp != Head);
        }

        public void Simulate(int timeQuantum, ProcessUtility util)
        {
            if (Head == null) return;

            int time = 0;
            int totalProcesses = Count();
            int completed = 0;

            Process curr = Head;

            while (completed < totalProcesses)
            {
                if (curr.RemainingTime > 0)
                {
                    int execTime = Math.Min(timeQuantum, curr.RemainingTime);
                    curr.RemainingTime -= execTime;
                    time += execTime;

                    Process temp = Head;
                    do
                    {
                        if (temp != curr && temp.RemainingTime > 0)
                            temp.WaitingTime += execTime;

                        temp = temp.Next;
                    } while (temp != Head);

                    Console.WriteLine($"\nAfter executing Process {curr.ProcessId}");
                    Display(util);

                    if (curr.RemainingTime == 0)
                    {
                        curr.TurnAroundTime = time;
                        completed++;
                    }
                }
                curr = curr.Next;
            }
        }

        public void CalculateAverageTimes()
        {
            if (Head == null) return;

            double totalWT = 0, totalTAT = 0;
            int count = 0;

            Process temp = Head;
            do
            {
                totalWT += temp.WaitingTime;
                totalTAT += temp.TurnAroundTime;
                count++;
                temp = temp.Next;
            } while (temp != Head);

            Console.WriteLine("\nAverage Waiting Time: " + totalWT / count);
            Console.WriteLine("Average Turnaround Time: " + totalTAT / count);
        }

        private int Count()
        {
            if (Head == null) return 0;

            int count = 0;
            Process temp = Head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != Head);

            return count;
        }
    }
}
