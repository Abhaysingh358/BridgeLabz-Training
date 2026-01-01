using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.level01.BookDetails
{
    internal class Book
    {
        string Title;
        string Author;
        double price;

        public Book()
        {
            Input();
        }
        public void Input()
        {
            Console.WriteLine("Enter the title of the book");
             Title = Console.ReadLine();

            Console.WriteLine("Enter the Author Name");
             Author = Console.ReadLine();

            Console.WriteLine("Enter the price");
             price = double.Parse(Console.ReadLine());

        }

        public void Display()
        {
            Console.WriteLine("========Book Details========");
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Author}");
            Console.WriteLine($"Price : { price}");
        }
    }
}
