using System.Data;
using Oracle.ManagedDataAccess.Client;
using ATBM_07.Helpers;

namespace ATBM_07.Services
{
    public static class NVCTSVService
    {
        public static DataTable GetAllSinhVien()
        {
            DataTable dt = new DataTable();
            using (var cmd = new OracleCommand("user_admin.SP_GET_ALL_SINHVIEN_NVCTSV", DatabaseHelper.Connection))
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

        public static void InsertSinhVien(string masv, string hoten, string phai, DateTime ngsinh, string dchi, string dt, string khoa)
        {
            using (var cmd = new OracleCommand("user_admin.SP_INSERT_SINHVIEN", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_masv", OracleDbType.Varchar2).Value = masv;
                cmd.Parameters.Add("p_hoten", OracleDbType.Varchar2).Value = hoten;
                cmd.Parameters.Add("p_phai", OracleDbType.Varchar2).Value = phai;
                cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = ngsinh;
                cmd.Parameters.Add("p_dchi", OracleDbType.Varchar2).Value = dchi;
                cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = dt;
                cmd.Parameters.Add("p_khoa", OracleDbType.Varchar2).Value = khoa;

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateSinhVien(string masv, string hoten, string phai, DateTime ngsinh, string dchi, string dt, string khoa)
        {
            using (var cmd = new OracleCommand("user_admin.SP_UPDATE_SINHVIEN", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("p_masv", OracleDbType.Varchar2).Value = masv;
                cmd.Parameters.Add("p_hoten", OracleDbType.Varchar2).Value = hoten;
                cmd.Parameters.Add("p_phai", OracleDbType.Varchar2).Value = phai;
                cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = ngsinh;
                cmd.Parameters.Add("p_dchi", OracleDbType.Varchar2).Value = dchi;
                cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = dt;
                cmd.Parameters.Add("p_khoa", OracleDbType.Varchar2).Value = khoa;

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteSinhVien(string masv)
        {
            using (var cmd = new OracleCommand("user_admin.SP_DELETE_SINHVIEN", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_masv", OracleDbType.Varchar2).Value = masv;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
