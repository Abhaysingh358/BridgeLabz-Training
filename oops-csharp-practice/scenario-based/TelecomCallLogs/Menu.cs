using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.TelecomCallLogs
{
    internal class Menu
    {

        public void Entry()
        {
            utitlity u  =new utitlity();

            while (true)
            {
                Console.WriteLine("Call Logs Manager");
                Console.WriteLine("1. Add Call Log");
                Console.WriteLine("2. Search by Keyword");
                Console.WriteLine("3. Filter by Time Range");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("number:");
                        long number = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("message");
                        string message = Console.ReadLine();

                        Console.WriteLine("time stamp");
                        DateTime timestamp = DateTime.Parse(Console.ReadLine());

                        u.AddLog(number, message, timestamp);
                        break;
                    case 2:
                        Console.WriteLine("enter a keyword to search");
                        string key = Console.ReadLine();
                        u.Searchkeyword(key);
                        break;
                    case 3:
                        DateTime start = DateTime.Parse(Console.ReadLine());
                        DateTime end = DateTime.Parse(Console.ReadLine());

                        u.FilterByTime(start, end);
                        break;
                    case 4:
                        break;

                }
                if(choice == 4)
                {
                    break;
                }

            }
        }
    }
}
