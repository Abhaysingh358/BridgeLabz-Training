using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{
    internal class TrafficUtility : ITrafficUtility
    {
        private VehicleQueue WaitingQueue;
        private RoundAboutLinkedList RoundAbout;

        public TrafficUtility()
        {
            Console.Write("Enter Roundabout Capacity : ");
            int roundAboutSize = int.Parse(Console.ReadLine());

            Console.Write("Enter Waiting Queue Capacity : ");
            int queueSize = Convert.ToInt32(Console.ReadLine());

            RoundAbout = new RoundAboutLinkedList(roundAboutSize);
            WaitingQueue = new VehicleQueue(queueSize);
        }

        // this method takes vehicle details and tries to enter into-
        // roundabout otherwise goes to queue
        public void EnterVehicle()
        {
            Console.Write("\nEnter Vehicle Number : ");
            string vehicleNumber = Console.ReadLine();

            Vehicle vehicle = new Vehicle();
            vehicle.SetVehicleNumber(vehicleNumber);

            if (!RoundAbout.IsFull())
            {
                //vehicle.SetEnteredRoundAboutTime(); if needed this method we will use further
                // currently vehicle number is enough

                RoundAbout.AddVehicle(vehicle);
                Console.WriteLine("Vehicle entered into Roundabout successfully");
            }
            else
            {
                if (!WaitingQueue.IsFull())
                {
                    WaitingQueue.Enqueue(vehicle);
                    Console.WriteLine("Roundabout is full, Vehicle added to Waiting Queue");
                }
                else
                {
                    Console.WriteLine("Waiting Queue is full (Overflow) - Vehicle cannot enter");
                }
            }
        }

        // this method removes a vehicle from roundabout and moves one vehicle from queue-
        // to roundabout if possible
        public void ExitVehicle()
        {
            Console.Write("\nEnter Vehicle Number to Exit : ");
            string vehicleNumber = Console.ReadLine();

            if (RoundAbout.IsEmpty())
            {
                Console.WriteLine("Roundabout is empty - no vehicle to exit");
                return;
            }

            bool isRemoved = RoundAbout.RemoveVehicle(vehicleNumber);

            if (isRemoved)
            {
                Console.WriteLine("Vehicle exited from Roundabout");

                if (!WaitingQueue.IsEmpty())
                {
                    Vehicle nextVehicle = WaitingQueue.Dequeue();
                    //nextVehicle.SetEnteredRoundAboutTime(); do not need for now
                    RoundAbout.AddVehicle(nextVehicle);

                    Console.WriteLine("One vehicle moved from Waiting Queue to Roundabout");
                }
            }
            else
            {
                Console.WriteLine("Vehicle not found in Roundabout");
            }
        }

        // this method displays roundabout vehicles
        public void DisplayRoundAbout()
        {
            RoundAbout.DisplayRoundAbout();
        }

        // this method displays waiting queue vehicles
        public void DisplayWaitingQueue()
        {
            WaitingQueue.DisplayVehiclesInQueue();
        }

        // this method displays complete traffic state
        public void DisplayAllState()
        {
            Console.WriteLine("\n========== CURRENT TRAFFIC STATE ==========");
            DisplayRoundAbout();
            DisplayWaitingQueue();
            Console.WriteLine();
        }
    }

}

