using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Merge
{
    static void Main()
    {
        Console.WriteLine("Enter students1.csv path:");
        string file1 = Console.ReadLine();

        Console.WriteLine("Enter students2.csv path:");
        string file2 = Console.ReadLine();

        Console.WriteLine("Enter output merged CSV path:");
        string outputFile = Console.ReadLine();

        if (!File.Exists(file1) || !File.Exists(file2))
        {
            Console.WriteLine("One or both input files not found.");
            return;
        }

        try
        {
            Dictionary<int, (string Name, int Age)> studentInfo =
                new Dictionary<int, (string, int)>();

            string[] file1Lines = File.ReadAllLines(file1);

            foreach (string line in file1Lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',', StringSplitOptions.TrimEntries);
                if (data.Length != 3)
                    continue;

                int id = int.Parse(data[0]);
                string name = data[1];
                int age = int.Parse(data[2]);

                studentInfo[id] = (name, age);
            }

            List<string> mergedRows = new List<string>();
            mergedRows.Add("ID,Name,Age,Marks,Grade");

            string[] file2Lines = File.ReadAllLines(file2);

            foreach (string line in file2Lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',', StringSplitOptions.TrimEntries);
                if (data.Length != 3)
                    continue;

                int id = int.Parse(data[0]);
                double marks = double.Parse(data[1]);
                string grade = data[2];

                if (studentInfo.ContainsKey(id))
                {
                    string name = studentInfo[id].Name;
                    int age = studentInfo[id].Age;

                    mergedRows.Add($"{id},{name},{age},{marks},{grade}");
                }
            }

            File.WriteAllLines(outputFile, mergedRows);

            Console.WriteLine("\nCSV files merged successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error merging CSV files: " + ex.Message);
        }
    }
}
