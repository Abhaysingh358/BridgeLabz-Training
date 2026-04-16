using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.LibraryManagementSystem
{
    internal class Book
    {
        // static variable
        static string LibraryName = "Central Library ,Mathura";

        // readonly variable 
        public readonly string ISBN;

        // instance variables
        string Title;
        string Author;

        public Book(string ISBN, string Title, string Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }

        // static method
        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name : {LibraryName}");
        }

        // instance method to display book details using is operator
        public void Display(object obj)
        {
            if (obj is Book book)
            {
                Console.WriteLine("Book Details");
                Console.WriteLine($"ISBN : {book.ISBN}");
                Console.WriteLine($"Title : {book.Title}");
                Console.WriteLine($"Author : {book.Author}");
            }
            else
            {
                Console.WriteLine("Object is not a Book");
            }
        }
    }
}
