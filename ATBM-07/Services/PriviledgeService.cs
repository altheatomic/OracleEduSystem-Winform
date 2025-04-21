using Oracle.ManagedDataAccess.Client;
using System.Data;
using ATBM_07.Helpers; // THÊM nếu DatabaseHelper ở namespace Helpers

namespace ATBM_07.Services
{
    public static class PrivilegeService
    {
        public static List<string> GetSystemPrivileges()
        {
            var privs = new List<string>();

            using (var cmd = new OracleCommand("get_system_privileges", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_privs", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        privs.Add(reader.GetString(0));
                }
            }

            return privs;
        }

        public static List<string> GetObjectPrivileges()
        {
            var privs = new List<string>();

            using (var cmd = new OracleCommand("SELECT * FROM TABLE(get_object_privileges())", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.Text;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        privs.Add(reader.GetString(0));
                }
            }

            return privs;
        }
    }
}
