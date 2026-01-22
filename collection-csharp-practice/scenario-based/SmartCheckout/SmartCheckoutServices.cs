using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.scenario_based.SmartCheckout
{

    public class SmartCheckoutService
    {
        private Queue<Customer> customerQueue;
        private Dictionary<string, Items> itemMap;

        public SmartCheckoutService()
        {
            customerQueue = new Queue<Customer>();
            itemMap = new Dictionary<string, Items>();
        }

        // Add item into HashMap (Dictionary)
        public void AddItemToStore(Items item)
        {
            itemMap[item.ItemName] = item;
            Console.WriteLine($"Item added/updated: {item.ItemName}");
        }

        // Add customer into Queue
        public void AddCustomer(Customer customer)
        {
            customerQueue.Enqueue(customer);
            Console.WriteLine($"Customer {customer.CustomerId} added to queue.");
        }

        // View who is next (optional)
        public void ViewNextCustomer()
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("No customers in queue.");
                return;
            }

            Console.WriteLine($"Next Customer: {customerQueue.Peek().CustomerId}");
        }

        // Remove customer + billing + fetch price + update stock
        public void CheckoutNextCustomer()
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("Queue is empty. No customer to checkout.");
                return;
            }

            Customer customer = customerQueue.Dequeue();
            Console.WriteLine($"\n--- Checking out Customer {customer.CustomerId} ---");

            double totalBill = 0;

            foreach (CustomerItem custItem in customer.Items)
            {
                // Fetch item from map
                if (!itemMap.ContainsKey(custItem.ItemName))
                {
                    Console.WriteLine($"Item not found: {custItem.ItemName}");
                    continue;
                }

                Items storeItem = itemMap[custItem.ItemName];

                // Stock check
                if (storeItem.Stock < custItem.Quantity)
                {
                    Console.WriteLine($"Insufficient stock for {custItem.ItemName}. Available: {storeItem.Stock}");
                    continue;
                }

                // Calculate price
                double itemCost = storeItem.Price * custItem.Quantity;
                totalBill += itemCost;

                //Update stock
                storeItem.Stock -= custItem.Quantity;

                Console.WriteLine($"{custItem.ItemName} x {custItem.Quantity} = {itemCost}");
            }

            Console.WriteLine($"Total Bill: {totalBill}");
            Console.WriteLine("--- Checkout Complete ---\n");
        }

        // Display stock (optional but very useful)
        public void DisplayStock()
        {
            Console.WriteLine("\n--- Current Stock ---");
            foreach (var pair in itemMap)
            {
                Items item = pair.Value;
                Console.WriteLine($"{item.ItemName} | Price: {item.Price} | Stock: {item.Stock}");
            }
            Console.WriteLine("----------------------\n");
        }
    }

}
