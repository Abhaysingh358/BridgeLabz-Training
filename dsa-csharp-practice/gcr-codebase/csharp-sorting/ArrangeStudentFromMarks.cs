using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_sorting
{
    // Student class
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(int id, string name, int marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
        public override string ToString()
        {
            return "Id: " + Id + "\nName: " + Name + "\nMarks: " + Marks;
        }
    }

    internal class ArrangeStudentFromMarks
    {
        // Bubble Sort method to sort students by marks (ascending)
        static void BubbleSortByMarks(Student[] students)
        {
            int n = students.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].Marks > students[j + 1].Marks)
                    {
                        // Swap
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no swaps occurred, array is already sorted
                if (!swapped)
                    break;
            }
        }

        static void Main(string[] args)
        {
            // Array of Student objects
            Student[] students = new Student[5];
            for(int i = 0; i < students.Length; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                int marks = Convert.ToInt32(Console.ReadLine());
                students[i] = new Student(id, name, marks);
            }
            Console.WriteLine("\nBefore Sorting");
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            // Sort students by marks
            BubbleSortByMarks(students);

            Console.WriteLine("\nAftet Sorting");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
