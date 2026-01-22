using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    // Generic class to manage any type of CourseType safely
    internal class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        // Add course
        public void AddCourse(T course)
        {
            courses.Add(course);
            Console.WriteLine("Course added successfully.");
        }

        // Display all courses
        public void DisplayAllCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }

            Console.WriteLine("\n===== COURSE LIST =====");
            foreach (T course in courses)
            {
                course.DisplayEvaluation();
                Console.WriteLine("------------------------");
            }
        }

        // Return list (optional for utility usage)
        public List<T> GetAllCourses()
        {
            return courses;
        }
    }
}

