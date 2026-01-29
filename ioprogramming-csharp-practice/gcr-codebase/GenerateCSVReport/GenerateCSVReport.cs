using System;
using System.IO;

class GenerateCSVReport
{
    static void Main()
    {
        Console.WriteLine("Enter source CSV file path:");
        string sourcePath = Console.ReadLine();

        Console.WriteLine("Enter output CSV report path:");
        string outputPath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(sourcePath) || !File.Exists(sourcePath))
        {
            Console.WriteLine("Source CSV not found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(sourcePath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string line;

                // Copy header
                line = reader.ReadLine();
                writer.WriteLine(line);

                int recordCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    writer.WriteLine(line);
                    recordCount++;
                }

                Console.WriteLine($"\nCSV report generated successfully!");
                Console.WriteLine($"Total records written: {recordCount}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV: " + ex.Message);
        }
    }
}
