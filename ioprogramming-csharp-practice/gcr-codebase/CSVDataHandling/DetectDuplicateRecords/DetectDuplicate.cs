using System;
using System.IO;
using System.Collections.Generic;

class DetectDuplicate
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

        HashSet<int> seenIds = new HashSet<int>();
        List<string> duplicateRows = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string header = reader.ReadLine(); // skip header
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] data = line.Split(',', StringSplitOptions.TrimEntries);

                    if (data.Length < 1)
                        continue;

                    int id = int.Parse(data[0]);

                    if (seenIds.Contains(id))
                    {
                        duplicateRows.Add(line);
                    }
                    else
                    {
                        seenIds.Add(id);
                    }
                }
            }

            Console.WriteLine("\nDuplicate Records Found:\n");

            if (duplicateRows.Count == 0)
            {
                Console.WriteLine("No duplicates found.");
            }
            else
            {
                foreach (string row in duplicateRows)
                {
                    Console.WriteLine(row);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV: " + ex.Message);
        }
    }
}
