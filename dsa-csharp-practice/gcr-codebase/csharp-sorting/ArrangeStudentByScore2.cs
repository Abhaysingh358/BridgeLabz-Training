using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_sorting
{
    // Selection Sort
    // Student class
    class Students
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Students(int rollNo, string name, int score)
        {
            RollNo = rollNo;
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return "Roll No: " + RollNo + "\nName: " + Name + "\nScore: " + Score;
        }
    }

    internal class ArrangeStudentByScore2
    {
        static void SelectionSortByScore(Students[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[j].Score < students[minIndex].Score)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Students temp = students[i];
                    students[i] = students[minIndex];
                    students[minIndex] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            Students[] students = new Students[5];

            for (int i = 0; i < students.Length; i++)
            {
                int rollNo = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                int score = Convert.ToInt32(Console.ReadLine());
                students[i] = new Students(rollNo, name, score);
            }

            Console.WriteLine("\nBefore Sorting");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            SelectionSortByScore(students);

            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}

