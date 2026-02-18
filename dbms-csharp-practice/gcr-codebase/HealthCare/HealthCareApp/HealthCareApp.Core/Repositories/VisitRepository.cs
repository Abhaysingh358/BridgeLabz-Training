using Microsoft.Data.SqlClient;
using System.Data;
using HealthCareApp.Core.Models;
using HealthCareApp.Core.Interfaces;
using HealthCareApp.Core.Utilities;

namespace HealthCareApp.Core.Repositories
{
    // Handles visit database operations
    public class VisitRepository : IVisitRepository
    {
        private readonly DbHelper _dbHelper;

        public VisitRepository()
        {
            _dbHelper = new DbHelper();
        }

        // Record visit using stored procedure
        public void RecordVisit(Visit visit)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterInsertationRecordVisit", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AppointmentId", visit.AppointmentId);
                cmd.Parameters.AddWithValue("@Diagnosis", visit.Diagnosis);
                cmd.Parameters.AddWithValue("@Notes", visit.Notes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get all visits
        public List<Visit> GetAllVisits()
        {
            List<Visit> visits = new List<Visit>();

            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Visits", conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Visit visit = new Visit();

                        visit.VisitId = (int)reader["VisitId"];
                        visit.AppointmentId = (int)reader["AppointmentId"];
                        visit.Diagnosis = reader["Diagnosis"].ToString();
                        visit.Notes = reader["Notes"].ToString();
                        visit.VisitDate = (DateTime)reader["VisitDate"];

                        visits.Add(visit);
                    }
                }
            }

            return visits;
        }
    }
}
