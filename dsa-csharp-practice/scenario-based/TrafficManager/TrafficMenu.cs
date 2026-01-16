using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{
    internal class TrafficMenu
    {
        private ITrafficUtility utility = new TrafficUtility();
        private int choice;

        // this method displays menu and takes user choice
        public void ShowMenu()
        {
            do
            {
                Console.WriteLine("\n---------- Traffic Manager Menu ----------");
                Console.WriteLine("1. Enter Vehicle");
                Console.WriteLine("2. Exit Vehicle");
                Console.WriteLine("3. Display Roundabout");
                Console.WriteLine("4. Display Waiting Queue");
                Console.WriteLine("5. Display Full State");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.EnterVehicle();
                        break;

                    case 2:
                        utility.ExitVehicle();
                        break;

                    case 3:
                        utility.DisplayRoundAbout();
                        break;

                    case 4:
                        utility.DisplayWaitingQueue();
                        break;

                    case 5:
                        utility.DisplayAllState();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Traffic Manager...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again");
                        break;
                }

            } while (choice != 0);
        }
    }
}
