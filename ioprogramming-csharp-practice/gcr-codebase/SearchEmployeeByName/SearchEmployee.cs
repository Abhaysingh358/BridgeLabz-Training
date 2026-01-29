using System;
using System.IO;
using System.Linq;

class SearchEmployee
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

        Console.WriteLine("Enter employee name to search:");
        string searchName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(searchName))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            foreach (string line in lines.Skip(1)) // skip header
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',', StringSplitOptions.TrimEntries);

                if (data.Length != 4)
                    continue;

                string name = data[1];

                if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    string department = data[2];
                    double salary = double.Parse(data[3]);

                    Console.WriteLine("\nEmployee Found:");
                    Console.WriteLine("Name       : " + name);
                    Console.WriteLine("Department : " + department);
                    Console.WriteLine("Salary     : " + salary);

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("\nEmployee not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV: " + ex.Message);
        }
    }
}
