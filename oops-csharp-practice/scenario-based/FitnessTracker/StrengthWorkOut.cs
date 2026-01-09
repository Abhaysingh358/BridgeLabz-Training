using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FitnessTracker
{
    public class StrengthWorkout : Workout
    {
        private int sets;
        private int repetitions;

        public int GetSets()
        {
            return sets;
        }

        public void SetSets(int sets)
        {
            this.sets = sets;
        }

        public int GetRepetitions()
        {
            return repetitions;
        }

        public void SetRepetitions(int repetitions)
        {
            this.repetitions = repetitions;
        }

        public override void TrackWorkout()
        {
        }

        public override string ToString()
        {
            return $"StrengthWorkout : UserId={GetUserId()}," +
                $" Name={GetWorkoutName()}, Duration={GetDuration()}," +
                $" Calories={GetCaloriesBurned()}, Sets={sets}, Reps={repetitions}";
        }
    }

}

