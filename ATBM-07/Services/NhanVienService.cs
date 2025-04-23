using Oracle.ManagedDataAccess.Client;
using System.Data;
using ATBM_07.Helpers;
using ATBM_07.Forms;
using System.Diagnostics;


namespace ATBM_07.Services
{
    public static class NhanVienService
    {

        // Lấy thông tin nhân viên
        public static DataRow GetCurrentNhanVien()
        {
            using (var conn = DatabaseHelper.GetNewConnection()) // Sử dụng kết nối mới
            using (var cmd = new OracleCommand("SELECT * FROM user_admin.V_NHANVIEN_NVCB", conn))
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
                    MessageBox.Show($"Oracle Error [{ex.Number}]: {ex.Message}");
                    return null;
                }
            }
        }

        // Update DT của NVCB
        public static void UpdateSDT(string newSDT)
        {
            using (var conn = DatabaseHelper.GetNewConnection())
            using (var cmd = new OracleCommand("UPDATE user_admin.V_NHANVIEN_NVCB SET DT = :newSDT", conn))
            {
                cmd.Parameters.Add("newSDT", OracleDbType.Varchar2).Value = newSDT;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Update failed: {ex.Message}");
                    throw; // Re-throw để xử lý tiếp nếu cần
                }
            }
        }

        // Lấy tất cả nhân viên theo quyền NVTCHC (từ view)
        public static DataTable GetAllNhanVien_NVTCHC()
        {
            var table = new DataTable();
            try
            {
                using (var conn = DatabaseHelper.GetNewConnection())
                using (var cmd = new OracleCommand("SELECT * FROM user_admin.V_NHANVIEN_NVTCHC", conn))
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }
            catch (OracleException ex) when (ex.Number == 942) // Table/view does not exist
            {
                MessageBox.Show("Không có quyền truy cập view này");
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Oracle Error [{ex.Number}]: {ex.Message}");
            }
            return table;
        }


        // Lấy danh sách mã đơn vị (KHOA)
        public static DataTable GetAllMaDV()
        {
            // Tạo DataTable trước để có thể return ngay cả khi có lỗi
            var table = new DataTable();

            try
            {
                // Sử dụng kết nối mới, tự giải phóng
                using (var conn = DatabaseHelper.GetNewConnection())
                using (var cmd = new OracleCommand("SELECT MADV FROM user_admin.DONVI", conn))
                using (var adapter = new OracleDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }
            catch (OracleException ex)
            {
                // Xử lý lỗi cụ thể từ Oracle
                MessageBox.Show($"Lỗi Oracle [{ex.Number}] khi lấy danh sách đơn vị:\n{ex.Message}");

                // Có thể log lỗi ở đây nếu cần
                Debug.WriteLine($"Oracle Error {ex.Number}: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                MessageBox.Show($"Lỗi khi lấy danh sách đơn vị:\n{ex.Message}");
            }

            return table; // Trả về table dù có lỗi hay không (sẽ rỗng nếu có lỗi)
        }
    }
}
