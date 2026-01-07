using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeUtil;

        public EmployeeMenu(IEmployee employeeUtil)
        {
            this.employeeUtil = employeeUtil;
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n---- Employee Wage Computation ----");
                Console.WriteLine("1. Check Employee Attendance (UC-1)");
                Console.WriteLine("2. Calculate Daily Employee Wage (UC-2)");
                Console.WriteLine("3. Calculate Part-Time Employee Wage (UC-3)");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (choice)
                {
                    case 1:

                        if (employeeUtil.IsPresent()) { 
                            Console.WriteLine("Employee is Present");
                        }
                    else{
                            Console.WriteLine("Employee is Absent");

                      }

                    break;

                    case 2:
                        int wage = employeeUtil.CalculateDailyWage();
                        Console.WriteLine($"Daily Wage : {wage}");
                        break;

                    case 3:
                        Console.WriteLine($"Daily Wage (Part-Time) : {employeeUtil.CalculatePartTimeWage()}" );
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
