using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.generics.UniversityCourseManagementSystem
{
    internal class UniversityMenu
    {
        private UniversityUtility utility;

        public void Start()
        {
            utility = new UniversityUtility();

            int choice;

            do
            {
                Console.WriteLine("\n===== UNIVERSITY COURSE MANAGEMENT MENU =====");
                Console.WriteLine("1. Add Exam Course");
                Console.WriteLine("2. Add Assignment Course");
                Console.WriteLine("3. Display Exam Courses");
                Console.WriteLine("4. Display Assignment Courses");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddExamCourse();
                        break;

                    case 2:
                        utility.AddAssignmentCourse();
                        break;

                    case 3:
                        utility.DisplayExamCourses();
                        break;

                    case 4:
                        utility.DisplayAssignmentCourses();
                        break;

                    case 5:
                        utility.DisplayAllCourses();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}

