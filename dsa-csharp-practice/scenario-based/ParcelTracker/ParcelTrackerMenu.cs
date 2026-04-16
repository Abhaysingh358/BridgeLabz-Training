using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ParcelTracker
{
    internal class ParcelTrackerMenu
    {
        IParcelTracker Tracker;
        public void Start()
        {
            Tracker = new ParcelTrackerSystem();

            while (true)
            {
                Console.WriteLine("------------------Welcome to Parcel Tracking Services--------------------");
                Console.WriteLine("1. Add Parcel Details");
                Console.WriteLine("2. Add Parcel CheckPoint (Update Status)");
                Console.WriteLine("3. Display Parcel Details");
                Console.WriteLine("4. Display Parcel Tracking");
                Console.WriteLine("5. Show Current Status");
                Console.WriteLine("6. Exit");

                Console.Write("Enter Your Choice : ");
                string input = Console.ReadLine();
                int choice;

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Tracker.AddParcelDetails();
                        break;

                    case 2:
                        Tracker.AddParcelCheckPoint();
                        break;

                    case 3:
                        Tracker.DisplayParcelDetails();
                        break;

                    case 4:
                        Tracker.DisplayParcelTracking();
                        break;
                    case 5:
                        Tracker.ShowCurrentStatus();
                        break;

                    case 6:
                        Console.WriteLine("Exiting Parcel Tracker...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Choose valid options (1 to 6)");
                        break;
                }
            }
        }
    }
}
