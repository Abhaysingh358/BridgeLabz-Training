using Microsoft.Data.SqlClient;

namespace HealthCareApp.Core.Utilities
{
    public class DbHelper
    {
        private readonly string _connectionString =
            "Server=localhost\\SQLEXPRESS;Database=healthCareDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
