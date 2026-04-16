using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.RentalVehicle
{
    internal class Menu
    {
        public Customer CustomerDetails()
        {
            Console.WriteLine("Customer Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Customer ID:");
            long customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Days to Rent:");
            int days = Convert.ToInt32(Console.ReadLine());
            Customer customer = new Customer(name, customerId, days);

            return customer;
        }
        public void Entry()
        {
            while (true)
            {
                Console.WriteLine("Rental Vehicle Menu");
                Console.WriteLine("1. Rent a Bike");
                Console.WriteLine("2. Rent a Car");
                Console.WriteLine("3. Rent a Truck");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RentBike();
                        break;
                    case 2:
                        RentCar();
                        break;
                    case 3:
                        RentTruck();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                if (choice == 4)
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }
            }
        }

        public void RentBike()
        {
            long id = Convert.ToInt32(Console.ReadLine());
            string type = Console.ReadLine();
            Vehicle bike = new Bike(id, type);
            bike.Display();
            Customer customer = CustomerDetails();
            Console.WriteLine("Total Rent for Bike: " + bike.CalculateRent(customer));
        }
        public void RentCar()
        {
            long id = Convert.ToInt32(Console.ReadLine());
            string type = Console.ReadLine();
            Vehicle car = new Car(id, type);
            car.Display();
            Customer customer = CustomerDetails();
            Console.WriteLine("Total Rent for Bike: " + car.CalculateRent(customer));
        }
        public void RentTruck()
        {
            long id = Convert.ToInt32(Console.ReadLine());
            string type = Console.ReadLine();
            Vehicle truck = new Truck(id, type);
            truck.Display();
            Customer customer = CustomerDetails();
            Console.WriteLine("Total Rent for Bike: " + truck.CalculateRent(customer));
        }
    }
}
