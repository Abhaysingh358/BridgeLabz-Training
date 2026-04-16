using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.class_modeling_and_diagram.csharp_modeling
{
    internal class HospitalSystem
    {
        // Main method
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor("Dr. pushapk");
            Patient p1 = new Patient("ram");
            // Doctor consulting patient
            d1.Consult(p1);
        }
    }

    class Doctor
    {
        public string Name;
        // Constructor
        public Doctor(string name)
        {
            Name = name;
        }
        // Method to consult patient
        public void Consult(Patient patient)
        {
            Console.WriteLine(Name + " is consulting " + patient.Name);
        }
    }

    class Patient
    {
        // Constructor
        public string Name;
        public Patient(string name)
        {
            Name = name;
        }
    }
}

