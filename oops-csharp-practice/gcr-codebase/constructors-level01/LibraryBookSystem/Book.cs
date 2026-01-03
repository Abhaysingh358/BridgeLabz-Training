using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.LibraryBookSystem
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;
        private bool isAvailable;

        public Book()
        {
            TakeInput();
        }

        private void TakeInput()
        {
            Console.WriteLine("Enter Book Title:");
            title = Console.ReadLine();

            Console.WriteLine("Enter Author Name:");
            author = Console.ReadLine();

            Console.WriteLine("Enter Book Price:");
            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Is the book available? (yes/no)");
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                isAvailable = true;
            }

        }

        public void BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"You have successfully borrowed : {title}.");
            }
            else
            {
                Console.WriteLine($"Sorry : {title} is currently not available.");
            }
        }

        public void Display()
        {
            Console.WriteLine("\nBook Details");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Author : {author}");
            Console.WriteLine($"Price  : {price} rs.");
            Console.WriteLine($"Availability : {(isAvailable ? "Available" : "Not Available")}");
        }
    }
}
