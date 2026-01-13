using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.DigitalBookShelfApp
{
    internal class BookUtils : IBook
    {
        private Book[] books = new Book[100];
        private int count = 0;


        // Add Book
        public void AddBook()
        {
            Console.WriteLine("Enter the Title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the Author");
            string author = Console.ReadLine();

            if (count >= books.Length)
            {
                Console.WriteLine("BookeShelf is Full");
                return;
            }

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                Console.WriteLine("Book Name or Author Name Can't be empty");
                return;
            }

            Book book = new Book();
            book.SetTitle(title);
            book.SetAuthor(author);
            books[count++] = book;
        }

        // Sort Alphabetically
        public void SortBooksAlphabetically()
        {
            if (count == 0)
            {
                Console.WriteLine("No Books To Short");
                return;
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    // Compare authors
                    if (string.Compare(books[j].GetAuthor(), books[j + 1].GetAuthor(), true) > 0)
                    {
                        // swap
                        Book temp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Books sorted alphabetically by Author");



        }


        // Search By Author
        public void SearchByAuthor()
        {
            Console.WriteLine("Enter the Author Name");
            String author = Console.ReadLine();
            if (string.IsNullOrEmpty(author))
            {
                Console.WriteLine("Author name can't be empty"); return;
            }
            bool isContain = false;

            for (int i = 0; i < count; i++)
            {

                if (books[i].GetAuthor().Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[i].ToString());
                    isContain = true;
                }
            }

            if (!isContain)
            {
                Console.WriteLine("No Books Found Related to Your Searches");
            }

        }


        public void DisplayAllBooks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i]);
            }

        }

    }
}
