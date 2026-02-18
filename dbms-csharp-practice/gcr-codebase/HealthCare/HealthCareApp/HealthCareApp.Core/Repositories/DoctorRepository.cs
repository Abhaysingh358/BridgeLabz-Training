using Microsoft.Data.SqlClient;
using System.Data;
using HealthCareApp.Core.Models;
using HealthCareApp.Core.Interfaces;
using HealthCareApp.Core.Utilities;

namespace HealthCareApp.Core.Repositories
{
    // Handles doctor database operations
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DbHelper _dbHelper;

        public DoctorRepository()
        {
            _dbHelper = new DbHelper();
        }

        // Add doctor using stored procedure
        public void AddDoctor(Doctor doctor)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterInsertationDoctorProfile", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                cmd.Parameters.AddWithValue("@Contact", doctor.Contact);
                cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);
                cmd.Parameters.AddWithValue("@SpecialtyId", doctor.SpecialtyId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get all doctors
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Doctors", conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor();

                        doctor.DoctorId = (int)reader["DoctorId"];
                        doctor.DoctorName = reader["DoctorName"].ToString();
                        doctor.Contact = reader["Contact"].ToString();
                        doctor.ConsultationFee = (decimal)reader["ConsultationFee"];
                        doctor.SpecialtyId = (int)reader["SpecialtyId"];
                        doctor.IsActive = (bool)reader["IsActive"];

                        doctors.Add(doctor);
                    }
                }
            }

            return doctors;
        }
    }
}
