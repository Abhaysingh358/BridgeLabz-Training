using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.review.AddressBookingSystem
{
    public class Menu
    {
        private Utility Place;

        public Menu(Utility Place )
        {
            this.Place = Place;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Address");
                Console.WriteLine("2. Search Address");
                Console.WriteLine("3. Sort by Pin");
                Console.WriteLine("4. Display All");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddAddress();
                        break;

                    case 2:
                        SearchAddress();
                        break;

                    case 3:
                        Place.SortByPin();
                        Console.WriteLine("Sorted by pin.");
                        break;

                    case 4:
                        Place.DisplayAll();
                        break;

                    case 5:
                        return;
                }
            }
        }

        private void AddAddress()
        {
            Console.Write("Pin: ");
            int pin = int.Parse(Console.ReadLine());

            Console.Write("Region: ");
            string region = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Town: ");
            string town = Console.ReadLine();

            Place.Add(new Address(pin, region, state, town));
            Console.WriteLine("Address added.");
        }

        private void SearchAddress()
        {
            Console.Write("Enter search keyword: ");
            string key = Console.ReadLine();
            Place.Search(key);
        }
    }

}
