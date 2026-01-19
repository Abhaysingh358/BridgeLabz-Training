using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.AddressBookSystem
{
    internal class AddressBookLinkedList
    {
        private AddressBookNode head;

        public AddressBookLinkedList()
        {
            head = null;
        }

        public AddressBookNode GetHead()
        {
            return head;
        }

        public bool IsDuplicate(string name)
        {
            AddressBookNode temp = head;

            while (temp != null)
            {
                if (temp.GetData().GetAddressBookName()
                    .Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                temp = temp.GetNext();
            }

            return false;
        }

        public void Add(AddressBook addressBook)
        {
            AddressBookNode newNode = new AddressBookNode(addressBook);

            if (head == null)
            {
                head = newNode;
                return;
            }

            AddressBookNode temp = head;

            while (temp.GetNext() != null)
            {
                temp = temp.GetNext();
            }

            temp.SetNext(newNode);
        }

        public AddressBook Search(string name)
        {
            AddressBookNode temp = head;

            while (temp != null)
            {
                if (temp.GetData().GetAddressBookName()
                    .Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return temp.GetData();
                }

                temp = temp.GetNext();
            }

            return null;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No AddressBooks Available");
                return;
            }

            Console.WriteLine("\n===== AddressBooks =====");

            AddressBookNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.GetData().GetAddressBookName());
                temp = temp.GetNext();
            }
        }
    }
}
