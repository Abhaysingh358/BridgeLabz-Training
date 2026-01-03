using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.Person.cs
{
    internal class Person
    {
        // Private fields (encapsulation)
        private string name;
        private int age;

        // ⭐ Default Constructor
        public Person()
        {
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            age = int.Parse(Console.ReadLine());
        }

        // Parameterized Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy Constructor
        public Person(Person other)
        {
            // Copy fields from the provided object
            this.name = other.name;
            this.age = other.age;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("\nPerson Details");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age  : {age}");
        }
    }
}
