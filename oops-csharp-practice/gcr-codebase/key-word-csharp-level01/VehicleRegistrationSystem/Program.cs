using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.key_word_csharp_level01.VehicleRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("MP32AB1234", "Abhay Singh", "Car");
            Vehicle v2 = new Vehicle("BH01XY5678", "Ravi Kumar", "Bike");

            // using is operator before displaying
            if (v1 is Vehicle)
            {
                v1.Display();
            }

            if (v2 is Vehicle)
            {
                v2.Display();
            }

            // update registration fee
            Vehicle.UpdateRegistrationFee(3000);

            // display again after fee update
            if (v1 is Vehicle)
            {
                v1.Display();
            }

           

            Vehicle.DisplayTotalVehicles();
        }
    }
}
