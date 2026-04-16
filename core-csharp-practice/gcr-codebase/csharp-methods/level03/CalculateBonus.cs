using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BonusProgramBeginner
{
    internal class CalculateBonus
    {
        // Method to generate salary and years using Random
        public static double[,] GenerateEmployeeData(int totalEmployees)
        {
            double[,] data = new double[totalEmployees, 2];
            Random rand = new Random();

            for (int i = 0; i < totalEmployees; i++)
            {
                // 5-digit salary
                data[i, 0] = rand.Next(10000, 100000);

                // years of service
                data[i, 1] = rand.Next(1, 15);
            }

            return data;
        }

        // Method to calculate new salary and bonus
        public static double[,] Bonus(double[,] data)
        {
            int n = data.GetLength(0);
            double[,] result = new double[n, 2];

            for (int i = 0; i < n; i++)
            {
                double salary = data[i, 0];
                double years = data[i, 1];

                double bonus;

                if (years > 5)
                {
                    bonus = salary * 0.05;
                }
                else
                {
                    bonus = salary * 0.02;
                }

                double newSalary = salary + bonus;

                result[i, 0] = newSalary;
                result[i, 1] = bonus;
            }

            return result;
        }

        // Method to calculate totals and display them
        public static void ShowTotals(double[,] oldData, double[,] newData)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            Console.WriteLine("\nEmployee Salary Details:\n");

            for (int i = 0; i < oldData.GetLength(0); i++)
            {
                double oldSalary = oldData[i, 0];
                double years = oldData[i, 1];
                double newSalary = newData[i, 0];
                double bonus = newData[i, 1];

                totalOldSalary += oldSalary;
                totalNewSalary += newSalary;
                totalBonus += bonus;

                Console.WriteLine("Employee " + (i + 1));
                Console.WriteLine("Old Salary : " + oldSalary);
                Console.WriteLine("Years of Service : " + years);
                Console.WriteLine("Bonus : " + bonus);
                Console.WriteLine("New Salary : " + newSalary);
                Console.WriteLine();
            }

            Console.WriteLine("Total Old Salary : " + totalOldSalary);
            Console.WriteLine("Total New Salary : " + totalNewSalary);
            Console.WriteLine("Total Bonus Paid : " + totalBonus);
        }

        static void Main(string[] args)
        {
            int totalEmployees = 10;

            double[,] employeeData = GenerateEmployeeData(totalEmployees);

            double[,] updatedData = Bonus(employeeData);

            ShowTotals(employeeData, updatedData);
        }
    }
}

