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
        public static DataRow GetCurrentSinhVien_SV()
        {
            //using (var conn = DatabaseHelper.GetNewConnection()) // Sử dụng kết nối mới
            using (var cmd = new OracleCommand("SELECT * FROM user_admin.SINHVIEN", DatabaseHelper.Connection))
            using (var adapter = new OracleDataAdapter(cmd))
            {
                var table = new DataTable();
                try
                {
                    adapter.Fill(table);
                    return table.Rows.Count > 0 ? table.Rows[0] : null;
                }
                catch (OracleException ex)
                {
                    //MessageBox.Show($"Oracle Error [{ex.Number}]: {ex.Message}");
                    return null;
                }
            }
        }

        public static DataTable GetDangKy_SV() => LoadDataTableFromProcedure("user_admin.GET_DANGKY_SV");
        public static DataTable GetSinhVien_MaSV_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_MASV_SV");
        public static DataTable GetSinhVien_HoTen_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_HOTEN_SV");
        public static DataTable GetSinhVien_Phai_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_PHAI_SV");
        public static DataTable GetSinhVien_NgSinh_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_NGSINH_SV");
        public static DataTable GetSinhVien_DChi_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_DCHI_SV");
        public static DataTable GetSinhVien_DT_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_DT_SV");
        public static DataTable GetSinhVien_Khoa_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_KHOA_SV");
        public static DataTable GetSinhVien_TinhTrang_SV() => LoadDataTableFromProcedure("user_admin.GET_SINHVIEN_TINHTRANG_SV");

        private static DataTable LoadDataTableFromProcedure(string procName)
        {
            var dt = new DataTable();
            //using (var conn = DatabaseHelper.GetNewConnection())
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

        public static void UpdateSinhVienInfoFromProcedure(string diaChi_2, string dienThoai_2)
        {
            //using (var conn = DatabaseHelper.GetNewConnection())
            using (var cmd = new OracleCommand("user_admin.UPDATE_SINHVIEN_SV", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_dia_chi_2", OracleDbType.Varchar2).Value = diaChi_2;
                cmd.Parameters.Add("p_dien_thoai_2", OracleDbType.Varchar2).Value = dienThoai_2;
                cmd.ExecuteNonQuery();
            }
        }

        public static void AddDataTableFromProcedure(string mamm)
        {
            //using (var conn = DatabaseHelper.GetNewConnection())
            using (var cmd = new OracleCommand("user_admin.ADD_DANGKY_SV", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = mamm;
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteDataTableFromProcedure(string mamm)
        {
            //using (var conn = DatabaseHelper.GetNewConnection())
            using (var cmd = new OracleCommand("user_admin.DELETE_DANGKY_SV", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_mamm", OracleDbType.Varchar2).Value = mamm;
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateDataTableFromProcedure(string mamm_1, string mamm_2)
        {
            //using (var conn = DatabaseHelper.GetNewConnection())
            using (var cmd = new OracleCommand("user_admin.UPDATE_DANGKY_SV", DatabaseHelper.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_mamm_1", OracleDbType.Varchar2).Value = mamm_1;
                cmd.Parameters.Add("p_mamm_2", OracleDbType.Varchar2).Value = mamm_2;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
