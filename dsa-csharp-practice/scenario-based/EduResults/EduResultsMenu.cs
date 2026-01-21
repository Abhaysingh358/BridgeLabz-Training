using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.EduResults
{
    internal class EduResultsMenu
    {
        private EduResultsUtility utility;


        public void Start()
        {
            utility = new EduResultsUtility();

            while (true)
            {
                Console.WriteLine("\n========== EduResults – Rank Sheet Generator ==========");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Show LeaderBoard (State Rank List)");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddStudent();
                        break;

                    case 2:
                        utility.DeleteStudent();
                        break;

                    case 3:
                        utility.ShowLeaderBoard();
                        break;

                    case 0:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid choice ,Try again.");
                        break;
                }
            }
        }
    }
}

