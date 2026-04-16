using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.UniversityStudentManagement
{
    internal class Student
    {
        static string UniversityName = "GLA University";
        static int TotalStudents = 0;

        readonly int RollNumber;

        string Name;
        char Grade;

        public Student(int rollNumber, string name, char grade)
        {
            this.RollNumber = rollNumber;
            this.Name = name;
            this.Grade = grade;
            TotalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students : {TotalStudents}");
        }

        public void UpdateGrade(char newGrade)
        {
            Grade = newGrade;
        }

        public void Display()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine($"University : {UniversityName}");
            Console.WriteLine($"Roll No    : {RollNumber}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Grade      : {Grade}");
            Console.WriteLine();
        }
    }
}
