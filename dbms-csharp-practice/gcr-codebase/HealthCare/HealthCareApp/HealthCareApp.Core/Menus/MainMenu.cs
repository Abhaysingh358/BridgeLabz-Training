using HealthCareApp.Core.Menus;

namespace HealthCareApp.Core.Menus
{
    // This class handles the main navigation of the system
    public class MainMenu
    {
        private readonly PatientMenu _patientMenu;
        private readonly DoctorMenu _doctorMenu;
        private readonly AppointmentMenu _appointmentMenu;
        private readonly VisitMenu _visitMenu;
        private readonly BillingMenu _billingMenu;

        // Constructor initializes all menus
        public MainMenu()
        {
            _patientMenu = new PatientMenu();
            _doctorMenu = new DoctorMenu();
            _appointmentMenu = new AppointmentMenu();
            _visitMenu = new VisitMenu();
            _billingMenu = new BillingMenu();
        }

        // Displays main system menu
        public void Show()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Health Care Management System");
                Console.WriteLine("1. Patient Management");
                Console.WriteLine("2. Doctor Management");
                Console.WriteLine("3. Appointment Management");
                Console.WriteLine("4. Visit Management");
                Console.WriteLine("5. Billing Management");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                    _patientMenu.Show();
                else if (choice == "2")
                    _doctorMenu.Show();
                else if (choice == "3")
                    _appointmentMenu.Show();
                else if (choice == "4")
                    _visitMenu.Show();
                else if (choice == "5")
                    _billingMenu.Show();
                else if (choice == "6")
                    break;
                else
                    Console.WriteLine("Invalid choice.");
            }
        }
    }
}
