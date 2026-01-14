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

        public AddressBook SelectAddressBook()
        {
            if (Count == 0)
            {
                Console.WriteLine("No AddressBook Found");
                return null ;
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
    }
}
