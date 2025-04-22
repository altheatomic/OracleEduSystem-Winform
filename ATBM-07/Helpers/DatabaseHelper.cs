using Oracle.ManagedDataAccess.Client;

namespace ATBM_07.Helpers
{
    public static class DatabaseHelper
    {
        public static OracleConnection Connection { get; private set; }

        public static bool Connect(string username, string password)
        {
            string connStr = $"Data Source=localhost:1521/ATBM;User Id={username};Password={password};";

            try
            {
                Connection = new OracleConnection(connStr);
                Connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
                return false;
            }
        }

        public static string GetCurrentRole()
        {
            try
            {
                using (var cmd = new OracleCommand("SELECT get_vaitro FROM dual", Connection))
                {
                    var role = cmd.ExecuteScalar()?.ToString();
                    return string.IsNullOrEmpty(role) ? "PDB_DBA" : role; 
                }
            }
            catch
            {
                return "PDB_DBA";
            }
        }


    }
}
