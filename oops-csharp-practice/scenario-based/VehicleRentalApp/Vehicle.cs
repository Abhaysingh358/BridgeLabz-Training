using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.VehicleRentalApp
{
    internal abstract class Vehicle : IRentable
    {
        protected string VehicleNumber;
        protected string VehicleName;
        protected string VehicleType;
        protected double VehicleRent;

        public Vehicle(string number, string name, string type, double rent)
        {
            VehicleNumber = number;
            VehicleName = name;
            VehicleType = type;
            VehicleRent = rent;
        }

        // abstraction
        public abstract double Rent(int days);

        // polymorphic display method
        public virtual string DisplayInfo(int days)
        {
            return $"Vehicle Number : {VehicleNumber}\n" +
                   $"Vehicle Name   : {VehicleName}\n" +
                   $"Vehicle Type   : {VehicleType}\n" +
                   $"Rent Per Day   : {VehicleRent}\n" +
                   $"Days           : {days}";
        }
    }
}
