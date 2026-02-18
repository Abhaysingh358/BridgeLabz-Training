using HealthCareApp.Core.Models;
using HealthCareApp.Core.Repositories;

namespace HealthCareApp.Core.Menus
{
    // Handles visit console operations
    public class VisitMenu
    {
        private readonly VisitRepository _visitRepository;

        public VisitMenu()
        {
            _visitRepository = new VisitRepository();
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Visit Management");
                Console.WriteLine("1. Record Visit");
                Console.WriteLine("2. View Visits");
                Console.WriteLine("3. Back");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    RecordVisit();
                }
                else if (choice == "2")
                {
                    ViewVisits();
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

        private void RecordVisit()
        {
            Visit visit = new Visit();

            Console.Write("Appointment Id: ");
            visit.AppointmentId = int.Parse(Console.ReadLine());

            Console.Write("Diagnosis: ");
            visit.Diagnosis = Console.ReadLine();

            Console.Write("Notes: ");
            visit.Notes = Console.ReadLine();

            _visitRepository.RecordVisit(visit);

            Console.WriteLine("Visit recorded successfully.");
        }

        private void ViewVisits()
        {
            var visits = _visitRepository.GetAllVisits();

            foreach (var v in visits)
            {
                Console.WriteLine(v.VisitId + " , Appointment: " +
                                  v.AppointmentId + " , Diagnosis: " +
                                  v.Diagnosis + " , Date: " + v.VisitDate);
            }
        }
    }
}
