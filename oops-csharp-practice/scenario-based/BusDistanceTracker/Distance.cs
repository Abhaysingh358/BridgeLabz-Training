using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.BusDistanceTracker
{
    internal class Distance
    {
        static double totalDistance = 0;


        // method to track distance when a bus passes a stop it will added the distance to total distance
        public void AddDistance()
        {
            Console.WriteLine("Add distance ");
            double AddDistance;

            AddDistance = double.Parse(Console.ReadLine());

            if (AddDistance > 0)
            {
                totalDistance += AddDistance;
            }
            else
            {
                Console.WriteLine("Distance can not be negative");
            }
        }
        // method to get off from the bus
        public void GetOff()
        {
            Console.WriteLine($"The total Distanced Traveled : {totalDistance}");
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Bus Distance Tracker");
                Console.WriteLine("1.StayIn");
                Console.WriteLine("2.Add Distance");
                Console.WriteLine("3.Get off ");

                Console.WriteLine("Enter the number");

                    int choice;
                    choice = int.Parse(Console.ReadLine());
                

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Total Distance Traveled : {totalDistance}");
                        break;

                    case 2:
                        AddDistance();
                        break;

                    case 3:
                        GetOff();
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
    }
}
