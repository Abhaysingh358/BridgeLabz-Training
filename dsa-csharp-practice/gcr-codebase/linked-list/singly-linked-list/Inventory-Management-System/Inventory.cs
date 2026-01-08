using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.LinkedList.SinglyLinkedList.Inventory_Management_System
{
    internal class InventoryItem
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;
        public InventoryItem Next;

        public InventoryItem(int itemId, string itemName, int quantity, double price)
        {
            ItemId = itemId;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }
}
