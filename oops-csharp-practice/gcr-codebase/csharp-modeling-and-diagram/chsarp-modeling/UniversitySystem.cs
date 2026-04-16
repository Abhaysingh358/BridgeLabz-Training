using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.class_modeling_and_diagram.csharp_modeling
{
    internal class UniversitySystem
    {
        // Main method
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty("Mr. sahil");
            University uni = new University("GLA University");
            // Adding faculty to university
            uni.AddFaculty(f1);
            uni.Display();
        }
    }

    class University
    {
        // University name
        public string Name;
        Dept[] Departments = new Dept[2];
        Faculty[] Faculties = new Faculty[5];
        int i = 0;
        // Constructor
        public University(string name)
        {
            Name = name;
            Departments[0] = new Dept("CS");
            Departments[1] = new Dept("ECE");
        }

        public void AddFaculty(Faculty faculty)
        {
            Faculties[i++] = faculty;
        }
        //  Display university details
        public void Display()
        {
            Console.WriteLine(Name);
            foreach (Dept d in Departments)
                Console.WriteLine("Department: " + d.Name);
        }
    }

    class Dept
    {
        public string Name;
        public Dept(string name)
        {
            Name = name;
        }
    }

    class Faculty
    {
        public string Name;
        public Faculty(string name)
        {
            Name = name;
        }
    }
}

