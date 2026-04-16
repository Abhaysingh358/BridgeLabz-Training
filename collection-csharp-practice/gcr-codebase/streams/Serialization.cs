using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class Serialization
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1}");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Department: ");
                string dept = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee
                {
                    Id = id,
                    Name = name,
                    Department = dept,
                    Salary = salary
                });
            }

            try
            {
                // Serialize
                string json = JsonSerializer.Serialize(
                    employees,
                    new JsonSerializerOptions { WriteIndented = true }
                );
                File.WriteAllText(filePath, json);
                Console.WriteLine("\nEmployees saved successfully.\n");

                // Deserialize
                string readJson = File.ReadAllText(filePath);
                List<Employee> loadedEmployees = JsonSerializer.Deserialize<List<Employee>>(readJson);

                Console.WriteLine("Employees retrieved from file:");
                foreach (var emp in loadedEmployees)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Dept: {emp.Department}, Salary: {emp.Salary}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
