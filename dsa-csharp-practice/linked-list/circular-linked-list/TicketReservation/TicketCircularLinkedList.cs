using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TicketReservation
{
    internal class TicketCircularLinkedList
    {
        private Ticket Head;

        // Add ticket at end
        public void AddTicket(Ticket ticket)
        {
            if (Head == null)
            {
                Head = ticket;
                ticket.Next = ticket;
                return;
            }

            Ticket temp = Head;
            while (temp.Next != Head)
                temp = temp.Next;

            temp.Next = ticket;
            ticket.Next = Head;
        }

        // Remove by Ticket ID
        public void RemoveByTicketId(int ticketId)
        {
            if (Head == null) return;

            Ticket curr = Head;
            Ticket prev = null;

            do
            {
                if (curr.TicketId == ticketId)
                {
                    if (prev == null) // removing head
                    {
                        Ticket temp = Head;
                        while (temp.Next != Head)
                            temp = temp.Next;

                        if (temp == Head)
                        {
                            Head = null;
                            return;
                        }

                        temp.Next = Head.Next;
                        Head = Head.Next;
                    }
                    else
                    {
                        prev.Next = curr.Next;
                    }
                    return;
                }

                prev = curr;
                curr = curr.Next;

            } while (curr != Head);
        }

        // Display all tickets
        public void DisplayAll(TicketUtility util)
        {
            if (Head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Ticket temp = Head;
            do
            {
                util.Print(temp);
                temp = temp.Next;
            } while (temp != Head);
        }

        // Search by customer name
        public void SearchByCustomer(string customerName, TicketUtility util)
        {
            if (Head == null) return;

            Ticket temp = Head;
            bool found = false;

            do
            {
                if (temp.CustomerName.Equals(customerName))
                {
                    util.Print(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != Head);

            if (!found)
                Console.WriteLine("No ticket found for customer.");
        }

        // Search by movie name
        public void SearchByMovie(string movieName, TicketUtility util)
        {
            if (Head == null) return;

            Ticket temp = Head;
            bool found = false;

            do
            {
                if (temp.MovieName.Equals(movieName))
                {
                    util.Print(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != Head);

            if (!found)
                Console.WriteLine("No ticket found for movie.");
        }

        // Count total tickets
        public int CountTickets()
        {
            if (Head == null) return 0;

            int count = 0;
            Ticket temp = Head;

            do
            {
                count++;
                temp = temp.Next;
            } while (temp != Head);

            return count;
        }
    }
}
