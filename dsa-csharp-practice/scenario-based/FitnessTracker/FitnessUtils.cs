using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FitnessTracker
{
    internal class FitnessUtils : IFitnessTracker
    {
        private User[] users = new User[20];
        private int count = 0;

        private int[,] dailySteps = new int[20, 31];
        private int maxDays = 0;
        private int selectedDay = 0;

        // Adds a new user in users array
        public void AddUser()
        {
            if (count >= users.Length)
            {
                Console.WriteLine("User limit reached. Cannot add more than 20 users.");
                return;
            }

            Console.Write("Enter User Name : ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name.");
                return;
            }

            User user = new User();
            user.SetName(name);
            user.SetSteps(0);
            user.SetTotalSteps(0);

            users[count] = user;
            count++;

            Console.WriteLine("User added successfully.");
        }

        // Takes steps input for each day for each user and calculates total steps
        public void EnterDailySteps()
        {
            if (count == 0)
            {
                Console.WriteLine("No users available. Add users first.");
                return;
            }

            Console.Write("Enter number of days to track (1 to 31) : ");
            int days = int.Parse(Console.ReadLine());

            if (days <= 0 || days > 31)
            {
                Console.WriteLine("Invalid number of days.");
                return;
            }

            maxDays = days;

            int day = 1;

            while (day <= maxDays)
            {
                Console.WriteLine("Enter steps for Day " + day);

                int i = 0;
                while (i < count)
                {
                    Console.Write("Enter steps for " + users[i].GetName() + " : ");
                    int steps = int.Parse(Console.ReadLine());

                    if (steps < 0)
                    {
                        steps = 0;
                    }

                    dailySteps[i, day - 1] = steps;

                    int total = users[i].GetTotalSteps();
                    users[i].SetTotalSteps(total + steps);

                    i++;
                }

                day++;
            }

            Console.WriteLine("Day wise step entry completed.");
        }

        // Selects a day and prepares users steps for leaderboard
        public void ShowLeaderboardByDay()
        {
            if (count == 0)
            {
                Console.WriteLine("No users available.");
                return;
            }

            if (maxDays == 0)
            {
                Console.WriteLine("No day wise data found. Enter daily steps first.");
                return;
            }

            Console.Write("Enter day number (1 to " + maxDays + ") : ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day < 1 || day > maxDays)
            {
                Console.WriteLine("Invalid day number.");
                return;
            }

            selectedDay = day;

            int i = 0;
            while (i < count)
            {
                users[i].SetSteps(dailySteps[i, day - 1]);
                i++;
            }

            SortUsersByStepsBubbleSort();
            ShowLeaderboard();
        }

        // Sorts user array based on steps using Bubble Sort descending order
        public void SortUsersByStepsBubbleSort()
        {
            if (count <= 1)
            {
                return;
            }

            for (int i = 0; i < count - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < count - 1 - i; j++)
                {
                    if (users[j] != null && users[j + 1] != null)
                    {
                        if (users[j].GetSteps() < users[j + 1].GetSteps())
                        {
                            User temp = users[j];
                            users[j] = users[j + 1];
                            users[j + 1] = temp;

                            swapped = true;
                        }
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        // Displays leaderboard based on the selected day
        public void ShowLeaderboard()
        {
            if (count == 0)
            {
                Console.WriteLine("No users available to display leaderboard.");
                return;
            }

            if (selectedDay == 0)
            {
                Console.WriteLine("No day selected.");
                return;
            }

            Console.WriteLine("Leaderboard for Day " + selectedDay);

            for (int i = 0; i < count; i++)
            {
                if (users[i] != null)
                {
                    Console.WriteLine("Rank " + (i + 1) + " -> " + users[i].GetName() 
                        + " : " + users[i].GetSteps() + " steps");
                }
            }
        }
    }
}
