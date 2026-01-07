using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.RentalVehicle
{
    abstract class Vehicle:IRentable
    {
        protected long Id;
        protected string wheeler;

        protected Vehicle(long id, string wheeler)
        {
            this.Id = id;
            this.wheeler = wheeler;
        }

        public abstract void Display();
        public abstract double CalculateRent(Customer customer);
    }
}
