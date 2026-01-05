using System;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.HospitalPatientManagementSystem
{
    internal class Doctor
    {
        private int DoctorId;
        private string DoctorName;
        private string Speciality;
        private Patient patient;

        public Doctor(int doctorId, string doctorName, string speciality, Patient patient)
        {
            this.DoctorId = doctorId;
            this.DoctorName = doctorName;
            this.Speciality = speciality;
            this.patient = patient;
        }

        public int GetDoctorId()

        {
            return DoctorId;
        }
        public string GetDoctorName()
        {
            return DoctorName;
        }

        public string GetSpeciality()
        {
            return Speciality;
        }

        public Patient GetPatient()
        {
            return patient;
        }
        public void SetDoctorId(int doctorId)
        {
            this.DoctorId = doctorId;
        }

        public void SetDoctorName(string doctorName)
        {
            this.DoctorName = doctorName;
        }

        public void SetSpeciality(string speciality)
        {
            this.Speciality = speciality;
        }
        public void SetPatient(Patient patient)
        {
            this.patient = patient;
        }

        public override string ToString()
        {
            return $"Doctor ID : {DoctorId}, Name : {DoctorName}, Speciality : {Speciality}," +
                $" Patient : {patient}";
        }
    }
}
