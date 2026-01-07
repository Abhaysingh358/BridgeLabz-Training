using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.HospitalManagementSystem
{
    internal class Menu
    {
        public Doctor[] doctors = new Doctor[4];
        public void getDoctor()
        {
            for(int i=0;i< doctors.Length; i++)
            {
                string doctorName = Console.ReadLine();
                string specialization = Console.ReadLine();
                long doctorID = Convert.ToInt64(Console.ReadLine());
                doctors[i] = new Doctor(doctorName, specialization, doctorID);
            }
        }
        public void Entry()
        {
            while (true)
            {
                Console.WriteLine("WELCOME TO THE M.B. HOSPITAL");
                Console.WriteLine("1.See all the Doctors");
                Console.WriteLine("2.Patient Entry");
                Console.WriteLine("3.Patient Exit");
                Console.WriteLine("4.Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowDoctors();
                        break;
                    case 2:
                        PatientEntry();
                        break;
                    case 3:
                        PatientExit();
                        break;
                    case 4:
                        break;
                }
                if(choice == 4)
                {
                    break;
                }
            }
        }

        public void ShowDoctors()
        {
            Console.WriteLine("\n--- Doctor List ---");
            for (int i = 0; i < doctors.Length; i++)
            {
                doctors[i].DisplayDoc();
            }
        }

        public void PatientEntry()
        {
            Console.WriteLine("choose a doctor");
            int chooseDoc = Convert.ToInt32(Console.ReadLine());

            if (chooseDoc<0 || chooseDoc > 3)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.WriteLine("enter your details");
            Console.WriteLine("fisrt name -> age -> id ");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            long Id = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("choose 1. for inPatient and 2. for outPatient");
            int type = Convert.ToInt32(Console.ReadLine());
            Patient patient;
            if (type == 1)
            {
                Console.Write("Room Number and Days Admitted ");
                int room = Convert.ToInt32(Console.ReadLine());
                int days = Convert.ToInt32(Console.ReadLine());

                patient = new InPatient(name, age, Id, room, days);
            }
            else
            {
                Console.Write("Appointment Date and Consultation Fee: ");
                string date = Console.ReadLine();
                int fee = Convert.ToInt32(Console.ReadLine());

                patient = new OutPatient(name, age, Id, date, fee);
            }

            doctors[chooseDoc].AddPatient(patient);
        }

        public void PatientExit()
        {
            Console.WriteLine("Enter Doctor form 0 to 3");
            int docIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Patient from 0 to 9");
            int patIndex = Convert.ToInt32(Console.ReadLine());

            Patient patient = doctors[docIndex].patients[patIndex];

            if (patient != null)
            {
                Bill.GenerateBill(patient);
            }
            else
            {
                Console.WriteLine("Patient not found");
            }
        }
    }
}
