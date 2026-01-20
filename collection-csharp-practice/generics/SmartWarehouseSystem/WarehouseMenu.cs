using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    internal class WarehouseMenu
    {
        private IWarehouseUtility utility;

        public void Start()
        {
            utility = new WarehouseUtility();   
            int choice;

            do
            {
                Console.WriteLine("\n=========== SMART WAREHOUSE MENU ===========");
                Console.WriteLine("1. Add Electronics Item");
                Console.WriteLine("2. Add Grocery Item");
                Console.WriteLine("3. Add Furniture Item");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddElectronicsItem();
                        break;

                    case 2:
                        utility.AddGroceryItem();
                        break;

                    case 3:
                        utility.AddFurnitureItem();
                        break;

                    case 4:
                        utility.DisplayAllItems();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}

