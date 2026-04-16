using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.hybrid_inheritence.VehicleManagementSystem
{
    internal class PetrolVehicle : Vehicle, Refuelable
    {
        int FuelTankCapacity;

        public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity) : base(maxSpeed, model)

        {
            this.FuelTankCapacity = fuelTankCapacity;
        }

        public string Refuel()
        {
            return "Refueling petrol vehicle";
        }

        public override string ToString()
        {
            return "Petrol Vehicle : " + base.ToString() + $" , Fuel Tank : {FuelTankCapacity} liters";


        }
    }
}
