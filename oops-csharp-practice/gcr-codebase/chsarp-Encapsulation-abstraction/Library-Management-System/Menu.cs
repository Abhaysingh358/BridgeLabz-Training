using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.Library_Management_System
{
    internal class Menu
    {
        LibraryItem[] items = new LibraryItem[3]; // array used
        int index = 0;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Choose Item to Add:");
                Console.WriteLine("1.Book");
                Console.WriteLine("2.Magazine");
                Console.WriteLine("3.DVD");
                Console.WriteLine("4.Show Items");
                Console.WriteLine("5.Reserve Item");
                Console.WriteLine("6.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddItem(new Book()); break;
                    case 2: AddItem(new Magazine()); break;
                    case 3: AddItem(new DVD()); break;
                    case 4: ShowItems(); break;
                    case 5: Reserve(); break;
                    case 6: return;
                }
            }
        }

        void AddItem(LibraryItem item)
        {
            if (index >= items.Length) return;

            Console.Write("Id: ");
            item.SetItemId(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Title: ");
            item.SetTitle(Console.ReadLine());

            Console.Write("Author: ");
            item.SetAuthor(Console.ReadLine());

            items[index++] = item;
        }

        void ShowItems()
        {
            for (int i = 0; i < index; i++)
            {
                items[i].GetItemDetails();
                Console.WriteLine("Loan Days: " + items[i].GetLoanDuration());
            }
        }

        void Reserve()
        {
            Console.Write("Index: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (items[i] is IReservable r)
                r.ReserveItem();
        }
    }
}
