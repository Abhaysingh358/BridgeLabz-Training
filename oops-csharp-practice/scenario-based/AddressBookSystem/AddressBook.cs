using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBook : IAddressBook
    {
        private Contact[] contacts = new Contact[50];
        private int Count = 0;

        // getters for contact arrays uc8
        public Contact[] GetContacts()
        {
            return contacts;
        }

        // getters for count for uc8
        public int GetCount()
        {
            return Count;
        }


        // Method to Contacts
        public void AddContact()
        {
            if (Count >= contacts.Length)
            {
                Console.WriteLine("AddressBook is full!");
                return;
            }

            Contact contact = new Contact();

            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();


            //uc7 applying in AddContact Sothat no duplicates value will be takein in same address book 

            if (IsDuplicate(firstName, lastName))
            {
                Console.WriteLine("Duplicate Contact Found! Cannot Add.");
                return;
            }
            // code end for applying uc7

            contact.SetFirstName(firstName);
            contact.SetLastName(lastName);


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

            contacts[Count] = contact;
            Count++;

            Console.WriteLine("Contact Added Successfully!");
        }



        // method to edit contact and in which i gave choice like what the-
        // user wants to edit in Contacts' Attributes
        public void EditContact()
        {
            if (Count == 0)
            {
                Console.WriteLine("No Contact Found");
                return;
            }

            Console.WriteLine("Enter First Name to Edit Contact");
            string name = Console.ReadLine().ToLower();

            for (int i = 0; i < Count; i++)
            {
                string savedName = contacts[i].GetFirstName().ToLower();

                if (savedName.Equals(name))
                {
                    // while loop for edititng until usesr wants 
                    while (true)
                    {
                        Console.WriteLine("\n1. Edit First Name");
                        Console.WriteLine("2. Edit Last Name");
                        Console.WriteLine("3. Edit Address");
                        Console.WriteLine("4. Edit City");
                        Console.WriteLine("5. Edit State");
                        Console.WriteLine("6. Edit Zip");
                        Console.WriteLine("7. Edit Phone Number");
                        Console.WriteLine("8. Edit Email");
                        Console.WriteLine("0. Exit Edit Menu");

                        Console.WriteLine("Enter Choice");
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 0)
                        {
                            Console.WriteLine("Edit Completed");
                            return;
                        }
                        else if (choice == 1)
                        {
                            Console.WriteLine("Enter New First Name");
                            contacts[i].SetFirstName(Console.ReadLine());
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Enter New Last Name");
                            contacts[i].SetLastName(Console.ReadLine());
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("Enter New Address");
                            contacts[i].SetAddress(Console.ReadLine());
                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("Enter New City");
                            contacts[i].SetCity(Console.ReadLine());
                        }
                        else if (choice == 5)
                        {
                            Console.WriteLine("Enter New State");
                            contacts[i].SetState(Console.ReadLine());
                        }
                        else if (choice == 6)
                        {
                            Console.WriteLine("Enter New Zip");
                            contacts[i].SetZip(Console.ReadLine());
                        }
                        else if (choice == 7)
                        {
                            Console.WriteLine("Enter New Phone Number");
                            contacts[i].SetPhoneNumber(Console.ReadLine());
                        }
                        else if (choice == 8)
                        {
                            Console.WriteLine("Enter New Email");
                            contacts[i].SetEmail(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");
                        }

                        Console.WriteLine("Contact Updated Successfully!");
                    }
                }
            }

            Console.WriteLine("Contact Not Found");
        }


        // Method to Delete a Contact
        public void DeleteContact()
        {
            if (Count == 0)
            {
                Console.WriteLine("No Contact Found");
                return;
            }

            Console.WriteLine("Enter First Name to Delete Contact");
            string name = Console.ReadLine().ToLower();

            for (int i = 0; i < Count; i++)
            {
                string savedName = contacts[i].GetFirstName().ToLower();

                if (savedName.Equals(name))
                {
                    //if name matched  then use for loop from index j=i and and assign the next index value -
                    // at previous index
                    for (int j = i; j < Count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[Count - 1] = null;
                    Count--;

                    Console.WriteLine("Contact Deleted Successfully!");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }




        // UC5 to Add Multiple persons in address book
        public void AddMultipleContacts()
        {
            int choice;

            do
            {
                AddContact();

                Console.WriteLine("Press 1 to Add More Contact OR 0 to Exit");
                choice = int.Parse(Console.ReadLine());

            } while (choice != 0);
        }

        // Uc7 method to check first and last name is different
        public bool IsDuplicate(string firstName , string lastName)
        {
            for (int i = 0; i < Count; i++)
            {
                if (contacts[i].GetFirstName().ToLower().Equals(firstName.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

       
        // Display The Contact
        public void DisplayContact()
        {
            if (Count == 0)
            {
                Console.WriteLine("No Contact Found");
                return;
            }

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(contacts[i].ToString());
                Console.WriteLine();
            }
        }
    }
}
