using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.VehicleRentalApp
{
    internal class Truck : Vehicle
    {
        public Truck(string number)
            : base(number, "Truck", "Heavy Vehicle", 2000)
        {
        }

        public override double Rent(int days)
        {
            return VehicleRent * days;
        }

        // overriding display method
        public override string DisplayInfo(int days)
        {
            return base.DisplayInfo(days) +
                   $"Total Rent     : {Rent(days)}";
        }
    }
}

