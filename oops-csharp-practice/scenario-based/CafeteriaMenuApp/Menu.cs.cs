using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.oops_csharp_practice.scenario_based.CafeteriaMenuApp
{
    internal class Menu
    {

        static string[] items = { "Masala Dosa", "Samosa", "Pastry", "Maggie", "Pizza", "Burger", "Aloo Parantha", "Momos", "Pasta", "Chowmeen" };
        static int[] Price = { 100, 20, 50, 30, 150, 80, 50, 50, 110, 70 };

        public void Display()
        {
            Console.WriteLine("Items List with price :");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]} --> {Price[i]} rs.");
            }
        }

        public string Order(string items, int price)
        {
            Console.WriteLine("Enter quantity you need : like 1 plate , 2 plate");
            int quantity = int.Parse(Console.ReadLine());

            return $"You ordered {quantity} of {items}, with price {price * quantity} ";

        }

       // method to orders multiple orders 
        public void OrderMultipleItems()
        {
            int totalPrice = 0;

            string more = "y";

            while (more == "y")
            {
                Console.WriteLine("Choose item number to order:");
                int choice = int.Parse(Console.ReadLine());

                if (choice >= 1 && choice <= items.Length)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = int.Parse(Console.ReadLine());

                    int TotalItem = Price[choice - 1] * quantity;

                    Console.WriteLine($"Added total = {TotalItem} Rs.");

                    totalPrice += TotalItem;
                }
                else
                {
                    Console.WriteLine("Invalid item number.");
                }

                Console.WriteLine("Do you want to order another item? (y/n)");
                more = Console.ReadLine().ToLower();
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Your Total Bill Amount = " + totalPrice + " Rs.");
            Console.WriteLine("-------------------------------------------------");
        }
    

        // user can select food 

        public void Choice()
        {
            Console.WriteLine("Choose what you want to have . Enter the number according to the menu display above");
            int selectItem = int.Parse(Console.ReadLine());

            switch (selectItem)
            {
                case 1:
                    Console.WriteLine(Order(items[0], Price[0]));
                    break;

                case 2:
                    Console.WriteLine(Order(items[1], Price[1]));
                    break;

                case 3:
                    Console.WriteLine(Order(items[2], Price[2]));

                    break;

                case 4:
                    Console.WriteLine(Order(items[3], Price[3]));
                    break;

                case 5:
                    Console.WriteLine(Order(items[4], Price[4]));
                    break;

                case 6:
                    Console.WriteLine(Order(items[5], Price[5]));
                    break;

                case 7:
                    Console.WriteLine(Order(items[6], Price[6]));
                    break;
                case 8:
                    Console.WriteLine(Order(items[7], Price[7]));
                    break;

                case 9:
                    Console.WriteLine(Order(items[8], Price[8]));
                    break;

                case 10:
                    Console.WriteLine(Order(items[9], Price[9]));
                    break;

                default:
                    Console.WriteLine("we do not have available this item . kindly choose in among given options");
                    break;
            }
        }

        // calling all methods to run program
        public void App()
        {
            Display();

            Console.WriteLine("Do you want to order multiple items? (y/n)");
            string opt = Console.ReadLine().ToLower();

            if (opt == "y")
            {
                OrderMultipleItems();
            }
            else
            {
                Choice();
            }
        }

        //main program
        static void Main(string[] args)
        {
            Menu c = new Menu();
            c.App();

        }

    }
}
