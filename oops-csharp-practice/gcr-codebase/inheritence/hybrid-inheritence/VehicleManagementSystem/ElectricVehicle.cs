using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.inheritence.hybrid_inheritence.VehicleManagementSystem
{
    internal class ElectricVehicle : Vehicle
    {
        int BatteryCapacity;

        public ElectricVehicle(int maxSpeed, string model, int batteryCapacity) : base(maxSpeed, model)

        {
            this.BatteryCapacity = batteryCapacity;
        }

        public string Charge()
        {
            return "Charging electric vehicle";
        }

        public override string ToString()
        {
            return "Electric Vehicle : " + base.ToString() + $" , Battery : {BatteryCapacity} kWh";


        }
    }
}
