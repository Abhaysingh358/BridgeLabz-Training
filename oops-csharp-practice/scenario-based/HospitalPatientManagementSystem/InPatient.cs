using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.HospitalPatientManagementSystem
{
    internal class InPatient : Patient , IPayable
    {
        private int TotalDays;
        private double ChargesPerday;

        public InPatient(int id, string name, string description, int days, double charge)
            : base(id, name, description)
        {
            this.TotalDays = days;
            this.ChargesPerday = charge;
        }

        public double Billing()
        {
            return TotalDays*ChargesPerday;
        }

        public override string ToString()
        {
            return base.ToString() +
                $", Total Days : {TotalDays} , Charges Per Day : {ChargesPerday}";
        }
    }
}
