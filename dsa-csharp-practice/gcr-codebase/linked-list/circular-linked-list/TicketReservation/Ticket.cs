using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TicketReservation
{
    internal class Ticket
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public int SeatNumber;
        public DateTime BookingTime;

        public Ticket Next;

        public Ticket(int ticketId, string customerName, string movieName, int seatNumber, DateTime bookingTime)
        {
            TicketId = ticketId;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
            Next = null;
        }
    }
}
