using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.HospitalManagementSystem
{
    internal class Patient
    {
        static string HospitalName = "City Hospital";
        static int TotalPatients = 0;

        readonly int PatientID;

        string Name;
        int Age;
        string Ailment;

        public Patient(int patientId, string name, int age, string ailment)
        {
            this.PatientID = patientId;
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            TotalPatients++;
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients Admitted : {TotalPatients}");
        }

        public void Display()
        {
            Console.WriteLine("Patient Details");
            Console.WriteLine($"Hospital Name : {HospitalName}");
            Console.WriteLine($"Patient ID    : {PatientID}");
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Age           : {Age}");
            Console.WriteLine($"Ailment       : {Ailment}");
            Console.WriteLine();
        }
    }
}
