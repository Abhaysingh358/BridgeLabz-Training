using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgelabzTraining.class_modeling_and_diagram.csharp_modeling
{
    internal class SchoolSystem
    {
        // Main method
        static void Main(string[] args)
        {
            Student s1 = new Student("pushapk");
            Course c1 = new Course("english");
            // Enroll student in course
            s1.Enroll(c1);
            s1.ViewCourses();
            c1.ViewStudents();
        }
    }

    class Student
    {
        // Student name
        public string Name;
        public Course[] Courses = new Course[5];
        int i = 0;

        public Student(string name)
        {
            Name = name;
        }
        // Enroll in a course
        public void Enroll(Course course)
        {
            Courses[i++] = course;
            course.AddStudent(this);
        }
        // View enrolled courses
        public void ViewCourses()
        {
            Console.WriteLine(Name + " enrolled courses:");
            for (int j = 0; j < i; j++)
                Console.WriteLine(Courses[j].Name);
        }
    }

    class Course
    {
        public string Name;
        Student[] Students = new Student[5];
        int i = 0;

        public Course(string name)
        {
            Name = name;
        }
        // Add student to the course
        public void AddStudent(Student student)
        {
            Students[i++] = student;
        }
        // View enrolled students
        public void ViewStudents()
        {
            Console.WriteLine("Students in " + Name);
            for (int j = 0; j < i; j++)
                Console.WriteLine(Students[j].Name);
        }
    }
}

