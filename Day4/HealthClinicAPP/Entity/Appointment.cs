using System;

namespace HealthClinicApp.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan TimeSlot { get; set; }
        public string Symptoms { get; set; }
        public string Status { get; set; }

        // Constructor for Insertion (No ID)
        public Appointment(int doctorId, int patientId, DateTime appointmentDate, TimeSpan timeSlot, string symptoms, string status)
        {
            DoctorId = doctorId;
            PatientId = patientId;
            AppointmentDate = appointmentDate;
            TimeSlot = timeSlot;
            Symptoms = symptoms;
            Status = status;
        }

        // Overloaded Constructor for Updates 
        public Appointment(int appointmentId, int doctorId, int patientId, DateTime appointmentDate, TimeSpan timeSlot, string symptoms, string status)
        {
            AppointmentId = appointmentId;
            DoctorId = doctorId;
            PatientId = patientId;
            AppointmentDate = appointmentDate;
            TimeSlot = timeSlot;
            Symptoms = symptoms;
            Status = status;
        }
    }
}
