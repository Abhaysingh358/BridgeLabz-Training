
using HealthClinicApp.Service;

namespace HealthClinicApp.Menu
{
    public class HealthClinicMenu
    {
        private DoctorService service = new DoctorService();
        private PatientService patientService = new PatientService();
        private AppointmentService appointmentService = new AppointmentService();

            public void HealthMenu(){
            int choice;
            Console.WriteLine("Choose the number from 1 to 3");
            Console.WriteLine("1.Doctor");
            Console.WriteLine("2.Patient");
            Console.WriteLine("3.Appointment");
            
            choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.WriteLine("1.Add Values In Doctor");
                Console.WriteLine("2.Update  Doctor record");
                Console.WriteLine("3.Delete Doctor");

                int choice1 = int.Parse(Console.ReadLine());

                switch (choice1)
                {
                    case 1 : 
                     service.AddDoctor();
                     break;

                    case 2 :
                        service.UpdateDoctor();
                        break;
                    case 3 :
                        service.DeleteDoctor();
                        break;

                    default : 
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
            if (choice == 2)
            {
                 Console.WriteLine("1.Add Patient ");
                Console.WriteLine("2.Update  Patient record");
                Console.WriteLine("3.Delete Patient");

                int choice1 = int.Parse(Console.ReadLine());

                switch (choice1)
                {
                    case 1 : 
                     patientService.AddPatient();
                     break;

                    case 2 :
                        patientService.UpdatePatient();
                        break;
                    case 3 :
                        patientService.DeletePatient();
                        break;

                    default : 
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }

            if (choice == 3)
            {
                Console.WriteLine("1.Book Apppointment");
                Console.WriteLine("2.Update  Appointment");
                Console.WriteLine("3.Delete Appointment");
                  int choice1 = int.Parse(Console.ReadLine());

                switch (choice1)
                {
                    case 1 : 
                     appointmentService.CreateAppointment();
                     break;

                    // case 2 :
                    //     patientService.UpdatePatient();
                    //     break;
                    // case 3 :
                    //     patientService.DeletePatient();
                    //     break;

                    default : 
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

    }
}