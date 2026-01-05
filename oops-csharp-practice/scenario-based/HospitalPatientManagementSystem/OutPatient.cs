using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.HospitalPatientManagementSystem
{
    internal class OutPatient : Patient , IPayable
    {
        private double ConsultationFee;
        private double MedicineFee;

        public OutPatient(int id,string name , string description , double consultationFee, double medicineFee)
            : base( id, name, description)
        {
            this.ConsultationFee = consultationFee;
            this.MedicineFee = medicineFee;
        }

        public double Billing()
        {
            return ConsultationFee + MedicineFee;
        }

        public override string ToString()
        {
            return base.ToString() + $" , Consultation Fee : {ConsultationFee} , Medicine Fee : {MedicineFee}" +
                $"Total Fee : {Billing()}";
        }

    }
}
