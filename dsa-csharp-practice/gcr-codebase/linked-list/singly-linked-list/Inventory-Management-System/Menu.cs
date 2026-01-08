using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Inventory_Management_System
{
    internal class Menu
    {
        private InventoryLinkedList list = new InventoryLinkedList();
        private InventoryUtility util = new InventoryUtility();

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1.AddBegin 2.AddEnd 3.AddPos 4.Remove 5.UpdateQty 6.SearchId 7.SearchName 8.Total 9.SortName 10.SortPrice 11.Display 0.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        list.AddAtBeginning(util.CreateItem());
                        break;

                    case 2:
                        list.AddAtEnd(util.CreateItem());
                        break;

                    case 3:
                        Console.Write("Position: ");
                        list.AddAtPosition(util.CreateItem());
                        break;

                    case 4:
                        Console.Write("Item ID: ");
                        list.RemoveById(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Item ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("New Quantity: ");
                        list.UpdateQuantity(id, int.Parse(Console.ReadLine()));
                        break;

                    case 6:
                        Console.Write("Item ID: ");
                        InventoryItem byId = list.SearchById(int.Parse(Console.ReadLine()));
                        if (byId != null) util.Print(byId);
                        break;

                    case 7:
                        Console.Write("Item Name: ");
                        InventoryItem byName = list.SearchByName(Console.ReadLine());
                        if (byName != null) util.Print(byName);
                        break;

                    case 8:
                        Console.WriteLine("Total Value: " + list.CalculateTotalValue());
                        break;

                    case 9:
                        Console.Write("1.Asc 2.Desc: ");
                        list.SortByName(int.Parse(Console.ReadLine()) == 1);
                        break;

                    case 10:
                        Console.Write("1.Asc 2.Desc: ");
                        list.SortByPrice(int.Parse(Console.ReadLine()) == 1);
                        break;

                    case 11:
                        list.DisplayAll(util);
                        break;
                }

            } while (choice != 0);
        }
    }
}
