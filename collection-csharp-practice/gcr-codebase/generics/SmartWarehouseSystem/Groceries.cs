using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    internal class Groceries : WarehouseItem
    {
        public DateTime ExpiryDate { get; private set; }
        public string Category { get; private set; }   // example: Dairy, Vegetables, Snacks

        public Groceries(int itemId, string name, int quantity, double price, DateTime expiryDate, string category)
            : base(itemId, name, quantity, price)
        {
            ExpiryDate = expiryDate;
            Category = category;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Grocery Item -----");
            Console.WriteLine($"Item ID        : {ItemId}");
            Console.WriteLine($"Name           : {Name}");
            Console.WriteLine($"Category       : {Category}");
            Console.WriteLine($"Quantity       : {Quantity}");
            Console.WriteLine($"Price          : {Price}");
            Console.WriteLine($"Expiry Date    : {ExpiryDate.ToShortDateString()}");
            Console.WriteLine($"Total Value    : {GetTotalValue()}");
        }
    }
}

