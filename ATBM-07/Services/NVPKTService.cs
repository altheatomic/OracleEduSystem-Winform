using Oracle.ManagedDataAccess.Client;
using System;
using ATBM_07.Helpers;
using System.Data;

namespace ATBM_07.Services
{
    public static class NVPKTService
    {
        public static void UpdateDiem(string masv, string mamm, decimal diemth, decimal diemqt, decimal diemck, decimal diemtk)
        {
            using (var cmd = new OracleCommand("user_admin.sp_update_diem_dangky", DatabaseHelper.Connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("p_masv", OracleDbType.Varchar2).Value = masv;
                cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = mamm;
                cmd.Parameters.Add("p_diemth", OracleDbType.Decimal).Value = diemth;
                cmd.Parameters.Add("p_diemqt", OracleDbType.Decimal).Value = diemqt;
                cmd.Parameters.Add("p_diemck", OracleDbType.Decimal).Value = diemck;
                cmd.Parameters.Add("p_diemtk", OracleDbType.Decimal).Value = diemtk;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    throw new Exception("Update failed: " + ex.Message);
                }
            }
        }

        public static DataTable GetAllDiem()
        {
            DataTable dt = new DataTable();

            using (var cmd = new OracleCommand("user_admin.sp_get_all_dangky", DatabaseHelper.Connection))
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
    }
}
