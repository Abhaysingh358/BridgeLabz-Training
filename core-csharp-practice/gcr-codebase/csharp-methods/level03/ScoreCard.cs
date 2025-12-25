using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ScoreCard
{
    internal class ScoreCardProgram
    {
        // b. Method to generate random PCM marks (2-digit)
        public static int[,] GenerateRandomMarks(int students)
        {
            int[,] marks = new int[students, 3];
            Random r = new Random();

            for (int i = 0; i < students; i++)
            {
                marks[i, 0] = r.Next(10, 100); // Physics
                marks[i, 1] = r.Next(10, 100); // Chemistry
                marks[i, 2] = r.Next(10, 100); // Maths
            }

            return marks;
        }

        // c. Method to calculate total, average, percentage
        public static double[,] CalculateScores(int[,] marks)
        {
            int n = marks.GetLength(0);
            double[,] results = new double[n, 3];

            for (int i = 0; i < n; i++)
            {
                int phy = marks[i, 0];
                int chem = marks[i, 1];
                int math = marks[i, 2];

                double total = phy + chem + math;
                double avg = total / 3.0;
                double percent = (total / 300.0) * 100;

                results[i, 0] = Math.Round(total, 2);
                results[i, 1] = Math.Round(avg, 2);
                results[i, 2] = Math.Round(percent, 2);
            }

            return results;
        }

        // d. Method to display scorecard
        public static void DisplayScoreCard(int[,] marks, double[,] results)
        {
            int n = marks.GetLength(0);

            Console.WriteLine("\nSTUDENT SCORECARD");
            Console.WriteLine("Stu\tPhy\tChem\tMath\tTotal\tAvg\tPercent");

            for (int i = 0; i < n; i++)
            {
                Console.Write(
                    (i + 1) + "\t" +
                    marks[i, 0] + "\t" +
                    marks[i, 1] + "\t" +
                    marks[i, 2] + "\t" +
                    results[i, 0] + "\t" +
                    results[i, 1] + "\t" +
                    results[i, 2] + "%"
                );

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // a. Take input for number of students
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[,] marks = GenerateRandomMarks(n);

            double[,] results = CalculateScores(marks);

            DisplayScoreCard(marks, results);
        }
    }
}

