using Microsoft.Data.SqlClient;
using System.Data;
using HealthCareApp.Core.Models;
using HealthCareApp.Core.Interfaces;
using HealthCareApp.Core.Utilities;

namespace HealthCareApp.Core.Repositories
{
    // Handles billing database operations
    public class BillingRepository : IBillingRepository
    {
        private readonly DbHelper _dbHelper;

        public BillingRepository()
        {
            _dbHelper = new DbHelper();
        }

        // Generate bill using stored procedure
        public void GenerateBill(int visitId)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterInsertationGenerateBill", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VisitId", visitId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Record payment
        public void RecordPayment(int billId, decimal amount, string paymentMode)
        {
            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SPAfterUpdationRecordPayment", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BillId", billId);
                cmd.Parameters.AddWithValue("@PaymentMode", paymentMode);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get all bills
        public List<Bill> GetAllBills()
        {
            List<Bill> bills = new List<Bill>();

            using (SqlConnection conn = _dbHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Bills", conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bill bill = new Bill();

                        bill.BillId = (int)reader["BillId"];
                        bill.VisitId = (int)reader["VisitId"];
                        bill.TotalAmount = (decimal)reader["TotalAmount"];
                        bill.PaymentStatus = reader["PaymentStatus"].ToString();

                        if (reader["PaymentDate"] != DBNull.Value)
                            bill.PaymentDate = (DateTime)reader["PaymentDate"];

                        bills.Add(bill);
                    }
                }
            }

            return bills;
        }
    }
}
