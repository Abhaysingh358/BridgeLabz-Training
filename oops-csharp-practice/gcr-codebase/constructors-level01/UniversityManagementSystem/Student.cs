using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.UniversityManagementSystem
{
    public class Student
    {
        public int RollNumber;
        protected string Name;
        private double CGPA;


        public void Input()
        {
            Console.WriteLine("Enter Roll Number:");
            RollNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter CGPA:");
            CGPA = double.Parse(Console.ReadLine());
        }

        // accessing cgpa
        public double GetGPA()
        {
            return CGPA;
        }

        // modifying cgpa
        public void SetCGPA(double newCGPA)
        {
            if (newCGPA >= 0.0 && newCGPA <= 10.0)
            {
                this.CGPA = newCGPA;
            }
            else
            {
                Console.WriteLine("Invalid CGPA value.");
            }
        }

        // displaying student result
        public void Display()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine($"Roll Number : {RollNumber}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"CGPA : {CGPA}");
        }

    }

    // sub class
    public class PostgraduateStudent : Student
    {
        string ResearchField;

        public void InputPostgraduate()
        {
            Input();  // reuse parent method

            Console.WriteLine("Enter Specialization:");
            ResearchField = Console.ReadLine();
        }

        public void DisplayPostgraduate()
        {
            Console.WriteLine("====Postgraduate Student Details===");
            Console.WriteLine($"Roll Number   : {RollNumber}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"CGPA : {GetGPA()}");
            Console.WriteLine($"Specialization: {ResearchField}");
        }
    }
}
