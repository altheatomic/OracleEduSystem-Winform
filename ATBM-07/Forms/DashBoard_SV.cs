using ATBM_07.Helpers;
using ATBM_07.Services;
using Oracle.ManagedDataAccess.Client;
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
    public partial class DashBoard_SV : Form
    {
        public DashBoard_SV()
        {
            InitializeComponent();
            txtMaSV.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtPhai.ReadOnly = true;
            txtNgSinh.ReadOnly = true;
            txtDiaChi.ReadOnly = false;
            txtKhoa.ReadOnly = true;
            txtDT.ReadOnly = false;
            txtTinhTrang.ReadOnly = true;
            this.Load += DashBoard_SV_Load;
        }
        private void DashBoard_SV_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
            LoadSinhVienInfo();
            LoadDataToGrid();
        }
        private void LoadSinhVienInfo()
        {
            try
            {
                var sv = SVService.GetCurrentSinhVien_SV();
                if (sv != null)
                {
                    txtMaSV.Text = sv["MASV"].ToString();
                    txtHoTen.Text = sv["HOTEN"].ToString();
                    txtPhai.Text = sv["PHAI"].ToString();
                    txtNgSinh.Text = sv["NGSINH"].ToString();
                    txtDiaChi.Text = sv["DCHI"].ToString();
                    txtDT.Text = sv["DT"].ToString();
                    txtKhoa.Text = sv["KHOA"].ToString();
                    txtTinhTrang.Text = sv["TINHTRANG"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load SV: " + ex.Message);
            }
        }
        private void LoadDataToGrid()
        {
            try
            {
                var dt = SVService.GetDangKy_SV();
                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                dataGridView1.Columns["MASV"].Width = 80;
                dataGridView1.Columns["MAMM"].Width = 80;
                dataGridView1.Columns["DIEMTH"].Width = 65;
                dataGridView1.Columns["DIEMQT"].Width = 65;
                dataGridView1.Columns["DIEMCK"].Width = 65;
                dataGridView1.Columns["DIEMTK"].Width = 65;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnStudentUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string diaChi_2;
                diaChi_2 = txtDiaChi.Text.Trim();
                string dienThoai_2;
                dienThoai_2 = txtDT.Text.Trim();

                if (!string.IsNullOrEmpty(diaChi_2) && !string.IsNullOrEmpty(dienThoai_2))
                {
                    SVService.UpdateSinhVienInfoFromProcedure(diaChi_2, dienThoai_2);
                    MessageBox.Show("Stident's info update successful!");
                    this.Load += DashBoard_SV_Load;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Error");
            }

        }

        private void btnSudentInsertCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string maMoMon = txtMaMM.Text.Trim();

                if (!string.IsNullOrEmpty(maMoMon))
                {
                    SVService.AddDataTableFromProcedure(maMoMon);
                    MessageBox.Show("Course registration successful!");
                    dataGridView1.DataSource = SVService.GetDangKy_SV();
                }
                else
                {
                    //MessageBox.Show("Please enter the MAMM!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSudentDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dataGridView1.CurrentRow.Index;

                string maMoMon;
                maMoMon = dataGridView1.Rows[i].Cells[1].Value.ToString();

                if (!string.IsNullOrEmpty(maMoMon))
                {
                    SVService.DeleteDataTableFromProcedure(maMoMon);
                    MessageBox.Show("Course cancellation successful!");
                    dataGridView1.DataSource = SVService.GetDangKy_SV();
                    this.Load += DashBoard_SV_Load;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private void btnSudentUpdateCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dataGridView1.CurrentRow.Index;

                string maMoMon_1;
                maMoMon_1 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string maMoMon_2;
                maMoMon_2 = txtMaMM.Text.Trim();

                if (!string.IsNullOrEmpty(maMoMon_2))
                {
                    SVService.UpdateDataTableFromProcedure(maMoMon_1, maMoMon_2);
                    MessageBox.Show("Course update successful!");
                    dataGridView1.DataSource = SVService.GetDangKy_SV();
                    this.Load += DashBoard_SV_Load;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaSV.Text = dataGridView1.Rows[0].Cells[i].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[1].Cells[i].Value.ToString();
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
