using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FitnessTracker
{
    public class UserProfile
    {
        private int UserId;
        private string Name;
        private int Age;
        private double Weight;
        private double Height;

        public int GetUserId()
        {
            return UserId;
        }

        public void SetUserId(int userId)
        {
            this.UserId = userId;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public void SetWeight(double weight)
        {
            this.Weight = weight;
        }

        public double GetHeight()
        {
            return Height;
        }

        public void SetHeight(double height)
        {
            this.Height = height;
        }

        public override string ToString()
        {
            return $"UserProfile [UserId={UserId}, Name={Name}, Age={Age}," +
                $" Weight={Weight}, Height={Height}]";
        }
    }

}
