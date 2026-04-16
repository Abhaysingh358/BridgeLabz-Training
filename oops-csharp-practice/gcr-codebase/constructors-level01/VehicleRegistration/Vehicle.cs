using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.VehicleRegistration
{
    internal class Vehicle
    {
        string ownerName;
        string vehicleType;

        static double registrationFee = 5000;

        public void Input()
        {
            Console.WriteLine("Enter Owner Name");
            ownerName = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Type");
            vehicleType = Console.ReadLine();
        }


        public static void ChangeRegistrationFee()
        {
            Console.WriteLine("Enter the registration fees to change");
             registrationFee = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Vehicle Name : {ownerName}");
            Console.WriteLine($"Vehicle Type : {vehicleType}");
            Console.WriteLine("Registration Fee : " + registrationFee + "rs.");

        }



    }
}
