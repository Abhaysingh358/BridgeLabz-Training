using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgelabzTraining.csharp_sorting
{
    // Student class
    class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student1(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return "Id: " + Id + "\nName: " + Name + "\nAge: " + Age;
        }
    }

    internal class ArrangeStudentByAge
    {
        static void CountingSortByAge(Student1[] students)
        {
            int minAge = 10;
            int maxAge = 18;

            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            Student1[] output = new Student1[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                count[students[i].Age - minAge]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            for (int i = students.Length - 1; i >= 0; i--)
            {
                int index = students[i].Age - minAge;
                output[count[index] - 1] = students[i];
                count[index]--;
            }

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = output[i];
            }
        }

        static void Main(string[] args)
        {
            Student1[] students = new Student1[5];

            for (int i = 0; i < students.Length; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                int age = Convert.ToInt32(Console.ReadLine());
                students[i] = new Student1(id, name, age);
            }

            Console.WriteLine("\nBefore Sorting");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            CountingSortByAge(students);

            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
