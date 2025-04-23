using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
namespace ATBM_07.Helpers
{
    public static class DatabaseHelper
    {
        public static OracleConnection Connection { get; private set; }

        private static string _currentConnectionString;
        private static OracleConnection _sharedConnection;
        public static string CurrentConnectionString => _currentConnectionString;
        public static OracleConnection SharedConnection => _sharedConnection;


        public static bool Connect(string username, string password)
        {
            try
            {
                // Đóng kết nối cũ nếu tồn tại
                if (_sharedConnection != null)
                {
                    _sharedConnection.Close();
                    _sharedConnection.Dispose();
                }

                // Tạo connection string mới
                _currentConnectionString = $"Data Source=localhost:1521/ATBM;User Id={username};Password={password}";

                // Tạo và mở kết nối mới
                _sharedConnection = new OracleConnection(_currentConnectionString);
                _sharedConnection.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
                return false;
            }
        }

        // Hàm tạo kết nối mới (cho các thao tác độc lập)
        public static OracleConnection GetNewConnection()
        {
            if (Connection == null || Connection.State != ConnectionState.Open)
            {
                Connection?.Dispose(); // Đảm bảo giải phóng kết nối cũ
                Connection = new OracleConnection(_currentConnectionString);
                Connection.Open();
            }
            return Connection;
        }

        public static string GetRoleFromVaitroFunction()
        {
            try
            {
                using (var cmd = new OracleCommand("SELECT user_admin.get_vaitro FROM dual", GetNewConnection()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy vai trò (get_vaitro): " + ex.Message);
                return null;
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

        //Hàm giải phóng resources
        public static void Dispose()
        {
            if (_sharedConnection != null)
            {
                if (_sharedConnection.State != System.Data.ConnectionState.Closed)
                    _sharedConnection.Close();

                _sharedConnection.Dispose();
                _sharedConnection = null;
            }
            _currentConnectionString = null;
        }


    }
}