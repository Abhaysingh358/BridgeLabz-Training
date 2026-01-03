using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.OnlineCourseManagement
{
    internal class Course
    {
        string CourseName;
        double duration;
        double fee;
        static string InstituteName = "GLA University , Mathura";

        public Course()
        {
            Input();
        }

        public void Input()
        {
            Console.WriteLine("Enter the course Name");
            CourseName = Console.ReadLine();

            Console.WriteLine("enter the duration in years");
            duration = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fee details in rs.");
            fee = double.Parse(Console.ReadLine());


        }

        public static  void ChangeInstituteName()
        {
            Console.WriteLine("Change the Institute Name");
            InstituteName = Console.ReadLine();
        }


        public void Display()
        {
            Console.WriteLine("Course Details");
            Console.WriteLine($"Course Name : {CourseName}");
            Console.WriteLine($"Duration : {duration} yrs");
            Console.WriteLine($"Fee : { fee}rs.");
            Console.WriteLine($"Institute Name : {InstituteName}");
        }


    }
}
