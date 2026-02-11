using Microsoft.Data.SqlClient;
namespace DBConnect
{
    public static class DbConnectionUtil
    {
        private static readonly string connectionString = "Server=localhost\\SQLExpress;Database=HealthClinicApp;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}