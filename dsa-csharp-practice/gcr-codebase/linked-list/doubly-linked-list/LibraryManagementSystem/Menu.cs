using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.DoublyLinkedList.LibraryManagementSystem
{
    internal class Menu
    {
        private LibraryLinkedList list = new LibraryLinkedList();
        private LibraryUtility util = new LibraryUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine(
                    "\n1.AddBegin 2.AddEnd 3.AddPos 4.Remove 5.SearchTitle 6.SearchAuthor\n" +
                    " 7.UpdateAvail 8.Dispaly Forward 9.Display Reverse 10.Count 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddAtBeginning(util.CreateBook());
                        break;

                    case 2:
                        list.AddAtEnd(util.CreateBook());
                        break;

                    case 3:
                        Console.Write("Position: ");
                        list.AddAtPosition(util.CreateBook());
                        break;

                    case 4:
                        Console.Write("Book ID: ");
                        list.RemoveById(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Title: ");
                        Book byTitle = list.SearchByTitle(Console.ReadLine());
                        if (byTitle != null) util.Print(byTitle);
                        else Console.WriteLine("Book not found.");
                        break;

                    case 6:
                        Console.Write("Author: ");
                        list.SearchByAuthor(Console.ReadLine(), util);
                        break;

                    case 7:
                        Console.Write("Book ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Available (true/false): ");
                        list.UpdateAvailability(id, bool.Parse(Console.ReadLine()));
                        break;

                    case 8:
                        list.DisplayForward(util);
                        break;

                    case 9:
                        list.DisplayReverse(util);
                        break;

                    case 10:
                        Console.WriteLine("Total Books: " + list.CountBooks());
                        break;
                }

            } while (choice != 0);
        }
    }
}
