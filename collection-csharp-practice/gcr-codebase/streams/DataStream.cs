using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class DataStream
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                // Take student data from user
                Console.Write("Enter Roll Number: ");
                int rollInput = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string nameInput = Console.ReadLine();

                Console.Write("Enter GPA: ");
                double gpaInput = double.Parse(Console.ReadLine());

                // Write primitive data
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    writer.Write(rollInput);     // Roll Number
                    writer.Write(nameInput);     // Name
                    writer.Write(gpaInput);      // GPA
                }

                Console.WriteLine("Student data saved successfully.\n");

                // Read primitive data
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    int roll = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine("Student Data Retrieved:");
                    Console.WriteLine($"Roll No: {roll}");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"GPA: {gpa}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
