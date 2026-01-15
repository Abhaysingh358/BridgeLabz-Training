using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookSystem : IAddressBookSystem
    {
        private AddressBook[] addressBooks = new AddressBook[10];
        private string[] addressBookNames = new string[10];
        private int Count = 0;

        public void AddAddressBook()
        {
            if (Count >= addressBooks.Length)
            {
                Console.WriteLine("AddressBook Limit Reached!");
                return;
            }

            Console.WriteLine("Enter AddressBook Name");
            string name = Console.ReadLine();

            for (int i = 0; i < Count; i++)
            {
                if (addressBookNames[i].ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("AddressBook Name Already Exists!");
                    return;
                }
            }

            addressBooks[Count] = new AddressBook();
            addressBookNames[Count] = name;
            Count++;

            Console.WriteLine("AddressBook Added Successfully!");
        }

        public void DisplayAddressBooks()
        {
            if (Count == 0)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Available AddressBooks:");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + addressBookNames[i]);
            }
        }

        // method to choose Select address book 
        // because when  we use menu method in which we a method to select address book
        //sothat we can use the utiltiy of addressbook
        public AddressBook SelectAddressBook()
        {
            if (Count == 0)
            {
                Console.WriteLine("No AddressBook Found");
                return null;
            }

            Console.WriteLine("Enter AddressBook Name");
            string name = Console.ReadLine();

            for (int i = 0; i < Count; i++)
            {
                if (addressBookNames[i].ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("AddressBook Selected Successfully!");
                    return addressBooks[i];
                }
            }

            Console.WriteLine("AddressBook Not Found");
            return null;
        }

        // method for using uc8
        //where we to search person by his city and search by state
        public void SearchPersonByCity()
        {
            if (Count == 0)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine().ToLower();

            int found = 0;

            for (int i = 0; i < Count; i++)
            {
                // getting contactes index count and contacts details
                // store it in new conctacts array so that we search it by -
                // city using for loop till contacts array length

                Contact[] contacts = addressBooks[i].GetContacts();
                int contactCount = addressBooks[i].GetCount();
                // if there is other contacts with same city it will show the all user-
                // when searching used by city
                for (int j = 0; j < contactCount; j++)
                {
                    if (contacts[j].GetCity().ToLower().Equals(city))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBookNames[i]);
                        Console.WriteLine(contacts[j].ToString());
                        found++;
                    }
                }
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This City");
            }
        }


        // Search by state  same method like search by city for using UC8
        public void SearchPersonByState()
        {
            if (Count == 0)
            {
                Console.WriteLine("No AddressBook Found");
                return;
            }

            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine().ToLower();

            int found = 0;

            for (int i = 0; i < Count; i++)
            {
                Contact[] contacts = addressBooks[i].GetContacts();
                int contactCount = addressBooks[i].GetCount();

                for (int j = 0; j < contactCount; j++)
                {
                    if (contacts[j].GetState().ToLower().Equals(state))
                    {
                        Console.WriteLine("\nAddressBook : " + addressBookNames[i]);
                        Console.WriteLine(contacts[j].ToString());
                        found++;
                    }
                }
            }

            if (found == 0)
            {
                Console.WriteLine("No Person Found In This State");
            }
        }
        // uc8 methods end here




    }
}
