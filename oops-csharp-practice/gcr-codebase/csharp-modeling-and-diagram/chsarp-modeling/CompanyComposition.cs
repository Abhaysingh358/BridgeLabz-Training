using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.class_modeling_and_diagram.csharp_modeling
{
    internal class CompanyComposition
    {
        //  Main method
        static void Main(string[] args)
        {
            Company company = new Company("BridgeLabz");
            company.Display();
        }
    }

    class Company
    {
        // Fields
        public string Name;
        public Department[] Departments = new Department[2];
        // Constructor
        public Company(string name)
        {
            Name = name;
            Departments[0] = new Department("HR");
            Departments[1] = new Department("IT");
        }
        // Method to display company details
        public void Display()
        {
            Console.WriteLine("Company: " + Name);
            for (int i=0;i<2;i++)
            {
                Console.WriteLine("Dept " + Departments[i].Name);
            }
        }
    }

    class Department
    {
        public string Name;

        public Department(string name)
        {
            Name = name;
        }
    }
}
