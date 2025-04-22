using ATBM_07.Helpers;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_07.Services
{
    public static class SVService
    {
        public static DataTable GetDangKy_SV() => LoadDataTableFromProcedure("user_admin.GET_DANGKY_SV");

        private static DataTable LoadDataTableFromProcedure(string procName)
        {
            var dt = new DataTable();

            using (var cmd = new OracleCommand(procName, DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                using (var adapter = new OracleDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            return dt;
        }
        public static void AddDataTableFromProcedure(string mamm)
        {
            using (var cmd = new OracleCommand("user_admin.ADD_DANGKY_SV", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = mamm;
                cmd.ExecuteNonQuery(); // Vì không có kết quả trả về
            }
        }
        public static void DeleteDataTableFromProcedure(string mamm)
        {
            using (var cmd = new OracleCommand("user_admin.DELETE_DANGKY_SV", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = mamm;
                cmd.ExecuteNonQuery(); // Vì không có kết quả trả về
            }
        }

    }
}