using System;

namespace BridgeLabz.core_csharp_practice.scenerio_based
{
    internal class StudentsManagement
    {
        static void Main(string[] args)
        {
            int studentCount = 0;

            // Input number of students
            while (true)
            {
                Console.Write("Enter the number of students: ");
                try
                {
                    studentCount = int.Parse(Console.ReadLine());

                    if (studentCount > 0)
                        break;
                    else
                        Console.WriteLine("Please enter a positive number.");
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }

            int[] studentScores = new int[studentCount];

            // Input scores
            for (int i = 0; i < studentCount; i++)
            {
                while (true)
                {
                    Console.Write($"Enter score for student {i + 1}: ");
                    try
                    {
                        int score = int.Parse(Console.ReadLine());

                        if (score >= 0)
                        {
                            studentScores[i] = score;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Score must be a non-negative number.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid score. Please enter a numeric value.");
                    }
                }
            }

            // Menu-driven program
            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Display Average Score");
                Console.WriteLine("2. Display Highest Score");
                Console.WriteLine("3. Display Lowest Score");
                Console.WriteLine("4. Display Scores Above Average");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                int option;

                if (!int.TryParse(input, out option))
                {
                    Console.WriteLine("Invalid option. Please enter a number.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Average Score: " + CalculateAverage(studentScores));
                        break;

                    case 2:
                        Console.WriteLine("Highest Score: " + GetHighestScore(studentScores));
                        break;

                    case 3:
                        Console.WriteLine("Lowest Score: " + GetLowestScore(studentScores));
                        break;

                    case 4:
                        DisplayScoresAboveAverage(studentScores);
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select a number from 1 to 5.");
                        break;
                }
            }
        }

        // Method: Calculate average score
        static double CalculateAverage(int[] scores)
        {
            int total = 0;
            foreach (int score in scores)
            {
                total += score;
            }
            return (double)total / scores.Length;
        }

        // Method: Find highest score
        static int GetHighestScore(int[] scores)
        {
            int highest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                    highest = scores[i];
            }
            return highest;
        }

        // Method: Find lowest score
        static int GetLowestScore(int[] scores)
        {
            int lowest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < lowest)
                    lowest = scores[i];
            }
            return lowest;
        }

        // Method: Display scores above average
        static void DisplayScoresAboveAverage(int[] scores)
        {
            double average = CalculateAverage(scores);
            bool found = false;

            Console.WriteLine("\nScores Above Average:");

            foreach (int score in scores)
            {
                if (score > average)
                {
                    Console.WriteLine(score);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No scores above average.");
        }
    }
}
