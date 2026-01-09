using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FitnessTracker
{


    using System;

    public class WorkoutManager
    {
        private Workout[] workouts = new Workout[50];
        private int count = 0;

        public void AddCardioWorkout(UserManager userManager)
        {
            Console.Write("User Id: ");
            int userId = int.Parse(Console.ReadLine());

            if (!userManager.UserExists(userId))
            {
                Console.WriteLine("User not found.");
                return;
            }

            CardioWorkout workout = new CardioWorkout();
            workout.SetUserId(userId);

            Console.Write("Workout Name: ");
            workout.SetWorkoutName(Console.ReadLine());

            Console.Write("Duration: ");
            workout.SetDuration(int.Parse(Console.ReadLine()));

            Console.Write("Calories: ");
            workout.SetCaloriesBurned(int.Parse(Console.ReadLine()));

            Console.Write("Distance: ");
            workout.SetDistance(double.Parse(Console.ReadLine()));

            workouts[count] = workout;
            count++;
        }

        public void AddStrengthWorkout(UserManager userManager)
        {
            Console.Write("User Id: ");
            int userId = int.Parse(Console.ReadLine());

            if (!userManager.UserExists(userId))
            {
                Console.WriteLine("User not found.");
                return;
            }

            StrengthWorkout workout = new StrengthWorkout();
            workout.SetUserId(userId);

            Console.Write("Workout Name: ");
            workout.SetWorkoutName(Console.ReadLine());

            Console.Write("Duration: ");
            workout.SetDuration(int.Parse(Console.ReadLine()));

            Console.Write("Calories: ");
            workout.SetCaloriesBurned(int.Parse(Console.ReadLine()));

            Console.Write("Sets: ");
            workout.SetSets(int.Parse(Console.ReadLine()));

            Console.Write("Reps: ");
            workout.SetRepetitions(int.Parse(Console.ReadLine()));

            workouts[count] = workout;
            count++;
        }

        public void ViewWorkoutsByUser()
        {
            Console.Write("Enter User Id: ");
            int userId = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (workouts[i].GetUserId() == userId)
                {
                    Console.WriteLine(workouts[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No workouts found for this user.");
            }
        }
    }


}
