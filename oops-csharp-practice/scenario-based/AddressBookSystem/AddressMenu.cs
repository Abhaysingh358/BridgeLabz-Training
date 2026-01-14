using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.AddressBookSystem
{
        internal class AddressMenu
        {
            private AddressBook utils = new AddressBook();
            private int choice;
            public void ShowMenu()
            {
                

                do
                {
                    Console.WriteLine("\n-------- Address Book Menu --------");
                    Console.WriteLine("1.Display Contact");
                    Console.WriteLine("2. Add Contact(UC-2)");
                    Console.WriteLine("3.Edit Contact (UC-3)");
                    Console.WriteLine("4.Delete Contact (UC-4)");

                    Console.WriteLine("0. Exit");
                    

                    Console.WriteLine("Enter your choice");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            utils.DisplayContact();
                            break;

                        case 2:
                            utils.AddContact();
                            break;

                        case 3:
                            utils.EditContact();
                            break;

                        case 4 :
                            utils.DeleteContact();
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
        }
    }

