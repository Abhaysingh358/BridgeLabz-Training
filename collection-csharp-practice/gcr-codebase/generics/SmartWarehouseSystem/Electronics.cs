using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    internal class Electronics : WarehouseItem
    {
        public string Brand { get; private set; }
        public int WarrantyMonths { get; private set; }

        public Electronics(int itemId, string name, int quantity, double price, string brand, int warrantyMonths)
            : base(itemId, name, quantity, price)
        {
            Brand = brand;
            WarrantyMonths = warrantyMonths;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Electronics Item -----");
            Console.WriteLine($"Item ID : {ItemId}");
            Console.WriteLine($"Name    : {Name}");
            Console.WriteLine($"Brand   : {Brand}");
            Console.WriteLine($"Quantity : {Quantity}");
            Console.WriteLine($"Price    : {Price}");
            Console.WriteLine($"Warranty  : {WarrantyMonths} Months");
            Console.WriteLine($"Total Value  : {GetTotalValue()}");
        }
    }
}
