using Microsoft.Data.SqlClient;
using System.Data;
using HealthCareApp.Core.Interfaces;
using HealthCareApp.Core.Models;
using HealthCareApp.Core.Utilities;

namespace HealthCareApp.Core.Repositories
{
    // This class implements patient database operations
    public class PatientRepository : IPatientRepository
    {
        private readonly DbHelper _dbHelper;

        // Constructor
        public PatientRepository()
        {
            _dbHelper = new DbHelper();
        }

        // Add patient using stored procedure
        public void AddPatient(Patient patient)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterInsertationRegisterPatient", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Pass parameters to stored procedure
                cmd.Parameters.AddWithValue("@FullName", patient.FullName);
                cmd.Parameters.AddWithValue("@DOB", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Update patient
        public void UpdatePatient(Patient patient)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterUpdationPatientDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PatientId", patient.PatientId);
                cmd.Parameters.AddWithValue("@FullName", patient.FullName);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Address", patient.Address);
                cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Search patient
        public List<Patient> SearchPatient(string searchValue)
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterSelectionSearchPatient", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient();

                        patient.PatientId = (int)reader["PatientId"];
                        patient.FullName = reader["FullName"].ToString();
                        patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                        patient.Phone = reader["Phone"].ToString();
                        patient.Email = reader["Email"].ToString();
                        patient.Address = reader["Address"].ToString();
                        patient.BloodGroup = reader["BloodGroup"].ToString();

                        patients.Add(patient);
                    }
                }
            }

            return patients;
        }

        // Get all patients
        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Patients", conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient();

                        patient.PatientId = (int)reader["PatientId"];
                        patient.FullName = reader["FullName"].ToString();
                        patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                        patient.Phone = reader["Phone"].ToString();
                        patient.Email = reader["Email"].ToString();
                        patient.Address = reader["Address"].ToString();
                        patient.BloodGroup = reader["BloodGroup"].ToString();

                        patients.Add(patient);
                    }
                }
            }

            return patients;
        }
    }
}
