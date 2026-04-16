using System;
using System.IO;
using System.Linq;

class CountRows
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

            int recordCount = lines
                .Skip(1) // skip header row
                .Count(line => !string.IsNullOrWhiteSpace(line));

            Console.WriteLine("Total Records (excluding header): " + recordCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV: " + ex.Message);
        }
    }
}
