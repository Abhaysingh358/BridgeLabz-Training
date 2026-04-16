using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_sorting
{
    //Quick Sort
    // Product class
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return "Product Id: " + Id + "\nName: " + Name + "\nPrice: " + Price;
        }
    }

    internal class ArrangeProductByPrice
    {
        static void QuickSort(Product[] products, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(products, low, high);
                QuickSort(products, low, pi - 1);
                QuickSort(products, pi + 1, high);
            }
        }
        static int Partition(Product[] products, int low, int high)
        {
            double pivot = products[high].Price;
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (products[j].Price < pivot)
                {
                    i++;
                    Product temp = products[i];
                    products[i] = products[j];
                    products[j] = temp;
                }
            }
            Product temp1 = products[i + 1];
            products[i + 1] = products[high];
            products[high] = temp1;

            return i + 1;
        }
        static void Main(string[] args)
        {
            Product[] products = new Product[5];

            for (int i = 0; i < products.Length; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                double price = Convert.ToDouble(Console.ReadLine());
                products[i] = new Product(id, name, price);
            }
            Console.WriteLine("\nBefore Sorting");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }
            QuickSort(products, 0, products.Length - 1);

            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }
        }
    }
}

