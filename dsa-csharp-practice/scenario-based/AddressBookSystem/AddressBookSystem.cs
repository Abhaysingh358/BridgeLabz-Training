
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BridgeLabz.gcr_codebase.DSA.scenario_based.AddressBookSystem
{
    internal class AddressBookSystem : IAddressBookSystem
    {
        private AddressBookLinkedList addressBookList = new AddressBookLinkedList();

        public void AddAddressBook()
        {
            Console.WriteLine("Enter AddressBook Name");
            string name = Console.ReadLine();

            if (addressBookList.IsDuplicate(name))
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
            addressBookList.Display();
        }

        // method to choose Select address book 
        // because when  we use menu method in which we a method to select address book
        //sothat we can use the utiltiy of addressbook
        public AddressBook SelectAddressBook()
        {
            Console.WriteLine("Enter AddressBook Name");
            string name = Console.ReadLine();

            AddressBook addressBook = addressBookList.Search(name);

            if (addressBook == null)
            {
                Console.WriteLine("AddressBook Not Found");
                return null;
            }

            Console.WriteLine("AddressBook Selected Successfully!");
            return addressBook;
        }

        // method for using uc8
        //where we to search person by his city and search by state
        public void SearchPersonByCity()
        {
            AddressBookNode abNode = addressBookList.GetHead();

            if (abNode == null)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine().ToLower();

            int found = 0;

            while (abNode != null)
            {
                AddressBook addressBook = abNode.GetData();
                Node head = addressBook.GetContactList().GetHead();

                // getting contactes index count and contacts details
                // store it in new conctacts array so that we search it by -
                // city using for loop till contacts array length

                // if there is other contacts with same city it will show the all user-
                // when searching used by city
                while (head != null)
                {
                    Contact contact = head.GetContact();

                    if (contact.GetCity().ToLower().Equals(city))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }

                    head = head.GetNext();
                }

                abNode = abNode.GetNext();
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This City");
            }
        }


        // Search by state  same method like search by city for using UC8
        public void SearchPersonByState()
        {
            AddressBookNode abNode = addressBookList.GetHead();

            if (abNode == null)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine().ToLower();

            int found = 0;

            while (abNode != null)
            {
                AddressBook addressBook = abNode.GetData();
                Node head = addressBook.GetContactList().GetHead();

                while (head != null)
                {
                    Contact contact = head.GetContact();

                    if (contact.GetState().ToLower().Equals(state))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }

                    head = head.GetNext();
                }

                abNode = abNode.GetNext();
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This State");
            }
        }
        // uc8 methods end here


        // uc9 methods where we to print view person by city or state
        // method to view by city
        public void ViewPersonsByCity()
        {
            AddressBookNode abNode = addressBookList.GetHead();

            if (abNode == null)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine().ToLower();

            int found = 0;

            while (abNode != null)
            {
                AddressBook addressBook = abNode.GetData();
                Node head = addressBook.GetContactList().GetHead();

                while (head != null)
                {
                    Contact contact = head.GetContact();

                    if (contact.GetCity().ToLower().Equals(city))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }

                    head = head.GetNext();
                }

                abNode = abNode.GetNext();
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This City");
            }
            else
            {
                Console.WriteLine("\nTotal Persons in City : " + found);
            }
        }

        // view by state
        public void ViewPersonsByState()
        {
            AddressBookNode abNode = addressBookList.GetHead();

            if (abNode == null)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine().ToLower();

            int found = 0;

            while (abNode != null)
            {
                AddressBook addressBook = abNode.GetData();
                Node head = addressBook.GetContactList().GetHead();

                while (head != null)
                {
                    Contact contact = head.GetContact();

                    if (contact.GetState().ToLower().Equals(state))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBook.GetAddressBookName());
                        Console.WriteLine(contact.ToString());
                        found++;
                    }

                    head = head.GetNext();
                }

                abNode = abNode.GetNext();
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This State");
            }
            else
            {
                Console.WriteLine("\nTotal Persons in State : " + found);
            }
        }


        //uc9 ends here

        // uc 10 count by city and state
        public void CountByCity()
        {
            AddressBookNode abNode = addressBookList.GetHead();

            if (abNode == null)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine().ToLower();

            int total = 0;

            while (abNode != null)
            {
                AddressBook addressBook = abNode.GetData();
                Node head = addressBook.GetContactList().GetHead();

                while (head != null)
                {
                    Contact contact = head.GetContact();

                    if (contact.GetCity().ToLower().Equals(city))
                    {
                        total++;
                    }

                    head = head.GetNext();
                }

                abNode = abNode.GetNext();
            }

            Console.WriteLine("Total Persons in City " + city + " : " + total);
        }

        // count by state

        public void CountByState()
        {
            AddressBookNode abNode = addressBookList.GetHead();

            if (abNode == null)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine().ToLower();

            int total = 0;

            while (abNode != null)
            {
                AddressBook addressBook = abNode.GetData();
                Node head = addressBook.GetContactList().GetHead();

                while (head != null)
                {
                    Contact contact = head.GetContact();

                    if (contact.GetState().ToLower().Equals(state))
                    {
                        total++;
                    }

                    head = head.GetNext();
                }

                abNode = abNode.GetNext();
            }

            Console.WriteLine("Total Persons in State " + state + " : " + total);
        }
        // uc 10 ends here



    }
}