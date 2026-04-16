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

        private const int WorkingDaysPerMonth = 20;

        private const int MaxWorkingDays = 20;
        private const int MaxWorkHours = 100;
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

        public int CalculateMonthlyWage()
        {
            int monthlyWage = 0;

            for (int day = 1; day <= WorkingDaysPerMonth; day++)
            {
                monthlyWage += CalculateDailyWage();
            }

            return monthlyWage;
        }

        public int CalculateMonthlyWageWithCondition()
        {
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            int totalWage = 0;

            while (totalWorkingDays < MaxWorkingDays &&
                   totalWorkingHours < MaxWorkHours)
            {
                totalWorkingDays++;

                if (IsPresent())
                {
                    // ensure hours don't exceed max
                    int hoursWorkedToday = FullDayHour;

                    if (totalWorkingHours + hoursWorkedToday > MaxWorkHours)
                    {
                        hoursWorkedToday = MaxWorkHours - totalWorkingHours;
                    }

                    totalWorkingHours += hoursWorkedToday;
                    totalWage += hoursWorkedToday * WagePerHour;
                }
            }

            return totalWage;
        }
    }
}
