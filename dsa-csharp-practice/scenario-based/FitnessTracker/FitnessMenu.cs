using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FitnessTracker
{
    internal class FitnessMenu
    {
        private IFitnessTracker tracker;

       
        // Runs the menu driven program
        public void Start()
        {
            tracker = new FitnessUtils();
            int choice;

            do
            {
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Enter Daily Steps (Day wise)");
                Console.WriteLine("3. Show Leaderboard by Day");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice : ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        tracker.AddUser();
                        break;

                    case 2:
                        tracker.EnterDailySteps();
                        break;

                    case 3:
                        tracker.ShowLeaderboardByDay();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);
        }
    }
}

