using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ATBM_07.Services
{
    public static class RoleService
    {
        public static List<string> GetApplicationRoles()
        {
            var roles = new List<string>();
            using (var conn = new OracleConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand("get_application_roles", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_roles", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            roles.Add(reader.GetString(0));
                }
            }
            return roles;
        }

        public static List<string> GetUsersByRole(string role)
        {
            var users = new List<string>();
            using (var conn = new OracleConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand("get_users_by_role", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                    cmd.Parameters.Add("p_users", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            users.Add(reader.GetString(0));
                }
            }
            return users;
        }
    }
}
