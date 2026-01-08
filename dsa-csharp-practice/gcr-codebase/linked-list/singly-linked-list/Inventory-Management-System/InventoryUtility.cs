using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Inventory_Management_System
{
    internal class InventoryUtility
    {
        public InventoryItem CreateItem()
        {
            Console.Write("Item ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Item Name: ");
            string name = Console.ReadLine();

            Console.Write("Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            return new InventoryItem(id, name, qty, price);
        }

        public void Print(InventoryItem item)
        {
            Console.WriteLine($"ID:{item.ItemId}, Name:{item.ItemName}, Qty:{item.Quantity}, Price:{item.Price}");
        }
    }
}
