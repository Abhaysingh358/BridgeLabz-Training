using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.ShoppingCartSystem
{
    internal class Product
    {

        static double Discount = 10;
        static int TotalProducts = 0;

        readonly int ProductID;

        string ProductName;
        double Price;
        int Quantity;


        public Product(int productId, string productName, double price, int quantity)
        {
            this.ProductID = productId;
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
            TotalProducts++;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products : {TotalProducts}");
        }


        public void Display()
        {
            Console.WriteLine("Product Details");
            Console.WriteLine($"Product ID  : {ProductID}");
            Console.WriteLine($"Name  : {ProductName}");
            Console.WriteLine($"Price  : {Price}");
            Console.WriteLine($"Quantity : {Quantity}");
            Console.WriteLine($"Discount (%) : {Discount}");
            Console.WriteLine();
        }
    }
}
