using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FitnessTracker
{
    public class Menu
    {
        private UserManager userManager = new UserManager();
        private WorkoutManager workoutManager = new WorkoutManager();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2. View Users");
                Console.WriteLine("3. Add Cardio Workout");
                Console.WriteLine("4. Add Strength Workout");
                Console.WriteLine("5. View User Workouts");
                Console.WriteLine("6. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        userManager.AddUser();
                        break;
                    case 2:
                        userManager.ViewAllUsers();
                        break;
                    case 3:
                        workoutManager.AddCardioWorkout(userManager);
                        break;
                    case 4:
                        workoutManager.AddStrengthWorkout(userManager);
                        break;
                    case 5:
                        workoutManager.ViewWorkoutsByUser();
                        break;
                }
            }
            while (choice != 6);
        }
    }

}
