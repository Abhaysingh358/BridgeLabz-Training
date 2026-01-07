using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.RentalVehicle
{
    internal class Car:Vehicle
    {
        static double ratePerDay = 500;
        
        public Car(long id, string wheeler) : base(id, wheeler)
        {
        }
        public override void Display()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Wheeler Type: " + wheeler);
            Console.WriteLine("Rate per Day: " + ratePerDay);
        }
        public override double CalculateRent(Customer customer)
        {
            return customer.days * ratePerDay;
        }
    }
}
