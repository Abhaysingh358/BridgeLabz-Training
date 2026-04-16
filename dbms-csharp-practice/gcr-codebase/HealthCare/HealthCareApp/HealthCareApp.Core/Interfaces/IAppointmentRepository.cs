using HealthCareApp.Core.Models;

namespace HealthCareApp.Core.Interfaces
{
    // Defines appointment operations
    public interface IAppointmentRepository
    {
        void BookAppointment(Appointment appointment);

        List<Appointment> GetAllAppointments();
    }
}
