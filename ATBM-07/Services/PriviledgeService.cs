using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ATBM_07.Services
{
    public static class PrivilegeService
    {
        public static List<string> GetSystemPrivileges()
        {
            var privs = new List<string>();
            using (var conn = new OracleConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand("get_system_privileges", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_privs", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            privs.Add(reader.GetString(0));
                }
            }
            return privs;
        }

        public static List<string> GetObjectPrivileges()
        {
            var privs = new List<string>();
            using (var conn = new OracleConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand("SELECT * FROM TABLE(get_object_privileges())", conn))
                {
                    cmd.CommandType = CommandType.Text;

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            privs.Add(reader.GetString(0));
                }
            }
            return privs;
        }
    }
}
