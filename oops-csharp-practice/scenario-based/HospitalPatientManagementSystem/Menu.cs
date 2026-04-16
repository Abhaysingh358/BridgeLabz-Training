using System;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.HospitalPatientManagementSystem
{
    internal class Menu
    {
        private Patient patient;   
        private int billCounter = 1;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n===== HOSPITAL PATIENT MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add In Patient");
                Console.WriteLine("2. Add Out Patient");
                Console.WriteLine("3. Assign Doctor");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice : ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddInPatient();
                        break;
                    case 2:
                        AddOutPatient();
                        break;
                    case 3:
                        AssignDoctor();   
                        break;
                    case 4:
                        Console.WriteLine("Application closed.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void AddInPatient()
        {
            Console.Write("Id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Description : ");
            string desc = Console.ReadLine();

            Console.Write("Days : ");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.Write("Daily Charge : ");
            double charge = Convert.ToDouble(Console.ReadLine());

            patient = new InPatient(id, name, desc, days, charge); 
          
            IPayable payable = (IPayable)patient;

            double amount = payable.Billing();
            Bill bill = new Bill("B" + billCounter++, name, amount, "InPatient");

            Console.WriteLine(patient);
            Console.WriteLine(bill);
        }

        private void AddOutPatient()
        {
            Console.Write("Id : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Description : ");
            string desc = Console.ReadLine();

            Console.Write("Consultation Fee : ");
            double consultationFee = double.Parse(Console.ReadLine());

            Console.Write("Medicine Fee : ");
            double medicineFee = double.Parse(Console.ReadLine());

            patient = new OutPatient(id, name, desc, consultationFee, medicineFee); // ✅ store patient
            IPayable payable = (IPayable)patient;

            double amount = payable.Billing();
            Bill bill = new Bill("B" + billCounter++, name, amount, "OutPatient");

            Console.WriteLine(patient);
            Console.WriteLine(bill);
        }

        private void AssignDoctor()
        {
            if (patient == null)
            {
                Console.WriteLine("Add patient first.");
                return;
            }

            Doctor d1 = new Doctor(101, "Dr. Prakhar", "Orthologist", patient);

            Console.WriteLine(d1);
            
        }
    }
}
