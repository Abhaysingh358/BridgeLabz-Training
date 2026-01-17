using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.FitnessTracker
{
    internal class User
    {
        private string Name;
        private int Steps;
        private int TotalSteps;

        public string GetName() 
        { 
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }

        public int GetSteps()
        {
            return Steps;
        }
        public int GetTotalSteps()
        {
            return TotalSteps;
        }
        public void SetSteps(int steps)
        {
            this.Steps = steps;
        }
        public void SetTotalSteps(int totalSteps)
        {
            this.TotalSteps = totalSteps;
        }

        public override string ToString()
        {
            return $"User--> Name : {Name}, Steps : {Steps} , TotalSteps : {TotalSteps}";
        }

    }
}
