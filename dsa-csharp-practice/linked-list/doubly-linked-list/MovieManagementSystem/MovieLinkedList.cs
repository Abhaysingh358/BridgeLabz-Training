using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.MovieManagementSystem
{
    internal class MovieLinkedList
    {
        private Movie Head;
        private Movie Tail;

        // Add at beginning
        public void AddAtBeginning(Movie movie)
        {
            if (Head == null)
            {
                Head = Tail = movie;
                return;
            }

            movie.Next = Head;
            Head.Prev = movie;
            Head = movie;
        }

        // Add at end
        public void AddAtEnd(Movie movie)
        {
            if (Tail == null)
            {
                Head = Tail = movie;
                return;
            }

            Tail.Next = movie;
            movie.Prev = Tail;
            Tail = movie;
        }

        // Add at position
        public void AddAtPosition(Movie movie, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(movie);
                return;
            }

            Movie temp = Head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null || temp.Next == null)
            {
                AddAtEnd(movie);
                return;
            }

            movie.Next = temp.Next;
            movie.Prev = temp;
            temp.Next.Prev = movie;
            temp.Next = movie;
        }

        // Remove by title
        public void RemoveByTitle(string title)
        {
            Movie temp = Head;

            while (temp != null)
            {
                if (temp.Title.Equals(title))
                {
                    if (temp == Head)
                    {
                        Head = Head.Next;
                        if (Head != null) Head.Prev = null;
                        else Tail = null;
                    }
                    else if (temp == Tail)
                    {
                        Tail = Tail.Prev;
                        Tail.Next = null;
                    }
                    else
                    {
                        temp.Prev.Next = temp.Next;
                        temp.Next.Prev = temp.Prev;
                    }
                    Console.WriteLine("Movie removed.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        // Search by director
        public void SearchByDirector(string director, MovieUtility util)
        {
            Movie temp = Head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Director.Equals(director))
                {
                    util.Print(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found.");
        }

        // Search by rating
        public void SearchByRating(double rating, MovieUtility util)
        {
            Movie temp = Head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Rating == rating)
                {
                    util.Print(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found.");
        }

        // Update rating
        public void UpdateRating(string title, double newRating)
        {
            Movie temp = Head;

            while (temp != null)
            {
                if (temp.Title.Equals(title))
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        // Display forward
        public void DisplayForward(MovieUtility util)
        {
            Movie temp = Head;
            while (temp != null)
            {
                util.Print(temp);
                temp = temp.Next;
            }
        }

        // Display reverse
        public void DisplayReverse(MovieUtility util)
        {
            Movie temp = Tail;
            while (temp != null)
            {
                util.Print(temp);
                temp = temp.Prev;
            }
        }
    }
}
