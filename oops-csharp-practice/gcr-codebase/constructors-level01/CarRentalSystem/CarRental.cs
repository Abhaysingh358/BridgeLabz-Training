using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.CarRentalSystem
{
    internal class CarRental
    {
        string customerName;
        string carModel;
        int rentalDays;

        public CarRental()
        {
        }

        // copy constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        public void Input()
        {
            Console.WriteLine("Enter Customer Name:");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter Car Model:");
            carModel = Console.ReadLine();

            Console.WriteLine("Enter Rental Days:");
            rentalDays = int.Parse(Console.ReadLine());
        }

        public double CalculateTotalCost()
        {
            double rate = 0;

            if (carModel.ToLower() == "sedan")
            {
                rate = 2000;

            }
            else if (carModel.ToLower() == "suv")
            {
                rate = 3000;

            }
            else if (carModel.ToLower() == "hatchback")
            {
                rate = 1500;

            }
            else
            {
                rate = 1000;
            }

            return rate * rentalDays;
        }

        public void Display()
        {
            Console.WriteLine("\nCar Rental Details");
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Car Model     : " + carModel);
            Console.WriteLine("Rental Days   : " + rentalDays);
            Console.WriteLine("Total Cost    : " + CalculateTotalCost() + "rs.");
        }
    }
}
