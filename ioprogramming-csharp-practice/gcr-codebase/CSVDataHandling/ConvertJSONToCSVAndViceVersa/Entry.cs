using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class JsonStudent
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter JSON file path (source):");
        string jsonPath = Console.ReadLine();

        Console.WriteLine("Enter CSV file path (to create):");
        string csvPath = Console.ReadLine();

        Console.WriteLine("Enter JSON file path (converted from CSV):");
        string jsonOutputPath = Console.ReadLine();

        if (!File.Exists(jsonPath))
        {
            Console.WriteLine("JSON source file not found.");
            return;
        }

        ConvertJsonToCsv(jsonPath, csvPath);
        ConvertCsvToJson(csvPath, jsonOutputPath);
    }

    static void ConvertJsonToCsv(string jsonPath, string csvPath)
    {
        string json = File.ReadAllText(jsonPath);

        List<JsonStudent> students =
            JsonSerializer.Deserialize<List<JsonStudent>>(json);

        using (StreamWriter writer = new StreamWriter(csvPath))
        {
            writer.WriteLine("Id,Name,Age,Marks");

            foreach (JsonStudent s in students)
            {
                writer.WriteLine($"{s.Id},{s.Name},{s.Age},{s.Marks}");
            }
        }

        Console.WriteLine("\nJSON to CSV conversion done!");
    }

    static void ConvertCsvToJson(string csvPath, string jsonOutputPath)
    {
        List<JsonStudent> students = new List<JsonStudent>();

        using (StreamReader reader = new StreamReader(csvPath))
        {
            reader.ReadLine(); // skip header

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',');

                students.Add(new JsonStudent
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = double.Parse(data[3])
                });
            }
        }

        string json = JsonSerializer.Serialize(
            students,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(jsonOutputPath, json);

        Console.WriteLine("CSV to JSON conversion done!");
    }
}
