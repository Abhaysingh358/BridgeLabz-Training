using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{
    internal class Vehicle
    {
        private string VehicleNumber;
        //private readonly DateTime EntryTime;
        //private DateTime EnteredRoundAbout;

        //public Vehicle()
        //{
        //    EntryTime = DateTime.Now;
        //}

        public string GetVehicleNumber() { return VehicleNumber; }
        public void SetVehicleNumber(string VehicleNumber)
        {
            this.VehicleNumber = VehicleNumber;
        }

        //public DateTime GetEntryTime() { return EntryTime; }

        //public DateTime GetEnteredRoundAbout() { return EnteredRoundAbout; }

        // this method sets entered roundabout time when vehicle actually enters roundabout
        //public void SetEnteredRoundAboutTime()
        //{
        //    EnteredRoundAbout = DateTime.Now;
        //}

        public override string ToString()
        {
            return $"Vehicle Number : {VehicleNumber} ";
                
        }
    }
}
