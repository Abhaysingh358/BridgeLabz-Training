using HealthCareApp.Core.Models;
using HealthCareApp.Core.Repositories;

namespace HealthCareApp.Core.Menus
{
    // Handles appointment console operations
    public class AppointmentMenu
    {
        private readonly AppointmentRepository _appointmentRepository;

        public AppointmentMenu()
        {
            _appointmentRepository = new AppointmentRepository();
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Appointment Management");
                Console.WriteLine("1. Book Appointment");
                Console.WriteLine("2. View Appointments");
                Console.WriteLine("3. Back");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    BookAppointment();
                }
                else if (choice == "2")
                {
                    ViewAppointments();
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

        private void BookAppointment()
        {
            Appointment appointment = new Appointment();

            Console.Write("Patient Id: ");
            appointment.PatientId = int.Parse(Console.ReadLine());

            Console.Write("Doctor Id: ");
            appointment.DoctorId = int.Parse(Console.ReadLine());

            Console.Write("Appointment Date (yyyy-mm-dd HH:mm): ");
            appointment.AppointmentDate = DateTime.Parse(Console.ReadLine());

            _appointmentRepository.BookAppointment(appointment);

            Console.WriteLine("Appointment booked successfully.");
        }

        private void ViewAppointments()
        {
            var appointments = _appointmentRepository.GetAllAppointments();

            foreach (var a in appointments)
            {
                Console.WriteLine(a.AppointmentId + " , Patient: " + a.PatientId +
                                  " , Doctor: " + a.DoctorId +
                                  " , Date: " + a.AppointmentDate +
                                  " , Status: " + a.Status);
            }
        }
    }
}
