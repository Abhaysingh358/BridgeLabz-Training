using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.RoundRobinScheduling
{
    internal class ProcessUtility
    {
        public Process CreateProcess()
        {
            Console.Write("Process ID: ");
            int pid = int.Parse(Console.ReadLine());

            Console.Write("Burst Time: ");
            int bt = int.Parse(Console.ReadLine());

            Console.Write("Priority: ");
            int priority = int.Parse(Console.ReadLine());

            return new Process(pid, bt, priority);
        }

        public void Print(Process p)
        {
            Console.WriteLine(
                $"PID:{p.ProcessId}, BT:{p.BurstTime}, RT:{p.RemainingTime}," +
                $" WT:{p.WaitingTime}, TAT:{p.TurnAroundTime}");
        }
    }
}
