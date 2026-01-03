using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.VehicleRegistrationSystem
{
    internal class Vehicle
    {
        static double RegistrationFee = 2500;
        static int TotalVehicles = 0;

        readonly string RegistrationNumber;

        string OwnerName;
        string VehicleType;

        public Vehicle(string registrationNumber, string ownerName, string vehicleType)
        {
            this.RegistrationNumber = registrationNumber;
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
            TotalVehicles++;
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }

        public static void DisplayTotalVehicles()
        {
            Console.WriteLine($"Total Vehicles Registered : {TotalVehicles}");
        }

        public void Display()
        {
            Console.WriteLine("Vehicle Registration Details");
            Console.WriteLine($"Registration No : {RegistrationNumber}");
            Console.WriteLine($"Owner Name      : {OwnerName}");
            Console.WriteLine($"Vehicle Type    : {VehicleType}");
            Console.WriteLine($"Registration Fee: {RegistrationFee}");
            Console.WriteLine();
        }
    }
}
