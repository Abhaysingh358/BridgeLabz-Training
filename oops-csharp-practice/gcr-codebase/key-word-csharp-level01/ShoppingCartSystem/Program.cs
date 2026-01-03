using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.ShoppingCartSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product(101, "Laptop", 50000, 1);
            Product p2 = new Product(102, "Mouse", 500, 2);


            // using is operator before calling Display
            if (p1 is Product)
            {
                p1.Display();
            }


            if (p2 is Product)
            {
                p2.Display();
            }


            // updating discount using static method
            Product.UpdateDiscount(20);

            // display again after discount update
            if (p1 is Product)
            {
                p1.Display();
            }


            // checking with non-product object
            object obj = "Invalid Object";

            if (obj is Product)
            {
                Console.WriteLine("Object is a Product");
            }
            else
            {
                Console.WriteLine("Object is NOT a Product");
            }

            Product.DisplayTotalProducts();
        }
    }
}
