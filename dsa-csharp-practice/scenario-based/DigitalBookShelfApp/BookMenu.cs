using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.DigitalBookShelfApp
{
    internal class BookMenu
    {
        private BookUtils bookUtils = new BookUtils();
        private int Choice = 0;

        public void Start()
        {
            Console.WriteLine("Digital BookShelf App");
           
            do
            {

                Console.WriteLine("\n1. Add Books");
                Console.WriteLine("2.Sort Books Alphabetically by Author");
                Console.WriteLine("3. Search by Author");
                Console.WriteLine("4.Display All Books");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter the choice");
                Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        bookUtils.AddBook();
                        break;

                    case 2:
                        bookUtils.SortBooksAlphabetically();
                        break;
                    case 3:
                        bookUtils.SearchByAuthor();
                        break;

                    case 4:
                        bookUtils.DisplayAllBooks();
                        break;

                    case 5:
                        Console.WriteLine("Reading a book Daily makes smarter ");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                } 

            } while (Choice != 5);
        }
    }

    
}
