using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.RentalVehicle
{
    internal class Customer
    {
        public string name;
        public long customerId;
        public int days;
        public Customer(string name, long customerId, int days)
        {
            this.name = name;
            this.customerId = customerId;
            this.days = days;
        }
    }
}
