using System;
using System.IO;
using System.Linq;

class Filter
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

            Console.WriteLine("\nStudents scoring more than 80 marks:\n");

            foreach (string line in lines.Skip(1)) // skip header
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',', StringSplitOptions.TrimEntries);

                if (data.Length != 4)
                    continue;

                int id = int.Parse(data[0]);
                string name = data[1];
                int age = int.Parse(data[2]);
                double marks = double.Parse(data[3]);

                if (marks > 80)
                {
                    Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}, Marks: {marks}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV: " + ex.Message);
        }
    }
}
