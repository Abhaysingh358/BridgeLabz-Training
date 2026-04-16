using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.LibraryManagementSystem
{
    internal class LibraryUtility
    {
        public Book CreateBook()
        {
            Console.Write("Book ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Available (true/false): ");
            bool available = bool.Parse(Console.ReadLine());

            return new Book(id, title, author, genre, available);
        }

        public void Print(Book book)
        {
            Console.WriteLine(
                $"ID:{book.BookId}, Title:{book.Title}, Author:{book.Author}," +
                $" Genre:{book.Genre}, Available:{book.IsAvailable}");
        }
    }
}
