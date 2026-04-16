using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeLabz.collection_csharp_practice.scenario_based.AddressBookSystem
{
    public class AddressBook : IAddressBook , IAddressBookLogic
    {
        private string addressBookName;

        // using generic list instead of custom linked list
        private List<Contact> contactList = new List<Contact>();

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
            try
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();

                if (!ValidationUtility.IsValidName(firstName))
                {
                    throw new InvalidInputException("Invalid First Name");
                }

                // Check duplicate by first name
                if (contactList.Any(c => c.GetFirstName()
                    .Equals(firstName, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Contact Already Exists!");
                    return;
                }

                Contact contact = new Contact();
                contact.SetFirstName(firstName);

                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();

                if (!ValidationUtility.IsValidName(lastName))
                {
                    throw new InvalidInputException("Invalid Last Name");
                }
                contact.SetLastName(lastName);

                Console.WriteLine("Enter Address");
                contact.SetAddress(Console.ReadLine());

                Console.WriteLine("Enter City");
                contact.SetCity(Console.ReadLine());

                Console.WriteLine("Enter State");
                contact.SetState(Console.ReadLine());

                Console.WriteLine("Enter Zip");
                string zip = Console.ReadLine();

                if (!ValidationUtility.IsValidZip(zip))
                {
                    throw new InvalidInputException("Invalid Zip");
                }
                contact.SetZip(zip);

                Console.WriteLine("Enter Phone Number");
                string phone = Console.ReadLine();

                if (!ValidationUtility.IsValidPhoneNumber(phone))
                {
                    throw new InvalidInputException("Invalid Phone Number");
                }
                contact.SetPhoneNumber(phone);

                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();

                if (!ValidationUtility.IsValidEmail(email))
                {
                    throw new InvalidInputException("Invalid Email");
                }
                contact.SetEmail(email);

                // Add contact to list
                contactList.Add(contact);

                Console.WriteLine("Contact Added Successfully!");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        // Mandatory display (not UC)
        public void DisplayContact()
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("No Contact Found");
                return;
            }

            int count = 1;

            foreach (var contact in contactList)
            {
                Console.WriteLine($"\n--- Contact {count} ---");
                Console.WriteLine(contact.ToString());
                count++;
            }
        }

        // UC3
        public void EditContact()
        {
            Console.WriteLine("Enter First Name to Edit Contact");
            string firstName = Console.ReadLine();

            // Search contact by first name
            Contact contact = contactList.FirstOrDefault(c =>
                c.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact Not Found");
                return;
            }

            Console.WriteLine("\nWhat do you want to edit?");
            Console.WriteLine("1. Address");
            Console.WriteLine("2. City");
            Console.WriteLine("3. State");
            Console.WriteLine("4. Zip");
            Console.WriteLine("5. Phone Number");
            Console.WriteLine("6. Email");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        contact.SetAddress(Console.ReadLine());
                        break;
                    case 2:
                        contact.SetCity(Console.ReadLine());
                        break;
                    case 3:
                        contact.SetState(Console.ReadLine());
                        break;
                    case 4:
                        string zip = Console.ReadLine();
                        if (!ValidationUtility.IsValidZip(zip))
                        {
                            throw new InvalidInputException("Invalid Zip");
                        }
                        contact.SetZip(zip);
                        break;
                    case 5:
                        string phone = Console.ReadLine();
                        if (!ValidationUtility.IsValidPhoneNumber(phone))
                        {
                            throw new InvalidInputException("Invalid Phone Number");
                        }
                        contact.SetPhoneNumber(phone);
                        break;
                    case 6:
                        string email = Console.ReadLine();
                        if (!ValidationUtility.IsValidEmail(email))
                        {
                            throw new InvalidInputException("Invalid Email");
                        }
                        contact.SetEmail(email);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        return;
                }

                Console.WriteLine("Contact Updated Successfully!");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        // Delete Contact
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name to Delete Contact");
            string firstName = Console.ReadLine();

            // Remove contact from list
            Contact contact = contactList.FirstOrDefault(c =>
                c.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                contactList.Remove(contact);
                Console.WriteLine("Contact Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
        }

        // method like old file added because menu is calling AddMultipleContacts()
        // this method used to add multiple contacts by asking user how many contacts he wants to add
        public void AddMultipleContacts()
        {
            try
            {
                Console.WriteLine("How Many Contacts You Want to Add?");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("\nEnter Contact " + (i + 1) + " Details");
                    AddContact();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        // UC11 sorting method (menu is calling this method)
        // here we take user choice and sort contacts accordingly using list
        public void SortContactsByChoice()
        {
            try
            {
                Console.WriteLine("Choose Sorting Option");
                Console.WriteLine("1. Sort By First Name");
                Console.WriteLine("2. Sort By City");
                Console.WriteLine("3. Sort By State");
                Console.WriteLine("4. Sort By Zip");

                int choice = Convert.ToInt32(Console.ReadLine());

                // Sorting contacts using generic list
                switch (choice)
                {
                    case 1:
                        contactList = contactList.OrderBy(c => c.GetFirstName()).ToList();
                        break;
                    case 2:
                        contactList = contactList.OrderBy(c => c.GetCity()).ToList();
                        break;
                    case 3:
                        contactList = contactList.OrderBy(c => c.GetState()).ToList();
                        break;
                    case 4:
                        contactList = contactList.OrderBy(c => c.GetZip()).ToList();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        return;
                }

                Console.WriteLine("Contacts Sorted Successfully!");
                DisplayContact();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        // Getter for AddressBookSystem UC8/UC9/UC10 (traversal using list)
        public List<Contact> GetContactList()
        {
            return contactList;
        }
    



 // =============================================================================================
     // ================= MSTest logic methods =================

        public bool AddContactForTest(Contact contact)
        {
            if (!ValidationUtility.IsValidName(contact.GetFirstName()))
            {
                throw new InvalidInputException("Invalid First Name");
            }

            if (contactList.Any(c =>
                c.GetFirstName().Equals(contact.GetFirstName(), StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            contactList.Add(contact);
            return true;
        }

        public bool DeleteContactForTest(string firstName)
        {
            Contact contact = contactList.FirstOrDefault(c =>
                c.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                return false;
            }

            contactList.Remove(contact);
            return true;
        }
    }
}
