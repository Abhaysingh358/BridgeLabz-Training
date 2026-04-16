using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }

    public override string ToString()
    {
        return $"Student {{ Id={Id}, Name={Name}, Age={Age}, Marks={Marks} }}";
    }
}


class Convert
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

        List<Student> students = new List<Student>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines.Skip(1)) // skip header
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',', StringSplitOptions.TrimEntries);

                if (data.Length != 4)
                    continue;

                Student student = new Student
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = double.Parse(data[3])
                };

                students.Add(student);
            }

            Console.WriteLine("\nStudent Objects:\n");

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV: " + ex.Message);
        }
    }
}
