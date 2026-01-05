using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.VehicleRentalApp
{
    internal class Customer
    {
        private int CustomerId;
        private string CustomerName;
        private string CustomerContact;

        public Customer(int id, string name, string contact)
        {
            CustomerId = id;
            CustomerName = name;
            CustomerContact = contact;
        }

        public override string ToString()
        {
            return $"Customer ID : {CustomerId}, Name : {CustomerName}, Contact : {CustomerContact}";
        }
    }
}

