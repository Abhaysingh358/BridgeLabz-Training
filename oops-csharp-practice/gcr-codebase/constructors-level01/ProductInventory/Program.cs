using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.ProductInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("laptop", 100000);
            Product p2 = new Product("Bulb", 150);

            p1.Display(); p2.Display();

            Product.DisplayTotalProducts();

        }
    }
}
