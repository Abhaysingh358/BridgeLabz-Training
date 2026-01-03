using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("ISBN101", "48 Laws of Power", "Robert Greene");
            Book b2 = new Book("ISBN102", "Harry Potter", "JK Rowling");


            // static method call
            Book.DisplayLibraryName();
            Console.WriteLine();

            // using is operator before displaying
            b1.Display(b1);
            b1.Display(b2);

            // non-book object check
            object obj = "Hello World";
            b1.Display(obj);
        }
    }
}
