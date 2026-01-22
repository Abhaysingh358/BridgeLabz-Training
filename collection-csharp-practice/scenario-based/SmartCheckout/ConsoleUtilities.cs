using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.scenario_based.SmartCheckout
{
    using System;

    public class ConsoleUtilities : IUtilities
    {
        public Items TakeItemInput()
        {
            Console.Write("Enter Item Name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Stock: ");
            int stock = int.Parse(Console.ReadLine());

            return new Items(itemName, price, stock);
        }

        public Customer TakeCustomerInput()
        {
            Console.Write("Enter Customer Id: ");
            int customerId = int.Parse(Console.ReadLine());

            Customer customer = new Customer(customerId);

            Console.Write("How many items customer wants to buy?: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nItem {i + 1}:");

                Console.Write("Enter Item Name: ");
                string itemName = Console.ReadLine();

                Console.Write("Enter Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                customer.AddItem(itemName, qty);
            }

            return customer;
        }
    }


}
