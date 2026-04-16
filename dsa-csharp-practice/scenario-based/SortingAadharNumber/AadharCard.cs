using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.SortingAadharNumber
{
    public class AadharCard
    {
        private string aadharNumber;
        private string name;

        public string AadharNumber
        {
            get { return aadharNumber; }
            set { aadharNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public AadharCard(string aadharNumber, string name)
        {
            this.aadharNumber = aadharNumber;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Aadhar: " + aadharNumber + " | Name: " + name);
        }
    }
}
