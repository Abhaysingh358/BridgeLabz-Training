using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    // Base abstract class for all warehouse items
    internal abstract class WarehouseItem
    {
        // Common properties for all warehouse items
        public int ItemId { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        // Constructor (only derived classes can call)
        protected WarehouseItem(int itemId, string name, int quantity, double price)
        {
            ItemId = itemId;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        // Common total value calculation
        public double GetTotalValue()
        {
            return Quantity * Price;
        }

        // Every child class must implement this
        public abstract void DisplayInfo();

        // Strong ToString override
        public override string ToString()
        {
            return $"ID: {ItemId} | Name: {Name} | Qty: {Quantity} | Price: {Price}";
        }
    }
}
