using HealthCareApp.Core.Models;

namespace HealthCareApp.Core.Interfaces
{
    // This interface defines patient operations
    public interface IPatientRepository
    {
        // Insert new patient
        void AddPatient(Patient patient);

        // Update existing patient
        void UpdatePatient(Patient patient);

        // Search patient by name, phone or id
        List<Patient> SearchPatient(string searchValue);

        // Get all patients
        List<Patient> GetAllPatients();
    }
}
