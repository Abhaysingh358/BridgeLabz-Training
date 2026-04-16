using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.class_modeling_and_diagram.csharp_modeling
{
    internal class Ecommerce
    {
        // Main method
        static void Main(string[] args)
        {
            // Creating customer
            Customers c = new Customers("Ankit");
            // Placing order
            Order o = c.PlaceOrder();
            // Adding products to order
            o.AddProduct(new Product("Laptop"));
            o.Display();
        }
    }

    class Customers
    {
        public string Name;
        public Customers(string name)
        {
            Name = name;
        }
        // Method to place order
        public Order PlaceOrder()
        {
            return new Order();
        }
    }

    class Order
    {
        Product[] Products = new Product[5];
        int i = 0;

        public void AddProduct(Product product)
        {
            Products[i++] = product;
        }
        // Method to display ordered products
        public void Display()
        {
            Console.WriteLine("Ordered");
            for (int j = 0; j < i; j++)
                Console.WriteLine(Products[j].Name);
        }
    }

    class Product
    {
        // Product name
        public string Name;
        public Product(string name)
        {
            Name = name;
        }
    }
}

