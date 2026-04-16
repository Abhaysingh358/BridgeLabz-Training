using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.chsarp_Encapsulation_abstraction.ONline_Food_Dilivery
{
    internal class Menu
    {
        FoodItem[] items = new FoodItem[3]; // array used
        int index = 0;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Veg ");
                Console.WriteLine("2.Non-Veg ");
                Console.WriteLine("3.Show Bill ");
                Console.WriteLine("4.Exit ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddItem(new VegItem()); break;
                    case 2: AddItem(new NonVegItem()); break;
                    case 3: ShowBill(); break;
                    case 4: return;
                }
            }
        }

        void AddItem(FoodItem item)
        {
            if (index >= items.Length) return;

            Console.Write("Name: ");
            item.SetItemName(Console.ReadLine());

            Console.Write("Price: ");
            item.SetPrice(double.Parse(Console.ReadLine()));

            Console.Write("Qty: ");
            item.SetQuantity(int.Parse(Console.ReadLine()));

            items[index++] = item;
        }

        void ShowBill()
        {
            for (int i = 0; i < index; i++)
            {
                FoodItem item = items[i];
                double total = item.CalculateTotalPrice();
                double discount = 0;

                if (item is IDiscountable d)
                    discount = d.ApplyDiscount();

                Console.WriteLine(item.ItemName + " Pay: " + (total - discount));
            }
        }
    }
}
