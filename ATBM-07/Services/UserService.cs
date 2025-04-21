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

    }
}
