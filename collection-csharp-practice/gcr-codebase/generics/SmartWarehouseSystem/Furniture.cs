using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.SmartWarehouseSystem
{
    internal class Furniture : WarehouseItem
    {
        public string Material { get; private set; }     // example: Wood, Metal, Plastic
        public string Dimensions { get; private set; }   // example: 6ft x 3ft

        public Furniture(int itemId, string name, int quantity, double price, string material, string dimensions)
            : base(itemId, name, quantity, price)
        {
            Material = material;
            Dimensions = dimensions;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("----- Furniture Item -----");
            Console.WriteLine($"Item ID    : {ItemId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Material   : {Material}");
            Console.WriteLine($"Dimensions : {Dimensions}");
            Console.WriteLine($"Quantity   : {Quantity}");
            Console.WriteLine($"Price      : {Price}");
            Console.WriteLine($"Total Value : {GetTotalValue()}");
        }
    }
}
