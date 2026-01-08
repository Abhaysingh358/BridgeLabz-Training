using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.LibraryManagementSystem
{
    internal class LibraryLinkedList
    {
        private Book Head;
        private Book Tail;

        // Add at beginning
        public void AddAtBeginning(Book book)
        {
            if (Head == null)
            {
                Head = Tail = book;
                return;
            }

            book.Next = Head;
            Head.Prev = book;
            Head = book;
        }

        // Add at end
        public void AddAtEnd(Book book)
        {
            if (Tail == null)
            {
                Head = Tail = book;
                return;
            }

            Tail.Next = book;
            book.Prev = Tail;
            Tail = book;
        }

        // Add at position
        public void AddAtPosition(Book book)
        {
            Console.WriteLine("Enter the Postion");

            int position = int.Parse(Console.ReadLine());

            if (position <= 1)
            {
                AddAtBeginning(book);
                return;
            }

            Book temp = Head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null || temp.Next == null)
            {
                AddAtEnd(book);
                return;
            }

            book.Next = temp.Next;
            book.Prev = temp;
            temp.Next.Prev = book;
            temp.Next = book;
        }

        // Remove by Book ID
        public void RemoveById(int bookId)
        {
            Book temp = Head;

            while (temp != null)
            {
                if (temp.BookId == bookId)
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
                    return;
                }
                temp = temp.Next;
            }
        }

        // Search by title
        public Book SearchByTitle(string title)
        {
            Book temp = Head;
            while (temp != null)
            {
                if (temp.Title.Equals(title))
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        // Search by author
        public void SearchByAuthor(string author, LibraryUtility util)
        {
            Book temp = Head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Author.Equals(author))
                {
                    util.Print(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No books found.");
        }

        // Update availability
        public void UpdateAvailability(int bookId, bool status)
        {
            Book temp = Head;
            while (temp != null)
            {
                if (temp.BookId == bookId)
                {
                    temp.IsAvailable = status;
                    return;
                }
                temp = temp.Next;
            }
        }

        // Display forward
        public void DisplayForward(LibraryUtility util)
        {
            Book temp = Head;
            while (temp != null)
            {
                util.Print(temp);
                temp = temp.Next;
            }
        }

        // Display reverse
        public void DisplayReverse(LibraryUtility util)
        {
            Book temp = Tail;
            while (temp != null)
            {
                util.Print(temp);
                temp = temp.Prev;
            }
        }

        // Count total books
        public int CountBooks()
        {
            int count = 0;
            Book temp = Head;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
    }
}
