using ATBM_07.Helpers;
using ATBM_07.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_07.Forms
{
    public partial class DashBoard_TRGDV : Form
    {
        public DashBoard_TRGDV()
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
            this.Load += Dashboard_TRGDV_Load;
        }
        private void Dashboard_TRGDV_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            Dashboard_TRGDV_Info();
            LoadDataToGrid();
        }

        private void Dashboard_TRGDV_Info()
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
        private void LoadDataToGrid()
        {
            try
            {
                var dt = TRGDVService.Get_MoMon_TRGDV();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateTeleEmployee_Click(object sender, EventArgs e)
        {
            string newSDT = txtDT.Text.Trim();
            try
            {
                NhanVienService.UpdateSDT(newSDT);
                MessageBox.Show("Update successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }


        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị hộp thoại xác nhận
                var confirmResult = MessageBox.Show("Do you want to log out?",
                                                  "Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Đóng kết nối database
                    //DatabaseHelper.Dispose();

                    // Mở lại form đăng nhập
                    var loginForm = new Login(); // Thay LoginForm bằng tên form đăng nhập thực tế
                    loginForm.Show();

                    // Đóng form hiện tại
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Lỗi khi đăng xuất: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Erorr");
            }
        }
    }
}
