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
                MessageBox.Show("Connection success:");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
                return false;
            }
        }
        public static string GetRole(string username)
        {
            try
            {
                if (username.Equals("user_admin", StringComparison.OrdinalIgnoreCase))
                {
                    return "PDB_DBA";
                }

                using (var cmd = new OracleCommand("SELECT user_admin.get_vaitro FROM dual", Connection))
                {
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't get role (get_vaitro): " + ex.Message);
                return null;
            }
        }

    }
}
