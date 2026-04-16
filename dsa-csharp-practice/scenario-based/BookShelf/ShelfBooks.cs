using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.BookShelf
{
    class ShelfNode
    {
        public Book book;
        public ShelfNode Prev;
        public ShelfNode Next;
        public ShelfNode(Book book)
        {
            this.book = book;
            Prev = null;
            Next = null;
        }
        public Book GetBook() { return book; }
    }
    internal class ShelfBooks
    {
        ShelfNode head;
        ShelfNode current;


        public ShelfNode GetShelf() { return head; }
        public void Add(Book book)
        {
            ShelfNode node = new ShelfNode(book);
            if (head == null)
            {
                head = node;
                current = node;
                return;
            }
            current.Next = node;
            node.Prev = current;
            current = node;

            Console.WriteLine("Added a Book in the List");
        }

        public bool Remove(string name)
        {
            ShelfNode temp = head;
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return false;
            }

            while (temp != null)
            {
                if (temp.GetBook().GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    else
                        head = temp.Next;
                    if (head != null)
                        head.Prev = null;

                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;
                    else
                        current = temp.Prev;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
        public void Update(string name)
        {
            ShelfNode temp = head;
            if (head == null)
            {
                Console.WriteLine("there is no book to update");
            }
            while (temp != null)
            {
                if (temp.GetBook().GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if (temp.GetBook().GetStatus())
                    {
                        temp.GetBook().SetStatus(false);
                        Console.WriteLine("You have Borrowd this book");
                    }
                    else
                    {
                        temp.GetBook().SetStatus(true);
                        Console.WriteLine("The book has been returned");
                    }
                    return;
                }

                temp = temp.Next;
            }
        }
        public void Display()
        {
            ShelfNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.GetBook());
                temp = temp.Next;
            }
        }
    }
}
