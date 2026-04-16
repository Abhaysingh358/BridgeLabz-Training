using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookSystem : IAddressBookSystem
    {
        // using generic list instead of custom linked list
        private List<AddressBook> addressBookList = new List<AddressBook>();

        public void AddAddressBook()
        {
            Console.WriteLine("Enter AddressBook Name");
            string name = Console.ReadLine();

            // check duplicate address book name
            if (addressBookList.Any(a =>
                a.GetAddressBookName().Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("AddressBook Name Already Exists!");
                return;
            }

            AddressBook addressBook = new AddressBook();
            addressBook.SetAddressBookName(name);

            addressBookList.Add(addressBook);

            Console.WriteLine("AddressBook Added Successfully!");
        }

        public void DisplayAddressBooks()
        {
            if (addressBookList.Count == 0)
            {
                Console.WriteLine("No AddressBooks Available");
                return;
            }

            Console.WriteLine("\n===== AddressBooks =====");

            foreach (var book in addressBookList)
            {
                Console.WriteLine(book.GetAddressBookName());
            }
        }

        // method to choose Select address book
        public AddressBook SelectAddressBook()
        {
            Console.WriteLine("Enter AddressBook Name");
            string name = Console.ReadLine();

            AddressBook addressBook = addressBookList.FirstOrDefault(a =>
                a.GetAddressBookName().Equals(name, StringComparison.OrdinalIgnoreCase));

            if (addressBook == null)
            {
                Console.WriteLine("AddressBook Not Found");
                return null;
            }

            Console.WriteLine("AddressBook Selected Successfully!");
            return addressBook;
        }

        // method for using uc8
        // where we search person by city
        public void SearchPersonByCity()
        {
            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine().ToLower();

            int found = 0;

            foreach (var addressBook in addressBookList)
            {
                foreach (var contact in addressBook.GetContactList())
                {
                    if (contact.GetCity().ToLower().Equals(city))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }
                }
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This City");
            }
        }

        // Search by state same method like search by city for using UC8
        public void SearchPersonByState()
        {
            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine().ToLower();

            int found = 0;

            foreach (var addressBook in addressBookList)
            {
                foreach (var contact in addressBook.GetContactList())
                {
                    if (contact.GetState().ToLower().Equals(state))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }
                }
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This State");
            }
        }

        // uc9 methods where we print view person by city
        public void ViewPersonsByCity()
        {
            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine().ToLower();

            int found = 0;

            foreach (var addressBook in addressBookList)
            {
                foreach (var contact in addressBook.GetContactList())
                {
                    if (contact.GetCity().ToLower().Equals(city))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }
                }
            }

            if (found == 0)
                Console.WriteLine("No Person Found In This City");
            else
                Console.WriteLine("\nTotal Persons in City : " + found);
        }

        // view by state
        public void ViewPersonsByState()
        {
            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine().ToLower();

            int found = 0;

            foreach (var addressBook in addressBookList)
            {
                foreach (var contact in addressBook.GetContactList())
                {
                    if (contact.GetState().ToLower().Equals(state))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }
                }
            }

            if (found == 0)
                Console.WriteLine("No Person Found In This State");
            else
                Console.WriteLine("\nTotal Persons in State : " + found);
        }

        // uc 10 count by city
        public void CountByCity()
        {
            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine().ToLower();

            int total = 0;

            foreach (var addressBook in addressBookList)
            {
                total += addressBook.GetContactList()
                    .Count(c => c.GetCity().ToLower().Equals(city));
            }

            Console.WriteLine("Total Persons in City " + city + " : " + total);
        }

        // count by state
        public void CountByState()
        {
            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine().ToLower();

            int total = 0;

            foreach (var addressBook in addressBookList)
            {
                total += addressBook.GetContactList()
                    .Count(c => c.GetState().ToLower().Equals(state));
            }

            Console.WriteLine("Total Persons in State " + state + " : " + total);
        }
    }
}
