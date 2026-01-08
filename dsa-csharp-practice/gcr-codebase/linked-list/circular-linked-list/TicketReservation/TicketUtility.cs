using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TicketReservation
{
    internal class TicketUtility
    {
        public Ticket CreateTicket()
        {
            Console.Write("Ticket ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Customer Name: ");
            string customer = Console.ReadLine();

            Console.Write("Movie Name: ");
            string movie = Console.ReadLine();

            Console.Write("Seat Number: ");
            int seat = int.Parse(Console.ReadLine());

            DateTime time = DateTime.Now;

            return new Ticket(id, customer, movie, seat, time);
        }

        public void Print(Ticket ticket)
        {
            Console.WriteLine(
                $"ID:{ticket.TicketId}, Customer:{ticket.CustomerName}, Movie:{ticket.MovieName}, Seat:{ticket.SeatNumber}, Time:{ticket.BookingTime}");
        }
    }
}
