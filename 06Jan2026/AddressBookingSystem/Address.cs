using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.review.AddressBookingSystem
{
    public class Address
    {
        private int Pin;
        private string Region;
        private string State;
        private string Town;

        public Address(int pin, string region, string state, string town)
        {
            this.Pin = pin;
            this.Region = region;
            this.State = state;
            this.Town = town;
        }

        public int GetPin()
        {
            return Pin;
        }

        public string GetRegion()
        {
            return Region;
        }

        public string GetState()
        {
            return State;
        }

        public string GetTown()
        {
            return Town;
        }

        public override string ToString()
        {
            return $"Pin : {Pin}, Region : {Region}, State : {State}, Town : {Town}";
        }
    }

}
