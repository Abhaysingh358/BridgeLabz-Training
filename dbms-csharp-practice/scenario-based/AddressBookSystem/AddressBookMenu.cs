using System;
using System.Threading.Tasks;

namespace BridgeLabz.dbms_csharp_practice.scenario_based.AddressBookSystem
{
    internal class AddressMenu
    {
        private AddressBookSystem system = new AddressBookSystem();
        private int choice;

        public async Task ShowMenu()
        {
            do
            {
                Console.WriteLine("\n-------- Address Book System Menu (UC-6) --------");
                Console.WriteLine("1. Add AddressBook");
                Console.WriteLine("2. Select AddressBook");
                Console.WriteLine("3. Display AddressBooks");
                Console.WriteLine("4. Search Person By City (UC-8)");
                Console.WriteLine("5. Search Person By State (UC-8)");
                Console.WriteLine("6. View Persons By City (UC-9)");
                Console.WriteLine("7. View Persons By State (UC-9)");
                Console.WriteLine("8. Count By City (UC-10)");
                Console.WriteLine("9. Count By State (UC-10)");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        system.AddAddressBook();
                        break;

                    case 2:
                        AddressBook book = system.SelectAddressBook();
                        if (book != null)
                        {
                            await ShowAddressBookMenu(book);
                        }
                        break;

                    case 3:
                        system.DisplayAddressBooks();
                        break;

                    case 4:
                        system.SearchPersonByCity();
                        break;

                    case 5:
                        system.SearchPersonByState();
                        break;

                    case 6:
                        system.ViewPersonsByCity();
                        break;

                    case 7:
                        system.ViewPersonsByState();
                        break;

                    case 8:
                        system.CountByCity();
                        break;

                    case 9:
                        system.CountByState();
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 0);
        }

        public async Task ShowAddressBookMenu(AddressBook utils)
        {
            int choice2;

            do
            {

                Console.WriteLine("\n-------- Address Book Menu --------");
                Console.WriteLine("1. Display Contact");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Sort Contacts (UC-11)");
                Console.WriteLine("6. Write Contacts To File (UC-13)");
                Console.WriteLine("7. Read Contacts From File (UC-13)");
                Console.WriteLine("8. Write Contacts To CSV (UC-14)");
                Console.WriteLine("9. Read Contacts From CSV (UC-14)");
                Console.WriteLine("10. Write Contacts To JSON (UC-15)");
                Console.WriteLine("11. Read Contacts From JSON (UC-15)");
                Console.WriteLine("12. Write Contacts To JSON Server (UC-16)");
                Console.WriteLine("13. Read Contacts From JSON Server (UC-16)");
                Console.WriteLine("14. Save Contacts To Database (UC-18)\r\n");
                Console.WriteLine("15. Read Contacts From Database (UC-18)");
                Console.WriteLine("0. Back");

                Console.WriteLine("Enter your choice");
                choice2 = int.Parse(Console.ReadLine());

                switch (choice2)
                {
                    case 1:
                        utils.DisplayContact();
                        break;

                    case 2:
                        utils.AddMultipleContacts();
                        break;

                    case 3:
                        utils.EditContact();
                        break;

                    case 4:
                        utils.DeleteContact();
                        break;

                    case 5:
                        utils.SortContactsByChoice();
                        break;

                    case 6:
                        utils.WriteContactsToFile();
                        break;

                    case 7:
                        utils.ReadContactsFromFile();
                        break;

                    case 8:
                        await utils.WriteContactsToCsvAsync();
                        break;

                    case 9:
                        await utils.ReadContactsFromCsvAsync();
                        break;

                    case 10:
                        await utils.WriteContactsToJsonAsync();
                        break;

                    case 11:
                        await utils.ReadContactsFromJsonAsync();
                        break;

                    case 12:
                        await utils.WriteContactsToJsonServer();
                        break;

                    case 13:
                        await utils.ReadContactsFromJsonServer();
                        break;

                    case 14:
                        await utils.SaveToDatabase();
                        break;

                    case 15:
                        await utils.ReadFromDatabase();
                        break;


                    case 0:
                        Console.WriteLine("Back");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice2 != 0);
        }
    }
}
