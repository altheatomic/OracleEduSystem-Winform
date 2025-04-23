using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using ATBM_07.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATBM_07.Forms
{
    public partial class DashBoard_GV : Form
    {
        string userID = ""; // Lấy từ login
        string role = "";
        public DashBoard_GV()
        {
            InitializeComponent();
        }

        private void DashBoard_GV_Load(object sender, EventArgs e)
        {
            userID = GetCurrentUser();
            LoadUserInfo();
            LoadMonHoc();
        }
        private string GetCurrentUser()
        {
            try
            {
                if (DatabaseHelper.Connection == null || DatabaseHelper.Connection.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối đến cơ sở dữ liệu không khả dụng.");
                    return "UNKNOWN";
                }

                using (var cmd = new OracleCommand("SELECT USER FROM DUAL", DatabaseHelper.Connection))
                {
                    return cmd.ExecuteScalar()?.ToString() ?? "UNKNOWN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin người dùng: " + ex.Message);
                return "UNKNOWN";
            }
        }
        private void LoadUserInfo()
        {
            try
            {
                Console.WriteLine($"userID: {userID}"); // Log giá trị userID
                using (var cmd = new OracleCommand("user_admin.GET_GV_INFO", DatabaseHelper.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_MANV", OracleDbType.Varchar2).Value = userID;
                    cmd.Parameters.Add("p_VAITRO", OracleDbType.Varchar2, 10).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_MADV", OracleDbType.Varchar2, 10).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_TENDV", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    txt_user.Text = userID;
                    txt_department.Text = cmd.Parameters["p_TENDV"].Value.ToString();
                    txt_role.Text = cmd.Parameters["p_VAITRO"].Value.ToString(); // ĐÃ SỬA
                    role = txt_role.Text;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin giảng viên: {ex.Message}\nError Code: {ex.Number}\nStackTrace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin giảng viên: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }


        private void LoadMonHoc()
        {
            try
            {
                using (var cmd = new OracleCommand("user_admin.GET_MAMM_BY_GV", DatabaseHelper.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_user_id", OracleDbType.Varchar2).Value = userID;
                    cmd.Parameters.Add("p_monhoc_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbb_subject.DataSource = dt;
                    cbb_subject.DisplayMember = "TENHP";
                    cbb_subject.ValueMember = "MAMM";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải môn học: " + ex.Message);
            }
        }

        private void cbb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_subject.SelectedValue != null)
            {
                // Hiển thị danh sách sinh viên theo MAMM đã chọn
                LoadDanhSachSinhVien(cbb_subject.SelectedValue.ToString());
            }
        }

        private void LoadDanhSachSinhVien(string mamm)
        {
            try
            {
                using (var cmd = new OracleCommand("user_admin.GET_SV_BY_MAMM", DatabaseHelper.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_MAMM", OracleDbType.Varchar2).Value = mamm;
                    cmd.Parameters.Add("p_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_listofstudent.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message);
            }
        }

        private void cbb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_class.SelectedValue != null && cbb_subject.SelectedValue != null)
            {
                LoadDanhSachSinhVien(cbb_subject.SelectedValue.ToString(), cbb_class.SelectedValue.ToString());
            }
        }

        private void LoadDanhSachSinhVien(string maMH, string lop)
        {
            try
            {
                using (var cmd = new OracleCommand("user_admin.GET_SV_BY_MON_LOP", DatabaseHelper.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_user_id", OracleDbType.Varchar2).Value = userID;
                    cmd.Parameters.Add("p_maMH", OracleDbType.Varchar2).Value = maMH;
                    cmd.Parameters.Add("p_lop", OracleDbType.Varchar2).Value = lop;
                    cmd.Parameters.Add("p_sv_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_listofstudent.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string maSV = txt_enterIDofstudent.Text.Trim();
            string mamm = cbb_subject.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(mamm))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên và chọn môn học.");
                return;
            }

            try
            {
                using (var cmd = new OracleCommand("user_admin.GET_DIEM_BY_SV", DatabaseHelper.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_MAMM", OracleDbType.Varchar2).Value = mamm;
                    cmd.Parameters.Add("p_MASV", OracleDbType.Varchar2).Value = maSV;
                    cmd.Parameters.Add("p_DIEMTH", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_DIEMQT", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_DIEMCK", OracleDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_DIEMTK", OracleDbType.Decimal).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    // Tạo DataTable để hiển thị điểm
                    DataTable dt = new DataTable();
                    dt.Columns.Add("MASV", typeof(string));
                    dt.Columns.Add("DIEMTH", typeof(string));
                    dt.Columns.Add("DIEMQT", typeof(string));
                    dt.Columns.Add("DIEMCK", typeof(string));
                    dt.Columns.Add("DIEMTK", typeof(string));

                    DataRow row = dt.NewRow();
                    row["MASV"] = maSV;

                    // Gán giá trị điểm nếu có
                    row["DIEMTH"] = cmd.Parameters["p_DIEMTH"].Value != DBNull.Value ? cmd.Parameters["p_DIEMTH"].Value.ToString() : "N/A";
                    row["DIEMQT"] = cmd.Parameters["p_DIEMQT"].Value != DBNull.Value ? cmd.Parameters["p_DIEMQT"].Value.ToString() : "N/A";
                    row["DIEMCK"] = cmd.Parameters["p_DIEMCK"].Value != DBNull.Value ? cmd.Parameters["p_DIEMCK"].Value.ToString() : "N/A";
                    row["DIEMTK"] = cmd.Parameters["p_DIEMTK"].Value != DBNull.Value ? cmd.Parameters["p_DIEMTK"].Value.ToString() : "N/A";

                    dt.Rows.Add(row);

                    // Gán lại dữ liệu lên grid
                    dgv_listofstudent.DataSource = dt;

                    // Optional: Gọi hàm refresh grid layout
                    dgv_listofstudent.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm điểm sinh viên: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_listofstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_enterIDofstudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_role_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ResetForm_Click(object sender, EventArgs e)
        {

        }
    }
}
