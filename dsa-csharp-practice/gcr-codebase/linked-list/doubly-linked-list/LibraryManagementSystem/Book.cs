using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.LibraryManagementSystem
{
    internal class Book
    {
        public int BookId;
        public string Title;
        public string Author;
        public string Genre;
        public bool IsAvailable;

        public Book Next;
        public Book Prev;

        public Book(int bookId, string title, string author, string genre, bool isAvailable)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
            Next = null;
            Prev = null;
        }
    }
}
