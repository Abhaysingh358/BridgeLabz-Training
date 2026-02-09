using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using CsvHelper;
using System.Text.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json;


namespace BridgeLabz.ioprogramming_csharp_practice.scenario_based.AddressBookSystem
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

        // uc 13 write contacts to file (AddressBook.txt) using StreamWriter(FILE  IO)
        public void WriteContactsToFile()
        {
            if (string.IsNullOrEmpty(GetAddressBookName()))
            {
                Console.WriteLine("AddressBook name not set");
                return;
            }


            string filePath = $"{GetAddressBookName()}.AddressBook.txt";
            // importatnt: we do not have to create this file . Stream Writer will
            // automatically create it and update it in in visual studio
            // where should the file created? --> "<YourProjectFolder>\bin\Debug\netX.X\"


            try
            {
                using(StreamWriter writer =  new StreamWriter(filePath))
                {
                    foreach (var Contact in contactList)
                    {
                        writer.WriteLine(Contact.ToString());
                    }
                }

                Console.WriteLine("Contacts Written in AddressBook.txt  Successfully!");

            }
            catch(Exception)
            {
                Console.WriteLine("File Write Error");
            }

        }


        // uc 13 read contacts from file (AddressBook.txt) using StreamReader(FILE  IO)
        public void ReadContactsFromFile()
        {
            if (string.IsNullOrEmpty(GetAddressBookName()))
            {
                Console.WriteLine("AddressBook name not set");
                return;
            }

            string filePath = $"{GetAddressBookName()}.AddressBook.txt";


            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File Not Found");
                    return;
                }

                using(StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception)
            {
                Console.WriteLine("File Read Error");
            }
        }


        // UC-14: Ability to read/write Address Book contacts as CSV file using CsvHelper
        /// <summary>
        /* We will:
           write contacts -> CSV
           read contacts -> CSV
           one file per address book(same idea as UC-13)
           STEP 1: ADD CSVHELPER PACKAGE
           In Visual Studio
           Right-click BridgeLabz project
           Manage NuGet Packages
           Search:
           CsvHelper
           nstall CsvHelper(by Josh Close) */

        /// </summary>


        public void WriteContactsToCsv()
        {
            // file created inside bin/Debug/netX.X/

            if (string.IsNullOrEmpty(GetAddressBookName()))
            {
                Console.WriteLine("AddressBook name not set");
                return;
            }
            // addressbookname.file name like college.Addressbook , home.addressBook
            string filePath = $"{GetAddressBookName()}.AddressBook.csv";

            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.Context.RegisterClassMap<ContactCsvMap>();
                        csv.WriteRecords(contactList);
                    }

                    Console.WriteLine("Contacts Written To CSV  Successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // UC14
        public void ReadContactsFromCsv()
        {
            string filePath = $"{GetAddressBookName()}.AddressBook.csv";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("CSV File Not Found");
                    return;
                }

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<ContactCsvMap>();
                    var records = csv.GetRecords<Contact>().ToList();

                    foreach (var contact in records)
                    {
                        Console.WriteLine(contact.ToString());
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("CSV Read Error");
            }
        }

        // uc 14 ends here


        // UC 15 json file read and write
        public void WriteContactsToJson()
        {
            string filePath = $"{GetAddressBookName()}.AddressBook.json";

            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonData = JsonSerializer.Serialize(contactList, options);
                File.WriteAllText(filePath, jsonData);

                Console.WriteLine("Contacts Written To JSON Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        // UC15
        public void ReadContactsFromJson()
        {
            string filePath = $"{GetAddressBookName()}.AddressBook.json";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("JSON File Not Found");
                    return;
                }

                string jsonData = File.ReadAllText(filePath);
                var contacts = JsonSerializer.Deserialize<List<Contact>>(jsonData);

                if (contacts == null || contacts.Count == 0)
                {
                    Console.WriteLine("No Contacts Found In JSON");
                    return;
                }

                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // UC 15 ends here 



        // UC 16 
        public async Task WriteContactsToJsonServer()
        {
            try
            {
                using HttpClient client = new HttpClient();

                foreach (var contact in contactList)
                {
                    string json = JsonSerializer.Serialize(contact);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    await client.PostAsync("http://localhost:3000/contacts", content);
                }

                Console.WriteLine("Contacts Written To JSON Server Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // UC16
        public async Task ReadContactsFromJsonServer()
        {
            try
            {
                using HttpClient client = new HttpClient();

                string response = await client.GetStringAsync("http://localhost:3000/contacts");

                var contacts = JsonSerializer.Deserialize<List<Contact>>(response);

                if (contacts == null || contacts.Count == 0)
                {
                    Console.WriteLine("No Contacts Found On Server");
                    return;
                }

                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        // uc 16 ends here



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
