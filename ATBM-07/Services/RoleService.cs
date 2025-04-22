using Oracle.ManagedDataAccess.Client;
using System.Data;
using ATBM_07.Helpers; // Thêm nếu DatabaseHelper nằm trong namespace Helpers

namespace ATBM_07.Services
{
    public static class RoleService
    {
        public static bool CheckRoleExists(string roleName)
        {
            using (var cmd = new OracleCommand("check_role_exists", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;

                var output = new OracleParameter("p_exists", OracleDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                cmd.ExecuteNonQuery();

                var result = (Oracle.ManagedDataAccess.Types.OracleDecimal)output.Value;
                return result.ToInt32() > 0;
            }
        }

        public static void CreateRole(string roleName)
        {
            using (var cmd = new OracleCommand("create_role", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;
                cmd.ExecuteNonQuery();
            }
        }

        public static List<string> GetApplicationRoles()
        {
            var roles = new List<string>();

            using (var cmd = new OracleCommand("get_application_roles", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_roles", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        roles.Add(reader.GetString(0));
                }
            }

            return roles;
        }

        public static List<string> GetAllRoles()
        {
            var roles = new List<string>();

            using (var cmd = new OracleCommand("get_all_roles", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_roles", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        roles.Add(reader.GetString(0));
                }
            }

            return roles;
        }

        public static void GrantPrivilegeToRole(string role, string priv, string type, string objName, string column)
        {
            using (var cmd = new OracleCommand("grant_priv_to_role", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                cmd.Parameters.Add("p_priv", OracleDbType.Varchar2).Value = priv;
                cmd.Parameters.Add("p_type", OracleDbType.Varchar2).Value = type;
                cmd.Parameters.Add("p_obj_name", OracleDbType.Varchar2).Value = objName ?? (object)DBNull.Value;
                cmd.Parameters.Add("p_column", OracleDbType.Varchar2).Value = column ?? (object)DBNull.Value;

                cmd.ExecuteNonQuery();
            }
        }



        public static List<string> GetUsersByRole(string role)
        {
            var users = new List<string>();

            using (var cmd = new OracleCommand("get_users_by_role", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;
                cmd.Parameters.Add("p_users", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        users.Add(reader.GetString(0));
                }
            }

            return users;
        }
    }
}
