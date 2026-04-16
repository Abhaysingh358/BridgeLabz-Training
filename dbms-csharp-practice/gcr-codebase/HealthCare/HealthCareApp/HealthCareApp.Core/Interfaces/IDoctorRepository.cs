using HealthCareApp.Core.Models;

namespace HealthCareApp.Core.Interfaces
{
    // Defines doctor operations
    public interface IDoctorRepository
    {
        void AddDoctor(Doctor doctor);

        List<Doctor> GetAllDoctors();
    }
}
