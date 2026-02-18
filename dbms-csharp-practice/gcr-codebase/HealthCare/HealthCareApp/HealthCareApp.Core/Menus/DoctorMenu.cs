using HealthCareApp.Core.Models;
using HealthCareApp.Core.Repositories;

namespace HealthCareApp.Core.Menus
{
    // Handles doctor console operations
    public class DoctorMenu
    {
        private readonly DoctorRepository _doctorRepository;

        public DoctorMenu()
        {
            _doctorRepository = new DoctorRepository();
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Doctor Management");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. View Doctors");
                Console.WriteLine("3. Back");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddDoctor();
                }
                else if (choice == "2")
                {
                    ViewDoctors();
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

        private void AddDoctor()
        {
            Doctor doctor = new Doctor();

            Console.Write("Doctor Name: ");
            doctor.DoctorName = Console.ReadLine();

            Console.Write("Contact: ");
            doctor.Contact = Console.ReadLine();

            Console.Write("Consultation Fee: ");
            doctor.ConsultationFee = decimal.Parse(Console.ReadLine());

            Console.Write("Specialty Id: ");
            doctor.SpecialtyId = int.Parse(Console.ReadLine());

            _doctorRepository.AddDoctor(doctor);

            Console.WriteLine("Doctor added successfully.");
        }

        private void ViewDoctors()
        {
            var doctors = _doctorRepository.GetAllDoctors();

            foreach (var d in doctors)
            {
                Console.WriteLine(d.DoctorId + " | " + d.DoctorName + " | Fee: " + d.ConsultationFee);
            }
        }
    }
}
