using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FitnessTracker
{
    public class Workout : ITrackable
    {
        private int userId;
        private string WorkoutName;
        private int Duration;
        private int CaloriesBurned;

        public int GetUserId()
        {
            return userId;
        }

        public void SetUserId(int userId)
        {
            this.userId = userId;
        }

        public string GetWorkoutName()
        {
            return WorkoutName;
        }

        public void SetWorkoutName(string workoutName)
        {
            this.WorkoutName = workoutName;
        }

        public int GetDuration()
        {
            return Duration;
        }

        public void SetDuration(int duration)
        {
            this.Duration = duration;
        }

        public int GetCaloriesBurned()
        {
            return CaloriesBurned;
        }

        public void SetCaloriesBurned(int caloriesBurned)
        {
            this.CaloriesBurned = caloriesBurned;
        }

        public virtual void TrackWorkout()
        {
        }

        public override string ToString()
        {
            return $"Workout [UserId={userId}, Name={WorkoutName}" +
                $", Duration={Duration}, Calories={CaloriesBurned}]";
        }
    }

}
