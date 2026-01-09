using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FitnessTracker
{
    public class CardioWorkout : Workout
    {
        private double distance;

        public double GetDistance()
        {
            return distance;
        }

        public void SetDistance(double distance)
        {
            this.distance = distance;
        }

        public override void TrackWorkout()
        {
        }

        public override string ToString()
        {
            return $"CardioWorkout : UserId={GetUserId()}" +
                $", Name={GetWorkoutName()}, Duration={GetDuration()}," +
                $" Calories={GetCaloriesBurned()}, Distance={distance}]";
        }
    }

}
