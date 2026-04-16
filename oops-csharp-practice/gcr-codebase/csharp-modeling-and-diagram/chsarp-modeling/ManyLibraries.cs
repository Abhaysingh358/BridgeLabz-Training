using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.class_modeling_and_diagram.chsarp_modeling
{
    internal class ManyLibraries
    {
        static void Main(string[] args)
        {
            //Creating book objects
            Book b1 = new Book("the heat of Lave", "mount ain");
            Book b2 = new Book("the sun also rise", "hemingway");

            Library l1 = new Library("GLA library");
            Library l2 = new Library("bridgeLabz library");
            //Adding books to libraries
            l1.AddBook(b1);
            l2.AddBook(b2);
            l1.AddBook(b2);
            l1.Display();
            l2.Display();
        }
    }

    class Book
    {
        //Attributes
        public string Title;
        public string Author;
        //Constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    class Library
    {
        //Attributes
        public string Name;
        public Book[] Books = new Book[10];

        public Library(string name)
        {
            Name = name;
        }
        //Methods
        int i = 0;
        public void AddBook(Book book)
        {
            //Adding book to the array
            if (i< Books.Length)
            {
                Books[i] = book;
                i++;
            }
            else
            {
                Console.WriteLine("No more books");
            }
        }
        //Display method
        public void Display()
        {
            for(int j = 0; j < i; j++)
            {
                Console.WriteLine("Title " + Books[j].Title + " Author " + Books[j].Author);
            }
        }
    }
}
