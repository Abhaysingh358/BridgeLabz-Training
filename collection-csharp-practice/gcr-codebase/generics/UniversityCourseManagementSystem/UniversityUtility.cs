using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    internal class UniversityUtility
    {
        private Course<ExamCourse> examCourseManager = new Course<ExamCourse>();
        private Course<AssignmentCourse> assignmentCourseManager = new Course<AssignmentCourse>();

        public void AddExamCourse()
        {
            Console.Write("Enter Course Code: ");
            string code = Console.ReadLine();

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            Console.Write("Enter Total Marks: ");
            int total = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Passing Marks: ");
            int pass = Convert.ToInt32(Console.ReadLine());

            ExamCourse course = new ExamCourse(code, name, dept, total, pass);
            examCourseManager.AddCourse(course);
        }

        public void AddAssignmentCourse()
        {
            Console.Write("Enter Course Code: ");
            string code = Console.ReadLine();

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            Console.Write("Enter Number of Assignments: ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Max Marks per Assignment: ");
            int maxMarks = Convert.ToInt32(Console.ReadLine());

            AssignmentCourse course = new AssignmentCourse(code, name, dept, count, maxMarks);
            assignmentCourseManager.AddCourse(course);
        }

        public void DisplayExamCourses()
        {
            Console.WriteLine("\n===== EXAM COURSES =====");
            examCourseManager.DisplayAllCourses();
        }

        public void DisplayAssignmentCourses()
        {
            Console.WriteLine("\n===== ASSIGNMENT COURSES =====");
            assignmentCourseManager.DisplayAllCourses();
        }

        public void DisplayAllCourses()
        {
            DisplayExamCourses();
            DisplayAssignmentCourses();
        }
    }
}
