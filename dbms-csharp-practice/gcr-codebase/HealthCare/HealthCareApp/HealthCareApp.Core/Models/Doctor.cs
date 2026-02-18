namespace HealthCareApp.Core.Models
{
    // Represents Doctors table
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string DoctorName { get; set; }

        public string Contact { get; set; }

        public decimal ConsultationFee { get; set; }

        public int SpecialtyId { get; set; }

        public bool IsActive { get; set; }
    }
}
