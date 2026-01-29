using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}

class ReadCSV
{
    static void Main()
    {
        Console.WriteLine("Enter CSV file path:");
        string filePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filePath))
        {
            Console.WriteLine("File path cannot be empty.");
            return;
        }

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found. Please check path.");
            return;
        }

        List<Student> students = new List<Student>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].Trim();

                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] data = line.Split(',');

                if (data.Length < 4)
                {
                    Console.WriteLine($"Skipping invalid row at line {i + 1}: Not enough columns.");
                    continue;
                }

                bool isIdValid = int.TryParse(data[0].Trim(), out int id);
                string name = data[1].Trim();
                bool isAgeValid = int.TryParse(data[2].Trim(), out int age);
                bool isMarksValid = double.TryParse(data[3].Trim(), out double marks);

                if (isIdValid && isAgeValid && isMarksValid)
                {
                    students.Add(new Student
                    {
                        Id = id,
                        Name = name,
                        Age = age,
                        Marks = marks
                    });
                }
                else
                {
                    Console.WriteLine($"Skipping row {i + 1} due to data format error.");
                }
            }

            Console.WriteLine("\n--- Student Records Found ---");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id} | Name: {student.Name} | Age: {student.Age} | Marks: {student.Marks}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV: " + ex.Message);
        }
    }
}