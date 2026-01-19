using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.ParcelTracker
{
    internal class Parcel
    {
        private int ParcelId;
        private string ParcelName;
        private string DeliveryAddress;

        public int GetParcelId() { return ParcelId; }
        public void SetParcelId(int parcelId)
        {
            this.ParcelId = parcelId;
        }

        public string GetParcelName() { return ParcelName; }

        public void SetParcelName(string name)
        {
            this.ParcelName = name;
        }

        public string GetDeliveryAddress() { 
            return DeliveryAddress; 
        }

        public void SetDeliveryAddress(string address) 
        { 
            this.DeliveryAddress = address;
        }

        public override string ToString()
        {
            return $"Parcel--> Parcel Id : {ParcelId}\n" +
                $"Parcel Name : {ParcelName}\n" +
                $"Delivery Address : {DeliveryAddress}";
        }
    }
}
