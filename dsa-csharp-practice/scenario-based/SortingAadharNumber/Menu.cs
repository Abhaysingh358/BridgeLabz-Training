using BridgeLabz.gcr_codebase.DSA.scenario_based.WoodenRodSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.SortingAadharNumber
{
    public class Menu
    {
        private IAadharUtility utility;

        public void ShowMenu()
        {
            utility = new AadharUtils();
            int choice;

            do
            {
                Console.WriteLine("\n===== AADHAR SORTING SYSTEM =====");
                Console.WriteLine("1. Add Aadhar Entry");
                Console.WriteLine("2. Display All Entries");
                Console.WriteLine("3. Sort Aadhar Numbers (Radix Sort)");
                Console.WriteLine("4. Search Aadhar (Binary Search)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddEntry();
                        break;

                    case 2:
                        utility.DisplayAll();
                        break;

                    case 3:
                        utility.RadixSort();
                        break;

                    case 4:
                        utility.BinarySearch();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }

            } while (choice != 0);
        }
    }

}
