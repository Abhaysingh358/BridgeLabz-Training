using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TicketReservation
{
    internal class Menu
    {
        private TicketCircularLinkedList list = new TicketCircularLinkedList();
        private TicketUtility util = new TicketUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine(
                    "\n1.AddTicket 2.RemoveTicket 3.Display 4.SearchCustomer\n" +
                    " 5.SearchMovie 6.Count 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddTicket(util.CreateTicket());
                        break;

                    case 2:
                        Console.Write("Ticket ID: ");
                        list.RemoveByTicketId(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        list.DisplayAll(util);
                        break;

                    case 4:
                        Console.Write("Customer Name: ");
                        list.SearchByCustomer(Console.ReadLine(), util);
                        break;

                    case 5:
                        Console.Write("Movie Name: ");
                        list.SearchByMovie(Console.ReadLine(), util);
                        break;

                    case 6:
                        Console.WriteLine("Total Tickets: " + list.CountTickets());
                        break;
                }

            } while (choice != 0);
        }
    }
}
