using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.HospitalManagementSystem
{
    internal class Doctor
    {
        public string doctorName;
        public string specialization;
        public long doctorID;
        public Patient[] patients = new Patient[10];
        int index = 0;
        public Doctor(string doctorName, string specialization, long doctorID)
        {
            this.doctorName = doctorName;
            this.specialization = specialization;
            this.doctorID = doctorID;
           
        }

        public void AddPatient(Patient patient)
        {
            if (index < patients.Length)
            {
                patients[index] = patient;
                index++;
            }
            else
            {
                Console.WriteLine("Cannot add more patients, array is full.");
            }
        }

        public void DisplayDoc()
        {
            Console.WriteLine("Doctor Name: " + doctorName);
            Console.WriteLine("Specialization: " + specialization);
            Console.WriteLine("Doctor ID: " + doctorID);
        }

    }
}
