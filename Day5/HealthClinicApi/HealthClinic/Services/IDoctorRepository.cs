using HealthClinic.Models;

namespace HealthClinic.Services
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAll();
    }
}