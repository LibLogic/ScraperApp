using System.Data.SqlClient;

namespace ScraperApp
{
    class DBConnection
    {
        public static string connectionString = @"Data Source=WINDOWS-10; Initial Catalog=WebScraper; Integrated Security=SSPI";
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}