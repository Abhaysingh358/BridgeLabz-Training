using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class Bonus
    {
        static void Main(string[] args)
        {
            int totalEmployees = 10;

            // strores employees data
            double[] salary = new double[totalEmployees];
            double[] years = new double[totalEmployees];

            // store years and bonus

            double[] bonus = new double[totalEmployees];
            double[] newSalary = new double[totalEmployees];

            double totalBonus = 0.0;
            double totalOldSalary = 0.0;
            double totalNewSalary = 0.0;

            // taking employee details from the user 

            for (int i = 0; i < totalEmployees; i++)
            {
                Console.WriteLine($"\nEmployee  {i + 1} : ");

                Console.Write("Enter Salary : ");
                double salaryVal = double.Parse(Console.ReadLine());

                Console.WriteLine("Enetr years of Service : ");
                double yrs = double.Parse(Console.ReadLine());

                // check validation of salary and years 
                if (salaryVal <= 0 || yrs <= 0)
                {
                    Console.WriteLine("enter the salary and years greater than zero : ");
                    i--;
                    continue;
                }

                salary[i] = salaryVal;
                years[i] = yrs;



            }

            //calculating Bonus
            for (int i = 0; i < totalEmployees; i++)
            {
                // if years > 5 bonus is 5 percent otherwise 2 percent
                if (years[i] > 5)
                {
                    bonus[i] = salary[i] * 0.05;
                }
                else
                {
                    bonus[i] = salary[i] * 0.02;
                }

                newSalary[i] = salary[i] + bonus[i];

                totalOldSalary += salary[i];
                totalBonus += bonus[i];
                totalNewSalary += newSalary[i];
            }

            // displaying the the details of bonus and salary
            Console.WriteLine("Total old Salary " + totalOldSalary);
            Console.WriteLine("\nTotal Bonus " + totalBonus);
            Console.WriteLine("\nTotal new Salary " + totalNewSalary);







        }


    }
}

