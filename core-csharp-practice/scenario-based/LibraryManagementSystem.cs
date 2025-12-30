using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenerio_based
{
    internal class LibraryManagementSystem
    {
        static string[,] books = new string[50, 3];
        static int count = 0;

        // Loads some books when program starts so library is not empty
        static void LoadDefaultBooks()
        {
            books[count, 0] = "harry potter";
            books[count, 1] = "j.k. rowling";
            books[count, 2] = "available";
            count++;

            books[count, 0] = "the hobbit";
            books[count, 1] = "j.r.r. tolkien";
            books[count, 2] = "available";
            count++;

            books[count, 0] = "the alchemist";
            books[count, 1] = "paulo coelho";
            books[count, 2] = "available";
            count++;

            books[count, 0] = "java basics";
            books[count, 1] = "james gosling";
            books[count, 2] = "available";
            count++;

            books[count, 0] = "c# programming";
            books[count, 1] = "microsoft";
            books[count, 2] = "available";
            count++;
        }

        // Adds a new book to the library
        void AddBook()
        {
            if (count == books.GetLength(0))
            {
                ResizeArray();
            }

            Console.Write("Enter Book Title: ");
            books[count, 0] = Console.ReadLine().ToLower().Trim();

            Console.Write("Enter Book Author: ");
            books[count, 1] = Console.ReadLine().ToLower().Trim();

            books[count, 2] = "available";

            count++;

            Console.WriteLine("Book added successfully!\n");
        }

        // Automatically increases the array size when it becomes full
        void ResizeArray()
        {
            string[,] newBooks = new string[books.GetLength(0) * 2, 3];

            for (int i = 0; i < books.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newBooks[i, j] = books[i, j];
                }
            }

            books = newBooks;

            Console.WriteLine("Library capacity increased automatically!\n");
        }

        // Removes a book if its title matches
        void RemoveBook()
        {
            Console.Write("Enter title to remove: ");
            string title = Console.ReadLine().ToLower().Trim();

            for (int i = 0; i < count; i++)
            {
                if (books[i, 0] == title)
                {
                    books[i, 0] = books[count - 1, 0];
                    books[i, 1] = books[count - 1, 1];
                    books[i, 2] = books[count - 1, 2];

                    count--;

                    Console.WriteLine("Book removed successfully!\n");
                    return;
                }
            }

            Console.WriteLine("Book not found.\n");
        }

        // Searches for books by partial title , it will search even if you typed  a substring of book string
        void SearchBook()
        {
            Console.Write("Enter partial title to search: ");
            string BookName = Console.ReadLine().ToLower().Trim();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (books[i, 0].Contains(BookName))
                {
                    Console.WriteLine($"Title: {books[i, 0]}, Author: {books[i, 1]}, Status: {books[i, 2]}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found!\n");
            }
        }

        // Allows user to rent a book by title
        static void RentBook()
        {
            Console.Write("Enter book  to rent: ");
            string book = Console.ReadLine().ToLower().Trim();

            for (int i = 0; i < count; i++)
            {
                if (books[i, 0] == book)
                {
                    if (books[i, 2] == "available")
                    {
                        books[i, 2] = "checkedout";
                        Console.WriteLine("Book rented successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("This book is already rented!\n");
                    }
                    return;
                }
            }

            Console.WriteLine("Book not found.\n");
        }

        // Allows user to return a rented book
        void ReturnBook()
        {
            Console.WriteLine("Enter the book name to return");
            string book = Console.ReadLine().ToLower().Trim();
            for (int i = 0; i < count; i++)
            {
                if (books[i, 0] == book)
                {
                    if (books[i, 2] == "checkedout")
                    {
                        books[i, 2] = "available";
                        Console.WriteLine("Book returned successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("This book is not rented currently!\n");
                    }
                    return;
                }
            }

            Console.WriteLine("Book not found in this library.\n");
        }

        // Displays all books with title, author, and status
        private void seeBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("No books available in the library.\n");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Title : {books[i, 0]} , Author : {books[i, 1]} , Status : {books[i, 2]}");
            }
        }

        // Handles login and if admin eners password wrong mistamely , it will ask again to enter
        public static string Login()
        {
            string password = "Bridgelabz#984";
            Console.WriteLine("Enter the password to use admin services");
            string userPassword = Console.ReadLine();

            while (userPassword != password)
            {
                Console.WriteLine("Wrong password!");
                Console.WriteLine("1. Re-enter password");
                Console.WriteLine("2. Login as user");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the password again");
                        userPassword = Console.ReadLine();
                        break;

                    case 2:
                        return "user";

                    case 3:
                        return "exit";

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }

            return "admin";
        }

        // menu driven method so that admin have access of all things 
        void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== ADMIN MENU ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display All Books");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;

                    case 2:
                        RemoveBook();
                        break;

                    case 3:
                        seeBooks();
                        break;

                    case 4:
                        SearchBook();
                        break;

                    case 5:
                        Console.WriteLine("Exiting Admin Menu...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        // making menu driven user method so user have choices to use services
        void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== USER MENU ===");
                Console.WriteLine("1. Display All Books");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Rent Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        seeBooks();
                        break;

                    case 2:
                        SearchBook();
                        break;

                    case 3:
                        RentBook();
                        break;

                    case 4:
                        ReturnBook();
                        break;

                    case 5:
                        Console.WriteLine("Exiting User Menu...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice,try again.");
                        break;
                }
            }
        }

        // this method decides what to do after login (admin/user/exit)
        static void Authenticate()
        {
            string role = Login();
            LibraryManagementSystem obj = new LibraryManagementSystem();

            if (role == "admin")
            {
                Console.WriteLine("Logged in as Admin");
                obj.AdminMenu();
            }
            else if (role == "user")
            {
                Console.WriteLine("\nLogged in as User.\n");
                obj.UserMenu();
            }
            else if (role == "exit")
            {
                Console.WriteLine("Exiting program...");
            }
        }

        // First menu where user chooses role
        static void SelectingRoll()
        {
            Console.WriteLine("1. to login as an admin");
            Console.WriteLine("2. to login as a user");
            Console.WriteLine("3. to exit the program");
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (num)
                {
                    case 1:
                        Authenticate();
                        return;

                    case 2:
                        Console.WriteLine("Logged in as User\n");
                        LibraryManagementSystem userObj = new LibraryManagementSystem();
                        userObj.UserMenu();
                        return;

                    case 3:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again:");
                        num = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }

        // Program starts here
        static void Main(string[] args)
        {
            LoadDefaultBooks();
            SelectingRoll();
        }

    }
}
