using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TaskScheduler
{
    internal class Task
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public Task Next;

        public Task(int id, string name, int priority, DateTime dueDate)
        {
            TaskId = id;
            TaskName = name;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }
}
