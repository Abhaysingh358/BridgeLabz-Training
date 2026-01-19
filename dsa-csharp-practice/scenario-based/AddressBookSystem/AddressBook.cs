using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.AddressBookSystem
{
    internal class AddressBook : IAddressBook
    {
        private string addressBookName;
        private ContactLinkedList contactList = new ContactLinkedList();

        public string GetAddressBookName()
        {
            return addressBookName;
        }

        public void SetAddressBookName(string addressBookName)
        {
            this.addressBookName = addressBookName;
        }

        // UC1
        public void AddContact()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            if (contactList.IsDuplicate(firstName))
            {
                Console.WriteLine("Contact Already Exists!");
                return;
            }

            Contact contact = new Contact();
            contact.SetFirstName(firstName);

            Console.WriteLine("Enter Last Name");
            contact.SetLastName(Console.ReadLine());

            Console.WriteLine("Enter Address");
            contact.SetAddress(Console.ReadLine());

            Console.WriteLine("Enter City");
            contact.SetCity(Console.ReadLine());

            Console.WriteLine("Enter State");
            contact.SetState(Console.ReadLine());

            Console.WriteLine("Enter Zip");
            contact.SetZip(Console.ReadLine());

            Console.WriteLine("Enter Phone Number");
            contact.SetPhoneNumber(Console.ReadLine());

            Console.WriteLine("Enter Email");
            contact.SetEmail(Console.ReadLine());

            contactList.Add(contact);

            Console.WriteLine("Contact Added Successfully!");
        }

        // Mandatory display (not UC)
        public void DisplayContact()
        {
            contactList.Display();
        }

        // UC3
        public void EditContact()
        {
            Console.WriteLine("Enter First Name to Edit Contact");
            string firstName = Console.ReadLine();

            Node node = contactList.Search(firstName);

            if (node == null)
            {
                Console.WriteLine("Contact Not Found");
                return;
            }

            Contact contact = node.GetContact();

            Console.WriteLine("\nWhat do you want to edit?");
            Console.WriteLine("1. Address");
            Console.WriteLine("2. City");
            Console.WriteLine("3. State");
            Console.WriteLine("4. Zip");
            Console.WriteLine("5. Phone Number");
            Console.WriteLine("6. Email");
            Console.WriteLine("Enter choice");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter New Address");
                    contact.SetAddress(Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Enter New City");
                    contact.SetCity(Console.ReadLine());
                    break;

                case 3:
                    Console.WriteLine("Enter New State");
                    contact.SetState(Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("Enter New Zip");
                    contact.SetZip(Console.ReadLine());
                    break;

                case 5:
                    Console.WriteLine("Enter New Phone Number");
                    contact.SetPhoneNumber(Console.ReadLine());
                    break;

                case 6:
                    Console.WriteLine("Enter New Email");
                    contact.SetEmail(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            Console.WriteLine("Contact Updated Successfully!");
        }

        // Delete (mandatory feature)
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name to Delete Contact");
            string firstName = Console.ReadLine();

            bool deleted = contactList.Delete(firstName);

            if (deleted)
            {
                Console.WriteLine("Contact Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
        }

        // Getter for AddressBookSystem UC8/UC9/UC10 (traversal)
        public ContactLinkedList GetContactList()
        {
            return contactList;
        }

        // old file jaisa method added because menu is calling AddMultipleContacts()
        // this method used to add multiple contacts by asking user how many contacts he wants to add
        public void AddMultipleContacts()
        {
            Console.WriteLine("How Many Contacts You Want to Add?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nEnter Contact " + (i + 1) + " Details");
                AddContact();
            }
        }

        // UC11 sorting method (menu is calling this method)
        // here we take user choice and sort contacts accordingly
        public void SortContactsByChoice()
        {
            Console.WriteLine("Choose Sorting Option");
            Console.WriteLine("1. Sort By First Name");
            Console.WriteLine("2. Sort By City");
            Console.WriteLine("3. Sort By State");
            Console.WriteLine("4. Sort By Zip");
            Console.WriteLine("Enter Choice");

            int choice = Convert.ToInt32(Console.ReadLine());

            // converting linked list to array (without collections)
            Contact[] arr = ConvertLinkedListToArray();

            if (arr == null)
            {
                Console.WriteLine("No Contact Found to Sort!");
                return;
            }

            // bubble sort without collections
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (CompareContacts(arr[j], arr[j + 1], choice) > 0)
                    {
                        Contact temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // rebuild linked list in sorted order
            contactList = new ContactLinkedList();

            for (int i = 0; i < arr.Length; i++)
            {
                contactList.Add(arr[i]);
            }

            Console.WriteLine("Contacts Sorted Successfully!");
            DisplayContact();
        }

        // helper method to convert linkedlist to array
        private Contact[] ConvertLinkedListToArray()
        {
            int count = 0;
            Node temp = contactList.GetHead();

            while (temp != null)
            {
                count++;
                temp = temp.GetNext();
            }

            if (count == 0)
                return null;

            Contact[] arr = new Contact[count];

            temp = contactList.GetHead();
            int index = 0;

            while (temp != null)
            {
                arr[index++] = temp.GetContact();
                temp = temp.GetNext();
            }

            return arr;
        }

        // compare method based on choice
        private int CompareContacts(Contact a, Contact b, int choice)
        {
            string valA = "";
            string valB = "";

            if (choice == 1)
            {
                valA = a.GetFirstName();
                valB = b.GetFirstName();
            }
            else if (choice == 2)
            {
                valA = a.GetCity();
                valB = b.GetCity();
            }
            else if (choice == 3)
            {
                valA = a.GetState();
                valB = b.GetState();
            }
            else if (choice == 4)
            {
                valA = a.GetZip();
                valB = b.GetZip();
            }
            else
            {
                valA = a.GetFirstName();
                valB = b.GetFirstName();
            }

            if (valA == null) valA = "";
            if (valB == null) valB = "";

            return string.Compare(valA, valB, StringComparison.OrdinalIgnoreCase);
        }
    }
}
