using System;
using System.IO;
using System.Collections.Generic;

class ReadLargeData
{
    static void Main()
    {
        Console.WriteLine("Enter large CSV file path:");
        string filePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
        {
            Console.WriteLine("Invalid file path.");
            return;
        }

        const int batchSize = 100;
        int totalProcessed = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string header = reader.ReadLine(); // skip header row

                List<string> batch = new List<string>(batchSize);
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    batch.Add(line);

                    if (batch.Count == batchSize)
                    {
                        ProcessBatch(batch, ref totalProcessed);
                        batch.Clear();
                    }
                }

                // process remaining rows
                if (batch.Count > 0)
                {
                    ProcessBatch(batch, ref totalProcessed);
                }
            }

            Console.WriteLine("\nFinished processing large CSV file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading large CSV: " + ex.Message);
        }
    }

    static void ProcessBatch(List<string> batch, ref int totalProcessed)
    {
        totalProcessed += batch.Count;

        Console.WriteLine(
            $"Processed {batch.Count} records ,Total so far: {totalProcessed}");
    }
}
