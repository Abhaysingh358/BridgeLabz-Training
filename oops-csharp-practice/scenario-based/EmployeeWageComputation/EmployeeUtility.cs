using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    internal class EmployeeUtility : IEmployee
    {
        private static Random random = new Random();

        private const int WagePerHour = 20;
        private const int FullDayHour = 8;

        private const int PartTimeHour = 8;
        public bool IsPresent()
        {

            return random.Next(0, 2) == 1;
        }

        public int CalculateDailyWage()
        {
            if (IsPresent())
            {
                return WagePerHour * FullDayHour;
            }
            return 0;
        }

        public int CalculatePartTimeWage()
        {
            if (IsPresent())
            {
                return WagePerHour * PartTimeHour;
            }
            return 0;
        }
    }
}