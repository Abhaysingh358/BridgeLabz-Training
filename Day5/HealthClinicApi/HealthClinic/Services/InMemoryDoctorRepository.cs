using HealthClinic.Models;

namespace HealthClinic.Services
{
    public class InMemoryDoctorRepository : IDoctorRepository
    {
        private List<Doctor> _doctors = new List<Doctor>();

        public IEnumerable<Doctor> GetAll()
        {
            return _doctors;
        }
    }
}