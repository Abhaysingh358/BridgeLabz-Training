using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    
    class ShoppingCart
    {
        private Dictionary<string, double> productPrice;
        private List<string> insertionOrder;   // LinkedDictionary simulation

        public ShoppingCart()
        {
            productPrice = new Dictionary<string, double>();
            insertionOrder = new List<string>();
        }

        public void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product price: ");
            double price = double.Parse(Console.ReadLine());

            if (!productPrice.ContainsKey(name))
                insertionOrder.Add(name);

            productPrice[name] = price;

            Console.WriteLine("Product added/updated.");
        }

        public void RemoveProduct()
        {
            Console.Write("Enter product name to remove: ");
            string name = Console.ReadLine();

            if (productPrice.ContainsKey(name))
            {
                productPrice.Remove(name);
                insertionOrder.Remove(name);
                Console.WriteLine("Product removed.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DisplayInOrder()
        {
            Console.WriteLine("\nShopping Cart (Insertion Order):");

            if (productPrice.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            foreach (string name in insertionOrder)
            {
                Console.WriteLine(name + " -> " + productPrice[name]);
            }
        }

        public void DisplaySortedByPrice()
        {
            Console.WriteLine("\nShopping Cart (Sorted By Price):");

            if (productPrice.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            SortedDictionary<double, List<string>> sorted = new 
                SortedDictionary<double, List<string>>();

            foreach (var kv in productPrice)
            {
                string product = kv.Key;
                double price = kv.Value;

                if (!sorted.ContainsKey(price))
                    sorted[price] = new List<string>();

                sorted[price].Add(product);
            }

            foreach (var kv in sorted)
            {
                double price = kv.Key;
                List<string> products = kv.Value;

                foreach (var p in products)
                    Console.WriteLine(p + " -> " + price);
            }
        }

        public void TotalBill()
        {
            double total = 0;

            foreach (var kv in productPrice)
                total += kv.Value;

            Console.WriteLine("\nTotal Bill: " + total);
        }
    }

    class ShoppingCartApp
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("\nShopping Cart Menu");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Display Cart (Insertion Order)");
                Console.WriteLine("4. Display Cart (Sorted By Price)");
                Console.WriteLine("5. Total Bill");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        cart.AddProduct();
                        break;
                    case 2:
                        cart.RemoveProduct();
                        break;
                    case 3:
                        cart.DisplayInOrder();
                        break;
                    case 4:
                        cart.DisplaySortedByPrice();
                        break;
                    case 5:
                        cart.TotalBill();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

}
