using HealthCareApp.Core.Models;
using HealthCareApp.Core.Repositories;

namespace HealthCareApp.Core.Menus
{
    // Handles all patient related console operations
    public class PatientMenu
    {
        private readonly PatientRepository _patientRepository;

        public PatientMenu()
        {
            _patientRepository = new PatientRepository();
        }

        // Main patient menu
        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Patient Management");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Back");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddPatient();
                }
                else if (choice == "2")
                {
                    ViewPatients();
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        private void AddPatient()
        {
            Patient patient = new Patient();

            Console.Write("Name: ");
            patient.FullName = Console.ReadLine();

            Console.Write("DOB (yyyy-mm-dd): ");
            patient.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Phone: ");
            patient.Phone = Console.ReadLine();

            Console.Write("Email: ");
            patient.Email = Console.ReadLine();

            Console.Write("Address: ");
            patient.Address = Console.ReadLine();

            Console.Write("Blood Group: ");
            patient.BloodGroup = Console.ReadLine();

            _patientRepository.AddPatient(patient);

            Console.WriteLine("Patient added successfully.");
        }

        private void ViewPatients()
        {
            var patients = _patientRepository.GetAllPatients();

            foreach (var p in patients)
            {
                Console.WriteLine(p.PatientId + " , " + p.FullName + " , " + p.Phone);
            }
        }
    }
}
