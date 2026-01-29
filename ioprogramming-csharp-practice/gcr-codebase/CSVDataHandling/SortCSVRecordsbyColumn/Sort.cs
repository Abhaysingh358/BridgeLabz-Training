using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Sort
{
    static void Main()
    {
        Console.WriteLine("Enter CSV file path:");
        string filePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
        {
            Console.WriteLine("Invalid file path.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            List<(int Id, string Name, string Department, double Salary)> employees =
                new List<(int, string, string, double)>();

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',', StringSplitOptions.TrimEntries);

                if (data.Length != 4)
                    continue;

                int id = int.Parse(data[0]);
                string name = data[1];
                string department = data[2];
                double salary = double.Parse(data[3]);

                employees.Add((id, name, department, salary));
            }

            List<(int Id, string Name, string Department, double Salary)> sortedEmployees =
                employees
                .OrderByDescending(e => e.Salary)
                .Take(5)
                .ToList();

            Console.WriteLine("\nTop 5 Highest Paid Employees:\n");

            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine(
                    $"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV: " + ex.Message);
        }
    }
}
