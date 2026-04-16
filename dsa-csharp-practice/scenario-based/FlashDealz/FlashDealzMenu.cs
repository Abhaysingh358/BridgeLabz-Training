using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FlashDealz
{
    internal class FlashDealzMenu
    {
        private IFlashDealzUtility utility;
        private int choice;

        public FlashDealzMenu()
        {
            utility = new FlashDealzUtility();
        }

        public void ShowMenu()
        {
            do
            {
                Console.WriteLine("\n---------- FlashDealz Menu ----------");
                Console.WriteLine("1. Add Product (Auto Sort)");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Change Discount of Product");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddProduct();
                        break;

                    case 2:
                        utility.DisplayProducts();
                        break;

                    case 3:
                        utility.ChangeDiscount();
                        break;

                    case 0:
                        Console.WriteLine("Exiting FlashDealz...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}








