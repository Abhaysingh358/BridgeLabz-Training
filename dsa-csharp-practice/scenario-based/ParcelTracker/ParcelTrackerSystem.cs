using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ParcelTracker
{
    internal class ParcelTrackerSystem : IParcelTracker
    {
        private Parcel parcel;
        private TrackingList trackingList;

        public void AddParcelDetails()
        {
            parcel = new Parcel();
            trackingList = new TrackingList();

            Console.WriteLine("Enter the Parcel Id");
            int id = int.Parse(Console.ReadLine());

            if(id >= 0)
            {
                parcel.SetParcelId(id);

            }
            else
            {
                Console.WriteLine("Id Can not be NUll");
                return;
            }


            Console.WriteLine("Enter the Parcel Name");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name Can not be NUll");
                return;  

            }

            else
            {
                parcel.SetParcelName(name);
            }

            Console.WriteLine("Enter the Parcel Delivary Adddress");
            string deliveryAdress = Console.ReadLine();

            if (string.IsNullOrEmpty(deliveryAdress))
            {
                Console.WriteLine("Delivery Address Can not be Null");
                return;
            }
            else
            {
                parcel.SetDeliveryAddress(deliveryAdress);
            }

        }
        

        public void AddParcelCheckPoint()
        {
            if (parcel == null)
            {
                Console.WriteLine("Add Parcel Details First");
                return;
            }

            if (trackingList == null)
            {
                trackingList = new TrackingList();
            }

            Console.WriteLine("Enter the stage name to update checkpoints");
            string stageName = Console.ReadLine();

            if (string.IsNullOrEmpty(stageName))
            {
                Console.WriteLine("Stage can not be empty , enter the valid stage name");
                return;
            }

            trackingList.AddCheckPoint(stageName);
        }

        // displaying Parcel Details
        public void DisplayParcelDetails()
        {
            if (parcel == null)
            {
                Console.WriteLine("Add Parcel Details First");
                return;
            }

            Console.WriteLine(parcel.ToString());
        }


        //dispaly Parcel Tracking 
        public void DisplayParcelTracking()
        {
            if (parcel == null)
            {
                Console.WriteLine("Add Parcel Details First");
                return;
            }

            if (trackingList == null)
            {
                Console.WriteLine("Tracking Not Started Yet");
                return;
            }

            trackingList.DisplayTracking();
        }


        //Show Current status

        public void ShowCurrentStatus()
        {
            if (parcel == null)
            {
                Console.WriteLine("Add Parcel Details First");
                return;
            }

            if (trackingList == null || trackingList.Tail == null)
            {
                Console.WriteLine("Tracking Not Started Yet");
                return;
            }

            Console.WriteLine("Current Parcel Status : " + trackingList.GetCurrentStatus());
        }




    }
}
