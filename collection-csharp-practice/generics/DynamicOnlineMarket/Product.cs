using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.DynamicOnlineMarket
{       
    // Generic Product class restricted to only Category types
    internal class Product<TCategory> : ICatalogItem where TCategory : ICategory
    {
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public double Price { get; private set; }

        public TCategory Category { get; private set; }

        public Product(int productId, string productName, double price, TCategory category)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Category = category;
        }

        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("----- Product Details -----");
            Console.WriteLine("Product ID  : " + ProductId);
            Console.WriteLine("Name       : " + ProductName);
            Console.WriteLine("Category   : " + Category.CategoryName);
            Console.WriteLine("Price     : " + Price);
        }

        public void Display()
        {
            DisplayProduct();
        }
    }
}
