using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgelabzTraining.class_modeling_and_diagram.csharp_modeling
{
    internal class UniversityManagement
    {
        static void Main(string[] args)
        {
            // Create instances of Course, Student, and Professor
            Course c = new Course("AI");
            Student s = new Student("Neha");
            Professor p = new Professor("Dr. Rao");
            // Enroll student in course and assign professor to course
            s.EnrollCourse(c);
            p.AssignProfessor(c);
        }
    }

    class Student
    {
        public string Name;
        public Student(string name)
        {
            Name = name;
        }
        // Method to enroll in a course
        public void EnrollCourse(Course course)
        {
            Console.WriteLine(Name + " enrolled in " + course.Name);
        }
    }

    class Professor
    {
        public string Name;
        public Professor(string name)
        {
            Name = name;
        }
        // Method to assign professor to a course
        public void AssignProfessor(Course course)
        {
            course.ProfessorName = Name;
            Console.WriteLine(Name + " assigned to " + course.Name);
        }
    }

    class Course
    {
        public string Name;
        public string ProfessorName;
        // Constructor
        public Course(string name)
        {
            Name = name;
        }
    }
}

