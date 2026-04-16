using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.scenario_based.SmartCheckout
{
    using System;

    public class Menu
    {
        private SmartCheckoutService checkout;
        private IUtilities utilities;

       

        public void Start()
        {
            checkout = new SmartCheckoutService();
            utilities = new ConsoleUtilities();
            while (true)
            {
                ShowMenu();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Items item = utilities.TakeItemInput();
                        checkout.AddItemToStore(item);
                        break;

                    case 2:
                        Customer customer = utilities.TakeCustomerInput();
                        checkout.AddCustomer(customer);
                        break;

                    case 3:
                        checkout.ViewNextCustomer();
                        break;

                    case 4:
                        checkout.CheckoutNextCustomer();
                        break;

                    case 5:
                        checkout.DisplayStock();
                        break;

                    case 6:
                        Console.WriteLine("Exiting... Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("   SmartCheckout - Supermarket System");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Add Item to Store");
            Console.WriteLine("2. Add Customer to Queue");
            Console.WriteLine("3. View Next Customer");
            Console.WriteLine("4. Checkout Next Customer");
            Console.WriteLine("5. Display Stock");
            Console.WriteLine("6. Exit");
            Console.WriteLine("====================================");
        }
    }

}
