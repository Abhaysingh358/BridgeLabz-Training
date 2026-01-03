using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.ProductInventory
{
    internal class Product
    {
        string ProductName;
        double Price;
        static int totalProducts = 0;

        public Product(string ProductName, double Price)
        {
            this.ProductName = ProductName;
            this.Price = Price;
            totalProducts++;
        }


        public void Display()
        {
            Console.WriteLine("Details Of Product");
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Price Name : {Price}");

        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products : {totalProducts}");
        }



    }
}
