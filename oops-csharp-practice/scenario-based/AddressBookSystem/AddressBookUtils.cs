using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressBookUtils : IAddressBook
    {
        AddressBook addressBook = new AddressBook();

        public void AddContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter First Name");
            contact.SetFirstName(Console.ReadLine());

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

            Contact[] contacts = new Contact[1];
            contacts[0] = contact;

            addressBook.SetContacts(contacts);
            addressBook.SetCount(1);

            Console.WriteLine("Contact Added Successfully!");
        }

        public void DisplayContact()
        {
            if (addressBook.GetContacts() == null)
            {
                Console.WriteLine("No Contact Found");
                return;
            }

            Console.WriteLine(addressBook.GetContacts()[0].ToString());
        }
    }
}
