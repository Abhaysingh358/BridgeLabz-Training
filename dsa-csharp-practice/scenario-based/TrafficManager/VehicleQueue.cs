using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{
    internal class VehicleQueue
    {
        private QueueNode Front;
        private QueueNode Rear;
        private int Count;
        private int Capacity;

        public VehicleQueue(int capacity)
        {
            this.Front = null;
            this.Rear = null;
            this.Count = 0;
            this.Capacity = capacity;
        }

        // method to check whether the queue is empty or not
        public bool IsEmpty()
        {
            return Count == 0;
        }

        // method to check whehther the queue is full or not
        public bool IsFull()
        {
            return Count == Capacity;
        }

        // method to add vehicle When we do enqueue in a queue it always add from rear
        public void Enqueue(Vehicle vehicle)
        {
            // check wether queue is full or not
            if(IsFull())
            {
                Console.WriteLine("Queue Is full , can not store anymore vehicles");
                return;
            }

            QueueNode queueNode = new QueueNode(vehicle);
            if(Front == null)
            {
                Front = queueNode;
                Rear  = queueNode;
            }
            else
            {
               Rear.Next = queueNode;
                Rear = queueNode;
            }
            Count++;

        }

        public Vehicle Dequeue()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Queue is Empty , no vehicle is present");
                
            }
            // front vehicle in remove in normal queue
            Vehicle fronttVehicle = Front.data;
            Front = Front.Next;

            if (Front == null) Rear = null;

            Count--;
            return fronttVehicle;
        }

        // if we have to just see the front vehicle , make peek method to see the front vehicle
        public Vehicle Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Is Empty , No Vehicle in Queue");
            }
            return Front.data;
        }

        // for diplay the vehicles in queue 
        public void DisplayVehiclesInQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Waiting Queue is empty , vehicle is not queue right now");
                return;
            }

            Console.WriteLine("Vehicles in waiting queue is in Front ---> Rear order");
            QueueNode temp = Front;

            while(temp != null)
            {
                Console.WriteLine(temp.data.GetVehicleNumber());
                temp = temp.Next;
            }
        }

        // this method returns total vehicles inside queue
        public int GetCount()
        {
            return Count;
        }
    }
}
