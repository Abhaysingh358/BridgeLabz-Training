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
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Employee emp = new Employee();
            emp.SetEmployeeID(1);
            emp.SetEmployeeName("Pushp");
            emp.SetEmployeePhone(565165);
            emp.SetEmailId("pushp@gmail.com");


            Console.WriteLine(emp);
            while (true)
            {
                Console.WriteLine("\n---- Employee Wage Computation ----");
                Console.WriteLine("1. Check Employee Attendance (UC-1)");
                Console.WriteLine("2. Calculate Daily Employee Wage (UC-2)");
                Console.WriteLine("3. Calculate Part-Time Employee Wage (UC-3)");
                Console.WriteLine("4. Calculate Monthly Employee Wage (UC-5)");
                Console.WriteLine("5. Calculate Monthly Wage with Conditions (UC-6)");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                // using switch statement as instructed in uc 4
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

                    case 4:
                        Console.WriteLine($"Monthly Wage (20 Days) : {employeeUtil.CalculateMonthlyWage()}");
                        break;

                    case 5:
                        Console.WriteLine($"Monthly Wage (UC-6) : {employeeUtil.CalculateMonthlyWageWithCondition()}");
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
