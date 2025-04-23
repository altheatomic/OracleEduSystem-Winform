using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM_07.Helpers;
using ATBM_07.Services;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_07.Forms
{
    public partial class DashBoard_NVTCHC : Form
    {
        public DashBoard_NVTCHC()
        {
            InitializeComponent();
            txtMaNV.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtPhai.ReadOnly = true;
            txtNgSinh.ReadOnly = true;
            txtLuong.ReadOnly = true;
            txtPhuCap.ReadOnly = true;
            txtVaiTro.ReadOnly = true;
            txtDT.ReadOnly = false;
            txtMaDV.ReadOnly = true;
            this.Load += DashBoard_NVTCHC_Load;
        }

        private void DashBoard_NVTCHC_Load(object sender, EventArgs e)
        {
            LoadCurrentNhanVien();
            LoadMaDVComboBox();
            LoadDataGridNhanVien();
            LoadVaiTroToComboBox();
        }

        private void LoadVaiTroToComboBox()
        {
            var roles = new List<string>
        {
        "SV", "NVCB", "GV", "NVPDT", "NVPKT", "NVTCHC", "NVCTSV", "TRGDV"
        };

            cbbNewVaiTro.DataSource = roles;
        }

        private void LoadCurrentNhanVien()
        {
            var nv = NhanVienService.GetCurrentNhanVien();
            if (nv != null)
            {
                txtMaNV.Text = nv["MANV"].ToString();
                txtHoTen.Text = nv["HOTEN"].ToString();
                txtPhai.Text = nv["PHAI"].ToString();
                txtNgSinh.Text = nv["NGSINH"].ToString();
                txtLuong.Text = nv["LUONG"].ToString();
                txtPhuCap.Text = nv["PHUCAP"].ToString();
                txtDT.Text = nv["DT"].ToString();
                txtVaiTro.Text = nv["VAITRO"].ToString();
                txtMaDV.Text = nv["MADV"].ToString();
            }
        }

        private void LoadMaDVComboBox()
        {
            var data = NhanVienService.GetAllMaDV();
            cbbNewMaDV.DataSource = data;
            cbbNewMaDV.DisplayMember = "MADV";
            cbbNewMaDV.ValueMember = "MADV";
        }

        public void LoadDataGridNhanVien()
        {
            dgvNhanVienList.DataSource = NhanVienService.GetAllNhanVien_NVTCHC();
        }


        //Buttons
        private void btnAddNV_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng kết nối mới cho mỗi thao tác
                using (var conn = DatabaseHelper.GetNewConnection())
                using (var cmd = new OracleCommand("user_admin.sp_insert_nhanvien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm output parameter
                    var outParam = new OracleParameter("p_manv", OracleDbType.Varchar2, 10)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    // Thêm các input parameters
                    cmd.Parameters.Add("p_hoten", OracleDbType.Varchar2).Value = txtNewHoTen.Text;
                    cmd.Parameters.Add("p_phai", OracleDbType.Char).Value = txtNewPhai.Text;
                    cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = dtpNewNgSinh.Value;
                    cmd.Parameters.Add("p_luong", OracleDbType.Decimal).Value = Convert.ToDecimal(txtNewLuong.Text);
                    cmd.Parameters.Add("p_phucap", OracleDbType.Decimal).Value = Convert.ToDecimal(txtNewPhuCap.Text);
                    cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = txtDT.Text;
                    cmd.Parameters.Add("p_vaitro", OracleDbType.Varchar2).Value = cbbNewVaiTro.SelectedValue?.ToString();
                    cmd.Parameters.Add("p_madv", OracleDbType.Varchar2).Value = cbbNewMaDV.SelectedValue?.ToString();

                    cmd.ExecuteNonQuery();

                    // Kiểm tra và xử lý kết quả
                    if (outParam.Value == null || outParam.Value == DBNull.Value)
                    {
                        throw new Exception("Không nhận được mã nhân viên từ stored procedure");
                    }

                    txtNewMaNV.Text = outParam.Value.ToString();
                    MessageBox.Show("Thêm nhân viên thành công! Mã NV: " + txtNewMaNV.Text);
                }

                LoadDataGridNhanVien();
            }
            catch (OracleException oraEx)
            {
                MessageBox.Show($"Lỗi Oracle [{oraEx.Number}]: {oraEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetNewConnection())
                using (var cmd = new OracleCommand("user_admin.sp_update_nhanvien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm output parameter để nhận số dòng cập nhật
                    var outParam = new OracleParameter("p_rows_updated", OracleDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);

                    // Thêm các parameters với kiểu dữ liệu chính xác
                    cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = txtNewMaNV.Text.Trim();
                    cmd.Parameters.Add("p_hoten", OracleDbType.Varchar2).Value = txtNewHoTen.Text.Trim();
                    cmd.Parameters.Add("p_phai", OracleDbType.Char).Value = txtNewPhai.Text.Trim()[0]; // Lấy ký tự đầu
                    cmd.Parameters.Add("p_ngsinh", OracleDbType.Date).Value = dtpNewNgSinh.Value;
                    cmd.Parameters.Add("p_luong", OracleDbType.Decimal).Value = decimal.Parse(txtNewLuong.Text);
                    cmd.Parameters.Add("p_phucap", OracleDbType.Decimal).Value = decimal.Parse(txtNewPhuCap.Text);
                    cmd.Parameters.Add("p_dt", OracleDbType.Varchar2).Value = txtDT.Text.Trim();
                    cmd.Parameters.Add("p_vaitro", OracleDbType.Varchar2).Value = cbbNewVaiTro.SelectedValue?.ToString() ?? string.Empty;
                    cmd.Parameters.Add("p_madv", OracleDbType.Varchar2).Value = cbbNewMaDV.SelectedValue?.ToString() ?? string.Empty;

                    cmd.ExecuteNonQuery();

                    int rowsUpdated = Convert.ToInt32(outParam.Value);
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để cập nhật. Kiểm tra lại mã nhân viên.");
                    }
                    else
                    {
                        MessageBox.Show($"Đã cập nhật thành công {rowsUpdated} nhân viên");
                        LoadDataGridNhanVien(); // Refresh danh sách
                    }
                }
            }
            catch (OracleException oraEx)
            {
                MessageBox.Show($"Lỗi Oracle [{oraEx.Number}]: {oraEx.Message}\n\nChi tiết: {oraEx.InnerException?.Message}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng dữ liệu. Kiểm tra lại số lương/phụ cấp.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}");
            }
        }


        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // Sử dụng kết nối mới
                using (var conn = DatabaseHelper.GetNewConnection())
                using (var cmd = new OracleCommand("user_admin.sp_delete_nhanvien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_manv", OracleDbType.Varchar2).Value = txtNewMaNV.Text;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để xóa");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        // Clear các field sau khi xóa
                        txtNewMaNV.Text = string.Empty;
                        // ... clear các field khác nếu cần
                    }
                }

                LoadDataGridNhanVien();
            }
            catch (OracleException oraEx)
            {
                MessageBox.Show($"Lỗi Oracle [{oraEx.Number}]: {oraEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }


        private void btnUpdateTeleEmployee_Click(object sender, EventArgs e)
        {
            string newSDT = txtDT.Text.Trim();
            try
            {
                NhanVienService.UpdateSDT(newSDT);
                MessageBox.Show("Cập nhật số điện thoại thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị hộp thoại xác nhận
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                                                  "Xác nhận đăng xuất",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Đóng kết nối database
                    DatabaseHelper.Dispose();

                    // Mở lại form đăng nhập
                    var loginForm = new Login(); // Thay LoginForm bằng tên form đăng nhập thực tế
                    loginForm.Show();

                    // Đóng form hiện tại
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng xuất: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
