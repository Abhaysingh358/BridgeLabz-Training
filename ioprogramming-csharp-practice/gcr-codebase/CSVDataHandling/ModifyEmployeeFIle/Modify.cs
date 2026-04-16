using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Modify
{
    static void Main()
    {
        Console.WriteLine("Enter source CSV file path:");
        string sourcePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(sourcePath) || !File.Exists(sourcePath))
        {
            Console.WriteLine("Invalid source file.");
            return;
        }

        Console.WriteLine("Enter new CSV file path to save updated data:");
        string outputPath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(outputPath))
        {
            Console.WriteLine("Invalid output file path.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            List<string> updatedLines = new List<string>();
            updatedLines.Add(lines[0]); // keep header

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

                if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    salary = salary + (salary * 0.10); // increase by 10%
                }

                updatedLines.Add($"{id},{name},{department},{salary}");
            }

            File.WriteAllLines(outputPath, updatedLines);

            Console.WriteLine("\nUpdated CSV file created successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error updating CSV: " + ex.Message);
        }
    }
}
