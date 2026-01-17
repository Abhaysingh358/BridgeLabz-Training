using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FlashDealz
{
    internal class FlashDealzUtility : IFlashDealzUtility
    {
        private ProductList productList = new ProductList();

        public void AddProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marked Price: ");
            double markedPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Discount Percentage: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            Product product = new Product(name, markedPrice, discount);

            //  AddProduct automatically sorts inside ProductList
            productList.AddProduct(product);

            Console.WriteLine("\n Product Added Successfully (Auto Sorted)\n");
        }

        public void DisplayProducts()
        {
            productList.DisplayProducts();
        }

        public void ChangeDiscount()
        {
            if (productList.IsEmpty())
            {
                Console.WriteLine("Product list is empty.");
                return;
            }

            Console.Write("Enter Product Name to change discount: ");
            string name = Console.ReadLine();

            Console.Write("Enter New Discount Percentage: ");
            double newDiscount = Convert.ToDouble(Console.ReadLine());

            bool result = productList.UpdateDiscountByName(name, newDiscount);

            if (result)
            {
                Console.WriteLine("\n Discount Updated Successfully (Auto Sorted)\n");
            }
            else
            {
                Console.WriteLine("\nProduct Not Found\n");
            }
        }
    }
}

