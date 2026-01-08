using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.RoundRobinScheduling
{
    internal class Process
    {
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;

        public int WaitingTime;
        public int TurnAroundTime;

        public Process Next;

        public Process(int pid, int burstTime, int priority)
        {
            ProcessId = pid;
            BurstTime = burstTime;
            RemainingTime = burstTime;
            Priority = priority;
            WaitingTime = 0;
            TurnAroundTime = 0;
            Next = null;
        }
    }
}
