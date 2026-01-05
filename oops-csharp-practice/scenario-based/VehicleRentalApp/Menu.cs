using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.VehicleRentalApp
{
    internal class Menu
    {

        private Customer customer;
        private Vehicle vehicle;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("<===== VEHICLE RENTAL APPLICATION =====>");
                Console.WriteLine("1. Create Customer");
                Console.WriteLine("2. Rent Bike");
                Console.WriteLine("3. Rent Car");
                Console.WriteLine("4. Rent Truck");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice : ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateCustomer();
                        break;

                    case 2:
                        RentVehicle("Bike");
                        break;

                    case 3:
                        RentVehicle("Car");
                        break;

                    case 4:
                        RentVehicle("Truck");
                        break;

                    case 5:
                        Console.WriteLine("Application closed.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void CreateCustomer()
        {
            Console.Write("Customer Id : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Customer Name : ");
            string name = Console.ReadLine();

            Console.Write("Customer Contact : ");
            string contact = Console.ReadLine();

            customer = new Customer(id, name, contact);
            Console.WriteLine("Customer created successfully.");
        }

        private void RentVehicle(string type)
        {
            if (customer == null)
            {
                Console.WriteLine("Please create customer first.");
                return;
            }

            Console.Write("Enter Vehicle Number : ");
            string number = Console.ReadLine();

            Console.Write("Enter number of days : ");
            int days = int.Parse(Console.ReadLine());

            // polymorphism: base class reference
            if (type == "Bike")
                vehicle = new Bike(number);
            else if (type == "Car")
                vehicle = new Car(number);
            else
                vehicle = new Truck(number);

            Console.WriteLine("<--- RENT DETAILS --->");
            Console.WriteLine(customer);
            Console.WriteLine(vehicle.DisplayInfo(days));
        }
    }
}
