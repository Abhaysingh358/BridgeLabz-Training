using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.AddressBookSystem
{
        internal class AddressMenu
        {
            private AddressBookUtils utils = new AddressBookUtils();
            private int choice;
            public void ShowMenu()
            {
                

                do
                {
                    Console.WriteLine("\n-------- Address Book Menu --------");
                    Console.WriteLine("1. UC2 - Add Contact");
                    Console.WriteLine("2. Display Contact");
                    Console.WriteLine("0. Exit");
                    

                    Console.WriteLine("Enter your choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            utils.AddContact();
                            break;

                        case 2:
                            utils.DisplayContact();
                            return;

                        case 0:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                } while (choice != 0);
            }
        }
    }

