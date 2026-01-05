using System;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.HospitalPatientManagementSystem
{
    internal class Patient
    {
        private int PatientId;
        private string PatientName;
        private string PatientDescription;
        public Patient(int patientId, string patientName, string patientDescription)
        {
            this.PatientId = patientId;
            this.PatientName = patientName;
            this.PatientDescription = patientDescription;
        }

        public int GetId()
        {
            return PatientId;
        }
        public string GetName()
        {
            return PatientName;
        }

        public string GetDescription()
        {
            return PatientDescription;
        }

        public void SetId(int patientId)
        {
            this.PatientId = patientId;
        }

        public void SetName(string patientName)
        {
            this.PatientName = patientName;
        }

        public void SetDescription(string patientDescription)
        {
            this.PatientDescription = patientDescription;
        }

        public override string ToString()
        {
            return $"Patient ID : {PatientId}, Name : {PatientName}," +
                $" Description : {PatientDescription}";
        }
    }
}
