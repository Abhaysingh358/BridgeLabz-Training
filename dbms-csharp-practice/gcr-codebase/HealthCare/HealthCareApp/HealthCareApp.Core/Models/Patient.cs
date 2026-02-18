namespace HealthCareApp.Core.Models
{
    // This class represents Patient table structure
    public class Patient
    {
        // Primary Key
        public int PatientId { get; set; }

        // Patient full name
        public string FullName { get; set; }

        // Date of birth
        public DateTime DateOfBirth { get; set; }

        // Phone number
        public string Phone { get; set; }

        // Email address
        public string Email { get; set; }

        // Home address
        public string Address { get; set; }

        // Blood group
        public string BloodGroup { get; set; }
    }
}
