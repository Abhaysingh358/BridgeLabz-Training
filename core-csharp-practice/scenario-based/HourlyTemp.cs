using System;

namespace BridgelabzTraining.scenario_based
{
    internal class HourlyTemp
    {
        static void Main(string[] args)
        {
            // Create an object to access instance methods
            HourlyTemp obj = new HourlyTemp();

            Console.WriteLine("Enter temperatures for 7 days (24 hours each):");

            // Take hourly temperature input for 7 days
            double[,] temp = obj.InputTemp();

            // Calculate average temperature for each day
            double[] averageTemp = obj.AverageTemps(temp);

            Console.WriteLine("\n--- DAILY AVERAGES ---");

            // Display average temperature for all 7 days
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {averageTemp[i]:F2}");
            }

            // Display hottest and coldest day based on average
            Console.WriteLine($"\nHottest Day: Day {obj.HottestDay(averageTemp) + 1}");
            Console.WriteLine($"Coldest Day: Day {obj.ColdestDay(averageTemp) + 1}");
        }

        // -------------------------------------------------------------
        // METHOD: InputTemp
        // PURPOSE: Accept 24 hourly temperatures for 7 days.
        // RETURNS: A 2D array [7,24] of temperature values.
        // -------------------------------------------------------------
        double[,] InputTemp()
        {
            double[,] hourlyTemp = new double[7, 24];

            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"\nEnter 24 hourly temperatures for Day {day + 1}:");

                for (int hour = 0; hour < 24; hour++)
                {
                    while (true)
                    {
                        Console.Write($"Hour {hour}: ");

                        // Use TryParse to prevent program crash on invalid input
                        if (double.TryParse(Console.ReadLine(), out double value))
                        {
                            hourlyTemp[day, hour] = value;
                            break; // Exit the loop after valid input
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                }
            }

            return hourlyTemp;
        }

        // -------------------------------------------------------------
        // METHOD: AverageTemps
        // PURPOSE: Calculate the average temperature for each day.
        // RETURNS: A 1D array of 7 elements containing daily averages.
        // -------------------------------------------------------------
        double[] AverageTemps(double[,] hourlyTemp)
        {
            double[] averageTemp = new double[7];

            for (int day = 0; day < 7; day++)
            {
                double sum = 0;

                // Add up all hourly temperatures for the day
                for (int hour = 0; hour < 24; hour++)
                {
                    sum += hourlyTemp[day, hour];
                }

                // Average = total / 24 hours
                averageTemp[day] = sum / 24;
            }

            return averageTemp;
        }

        // -------------------------------------------------------------
        // METHOD: HottestDay
        // PURPOSE: Find which day has the highest average temperature.
        // RETURNS: Index (0–6) of the hottest day.
        // -------------------------------------------------------------
        int HottestDay(double[] averageTemp)
        {
            int hottest = 0; // Start with day 0

            for (int i = 1; i < averageTemp.Length; i++)
            {
                // Update if a hotter day is found
                if (averageTemp[i] > averageTemp[hottest])
                {
                    hottest = i;
                }
            }

            return hottest;
        }

        // -------------------------------------------------------------
        // METHOD: ColdestDay
        // PURPOSE: Find which day has the lowest average temperature.
        // RETURNS: Index (0–6) of the coldest day.
        // -------------------------------------------------------------
        int ColdestDay(double[] averageTemp)
        {
            int coldest = 0; // Start with day 0

            for (int i = 1; i < averageTemp.Length; i++)
            {
                // Update if a colder day is found
                if (averageTemp[i] < averageTemp[coldest])
                {
                    coldest = i;
                }
            }

            return coldest;
        }
    }
}
