using System;
using System.IO;
using System.Collections.Generic;

class WriteCSV
{
    static void Main()
    {
        Console.WriteLine("Enter path where CSV should be created (example: C:\\data\\employees.csv):");
        string filePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filePath))
        {
            Console.WriteLine("Invalid file path.");
            return;
        }

        List<(int Id, string Name, string Department, double Salary)> employees =
            new List<(int, string, string, double)>
        {
            (1, "Amit", "HR", 45000),
            (2, "Neha", "IT", 65000),
            (3, "Rahul", "Finance", 55000),
            (4, "Priya", "Marketing", 50000),
            (5, "Suresh", "Operations", 48000)
        };

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Salary");

                foreach (var emp in employees)
                {
                    writer.WriteLine($"{emp.Id},{emp.Name},{emp.Department},{emp.Salary}");
                }
            }

            Console.WriteLine("CSV file created and data written successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing CSV: " + ex.Message);
        }
    }
}
