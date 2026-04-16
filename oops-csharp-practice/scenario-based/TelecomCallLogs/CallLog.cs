using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.TelecomCallLogs
{
    internal class CallLog
    {
        public long phoneNumber;
        public string message;
        public DateTime timeStamp;

        public CallLog(long phoneNumber, string messsage , DateTime timeStamp)
        {
            this.phoneNumber = phoneNumber;
            this.message = messsage;
            this.timeStamp = timeStamp;
        }

        public void Display()
        {
            Console.WriteLine("the phone number is : " + phoneNumber);
            Console.WriteLine("the message is : "+message);
            Console.WriteLine("TimeStamp: " + timeStamp);
        }
    }
}
