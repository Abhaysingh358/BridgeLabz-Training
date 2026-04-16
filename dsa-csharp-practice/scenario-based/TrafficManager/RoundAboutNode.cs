using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.TrafficManager
{
    internal class RoundAboutNode
    {
        private Vehicle vehicle;
        private RoundAboutNode next;

        public RoundAboutNode(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            this.next = null;
        }

        // this method returns vehicle object
        public Vehicle GetVehicle()
        {
            return vehicle;
        }

        // this method sets vehicle object
        public void SetVehicle(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        // this method returns next node reference
        public RoundAboutNode GetNext()
        {
            return next;
        }

        // this method sets next node reference
        public void SetNext(RoundAboutNode next)
        {
            this.next = next;
        }
    }
}
