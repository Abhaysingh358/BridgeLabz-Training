
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.AddressBookSystem
{
    internal class ContactLinkedList
    {
        private Node head;

        public ContactLinkedList()
        {
            head = null;
        }

        // Add contact at end
        public void Add(Contact contact)
        {
            Node newNode = new Node(contact);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;

            while (temp.GetNext() != null)
            {
                temp = temp.GetNext();
            }

            temp.SetNext(newNode);
        }

        // Check duplicate by first name
        public bool IsDuplicate(string firstName)
        {
            Node temp = head;

            while (temp != null)
            {
                if (temp.GetContact().GetFirstName()
                    .Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                temp = temp.GetNext();
            }

            return false;
        }

        // Search node by first name
        public Node Search(string firstName)
        {
            Node temp = head;

            while (temp != null)
            {
                if (temp.GetContact().GetFirstName()
                    .Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    return temp;
                }

                temp = temp.GetNext();
            }

            return null;
        }

        // Display all contacts
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No Contact Found");
                return;
            }

            Node temp = head;
            int count = 1;

            while (temp != null)
            {
                Console.WriteLine($"\n--- Contact {count} ---");
                Console.WriteLine(temp.GetContact().ToString());

                count++;
                temp = temp.GetNext();
            }
        }

        // Delete contact by first name
        public bool Delete(string firstName)
        {
            if (head == null)
            {
                return false;
            }

            if (head.GetContact().GetFirstName()
                .Equals(firstName, StringComparison.OrdinalIgnoreCase))
            {
                head = head.GetNext();
                return true;
            }

            Node prev = head;
            Node curr = head.GetNext();

            while (curr != null)
            {
                if (curr.GetContact().GetFirstName()
                    .Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    prev.SetNext(curr.GetNext());
                    return true;
                }

                prev = curr;
                curr = curr.GetNext();
            }

            return false;
        }

        // Get Head (for traversal in AddressBookSystem UC8/UC9/UC10 later)
        public Node GetHead()
        {
            return head;
        }
    }
}
