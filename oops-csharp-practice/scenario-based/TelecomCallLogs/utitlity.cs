using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.TelecomCallLogs
{
    internal class utitlity
    {
        private CallLog[] logs;
        private int count;

        public utitlity()
        {
            logs = new CallLog[1];
            count = 0;
        }

        private void ResizeArray()
        {
            CallLog[] newArray = new CallLog[logs.Length * 2];

            for (int i = 0; i < logs.Length; i++)
            {
                newArray[i] = logs[i];
            }

            logs = newArray;
        }

        public void AddLog(long phoneNumber, string message, DateTime timeStamp)
        {
            if (count == logs.Length)
            {
                ResizeArray();
            }

            logs[count] = new CallLog(phoneNumber, message, timeStamp);
            count++;    
            Console.WriteLine("Added a call log");
        }

        public void Searchkeyword(string keyword)
        {
            bool found = false; 

            for (int i = 0; i < count; i++)
            {
                if (logs[i].message.Contains(keyword))
                {
                    logs[i].Display();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(" call log not found");
            }
        }

        public void FilterByTime(DateTime start, DateTime end)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (logs[i].timeStamp >= start && logs[i].timeStamp <= end)
                {
                    logs[i].Display();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("logs not  found in this  time range.");
            }
        }
    }
}
