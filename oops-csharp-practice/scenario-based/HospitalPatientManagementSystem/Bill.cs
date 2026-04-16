using System;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.HospitalPatientManagementSystem
{
    internal class Bill
    {
        private string BillId;
        private string PatientName;
        private double BillAmount;
        private string BillType;

        public Bill(string billId, string patientName, double billAmount, string billType)
        {
            this.BillId = billId;
            this.PatientName = patientName;
            this.BillAmount = billAmount;
            this.BillType = billType;
        }


        public override string ToString()
        {
            return $"Bill ID : {BillId}, Patient : {PatientName}, " +
                $"Type : {BillType}, Amount : {BillAmount}";
        }
    }
}
