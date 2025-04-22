using Oracle.ManagedDataAccess.Client;
using ATBM_07.Helpers;
using System.Data;

namespace ATBM_07.Services
{
    public static class UserService
    {
        public static bool CheckUserExists(string username)
        {
            using (var cmd = new OracleCommand("check_user_exists", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                var output = new OracleParameter("p_exists", OracleDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                cmd.ExecuteNonQuery();

                var oracleDecimal = (Oracle.ManagedDataAccess.Types.OracleDecimal)output.Value;
                return oracleDecimal.ToInt32() > 0;
            }
        }

        public static void CreateUser(string username, string password)
        {
            using (var cmd = new OracleCommand("create_user", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                cmd.ExecuteNonQuery();
            }
        }

        public static List<string> GetUsersWithoutRoles()
        {
            var result = new List<string>();
            using (var cmd = new OracleCommand("get_users_without_roles", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_users", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        result.Add(reader.GetString(0));
                }
            }
            return result;
        }

        public static void GrantRoleToUser(string username, string rolename)
        {
            using (var cmd = new OracleCommand("grant_role_to_user", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                cmd.Parameters.Add("p_rolename", OracleDbType.Varchar2).Value = rolename;
                cmd.ExecuteNonQuery();
            }
        }

        public static void GrantPrivilegeToUser(string username, string privilege, string type, string objectName, string columnName, bool withGrantOption)
        {
            using (var cmd = new OracleCommand("grant_priv_to_user", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = privilege;
                cmd.Parameters.Add("p_type", OracleDbType.Varchar2).Value = type;
                cmd.Parameters.Add("p_object_name", OracleDbType.Varchar2).Value = string.IsNullOrWhiteSpace(objectName) ? DBNull.Value : objectName;
                cmd.Parameters.Add("p_column_name", OracleDbType.Varchar2).Value = string.IsNullOrWhiteSpace(columnName) ? DBNull.Value : columnName;
                cmd.Parameters.Add("p_with_grant", OracleDbType.Boolean).Value = withGrantOption;

                cmd.ExecuteNonQuery();
            }
        }

        public static List<string[]> GetPrivilegesOfUser(string username)
        {
            var privs = new List<string[]>();

            using (var cmd = new OracleCommand("get_privs_of_user", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                var output = new OracleParameter("p_privs", OracleDbType.RefCursor)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(output);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string privilege = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        string table = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        string column = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        string grantable = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        privs.Add(new string[] { privilege, table, column, grantable });
                    }
                }
            }

            return privs;
        }

        public static void RevokePrivilegeFromUser(string username, string privilege, string objectName)
        {
            using (var cmd = new OracleCommand("revoke_priv_from_user", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                cmd.Parameters.Add("p_privilege", OracleDbType.Varchar2).Value = privilege;
                cmd.Parameters.Add("p_object_name", OracleDbType.Varchar2).Value =
                    string.IsNullOrWhiteSpace(objectName) ? DBNull.Value : (object)objectName;

                cmd.ExecuteNonQuery();
            }
        }

        public static void RevokeRoleFromUser(string username, string rolename)
        {
            using (var cmd = new OracleCommand("revoke_role_from_user", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                cmd.Parameters.Add("p_rolename", OracleDbType.Varchar2).Value = rolename;
                cmd.ExecuteNonQuery();
            }
        }

        public static void DropUser(string username)
        {
            using (var cmd = new OracleCommand("drop_user", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                cmd.ExecuteNonQuery();
            }
        }



    }
}
