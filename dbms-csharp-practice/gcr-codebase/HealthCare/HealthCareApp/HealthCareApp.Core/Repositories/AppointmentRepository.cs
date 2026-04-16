using Microsoft.Data.SqlClient;
using System.Data;
using HealthCareApp.Core.Models;
using HealthCareApp.Core.Interfaces;
using HealthCareApp.Core.Utilities;

namespace HealthCareApp.Core.Repositories
{
    // Handles appointment database operations
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DbHelper _dbHelper;

        public AppointmentRepository()
        {
            _dbHelper = new DbHelper();
        }

        // Book appointment using stored procedure
        public void BookAppointment(Appointment appointment)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterInsertationBookAppointment", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                cmd.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get all appointments
        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Appointments", conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment();

                        appointment.AppointmentId = (int)reader["AppointmentId"];
                        appointment.PatientId = (int)reader["PatientId"];
                        appointment.DoctorId = (int)reader["DoctorId"];
                        appointment.AppointmentDate = (DateTime)reader["AppointmentDate"];
                        appointment.Status = reader["Status"].ToString();

                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }
    }
}
