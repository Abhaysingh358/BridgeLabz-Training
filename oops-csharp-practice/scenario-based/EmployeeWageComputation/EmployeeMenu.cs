using System;
using System.Collections.Generic;
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
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (employeeUtil.IsPresent())
                        {
                            Console.WriteLine("Employee is Present");
                        }
                        else
                        {
                            Console.WriteLine("Employee is Absent");
                        }
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
