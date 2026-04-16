using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{
    // in this class a circular linked list is used as said in question
    internal class RoundAboutLinkedList
    {
        private RoundAboutNode Head;
        private RoundAboutNode Tail;
        private int Count;
        private int Capacity;

        public RoundAboutLinkedList(int capacity)
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
            this.Capacity = capacity;
        }

        // this method checks roundabout is empty or not
        public bool IsEmpty()
        {
            return Count == 0;
        }

        // this method checks roundabout is full or not
        public bool IsFull()
        {
            return Count == Capacity;
        }

        // this method is used add vehicles in roundabout
        public void AddVehicle(Vehicle vehicle)
        {
            if (IsFull())
            {
                Console.WriteLine("RoundAbout is full of Vehicles");
            }

            RoundAboutNode roundAbout = new RoundAboutNode(vehicle);
            if(Head == null)
            {
                Head = roundAbout;
                Tail = roundAbout;
                Tail.SetNext(Head);
            }
            else
            {
                Tail.SetNext(roundAbout);
                Tail = roundAbout;
                Tail.SetNext(Head);
            }

            Count++;
        }

        // this method removes vehicle from roundabout using vehicle number
        public bool RemoveVehicle(string vehicleNumber)
        {
            if (IsEmpty())
            {
                Console.WriteLine("No Vehicle is present");
                return false ;
            }

            RoundAboutNode Current = Head;
            RoundAboutNode Previous = Tail;

            do
            {
                if (Current.GetVehicle().GetVehicleNumber().Equals(vehicleNumber))
                {
                    // if only one vehicle is present
                    if (Head == Tail)
                    {
                        Head = null;
                        Tail = null;
                    }
                    else
                    {
                        // removing head
                        if (Current == Head)
                        {
                            Head = Head.GetNext();
                            Tail.SetNext(Head);
                        }
                        // removing tail
                        else if (Current == Tail)
                        {
                            Tail = Previous;
                            Tail.SetNext(Head);
                        }
                        // removing middle node
                        else
                        {
                            Previous.SetNext(Current.GetNext());
                        }
                    }

                    Count--;
                    return true;
                }

                Previous = Current;
                Current = Current.GetNext();

            } while (Current != Head);

            return false;
        }


        // this method displays all vehicles present in the roundabout
        public void DisplayRoundAbout()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Roundabout is empty");
                return;
            }

            Console.WriteLine("\n---- Roundabout Vehicles (Circular) ----");

            RoundAboutNode temp = Head;
            do
            {
                Console.WriteLine(temp.GetVehicle().GetVehicleNumber());
                temp = temp.GetNext();

            } while (temp != Head);
        }

        // this method returns total vehicles inside roundabout
        public int GetCount()
        {
            return Count;
        }
    }
}

