using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.E_Commerce
{
    class Menu
    {
        Product[] products = new Product[3];
        int index = 0;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("1.Electronics");
                Console.WriteLine("2.Clothing");
                Console.WriteLine("3.Groceries");
                Console.WriteLine("4.Display Final Price");
                Console.WriteLine("5.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        AddProduct(new Electronics()); 
                        break;
                    case 2: 
                        AddProduct(new Clothing()); 
                        break;
                    case 3: 
                        AddProduct(new Groceries()); 
                        break;
                    case 4: 
                        DisplayFinalPrice(); 
                        break;
                    case 5: 
                        return;
                }
            }
        }

        void AddProduct(Product p)
        {
            if (index >= products.Length) return;

            Console.Write("Id: ");
            p.SetProductId(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Name: ");
            p.SetName(Console.ReadLine());
            Console.Write("Price: ");
            p.SetPrice(Convert.ToDouble(Console.ReadLine()));

            products[index++] = p;
        }

        void DisplayFinalPrice()
        {
            for (int i = 0; i < index; i++)
            {
                Product p = products[i];
                double tax = 0;

                if (p is ITaxable t)
                    tax = t.CalculateTax();

                double finalPrice = p.Price + tax - p.CalculateDiscount();
                Console.WriteLine(p.Name + " Final Price: " + finalPrice);
            }
        }
    }
}
