using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using ATBM_07.Helpers;
using ATBM_07.Services;

namespace ATBM_07.Forms
{
    public partial class DashBoard_NVPKT : Form
    {
        public DashBoard_NVPKT()
        {
            InitializeComponent();
            LoadGrades();
            btnSave.Click += btnSave_Click;
        }

        private void LoadGrades()
        {
            try
            {
                DataTable dt = NVPKTService.GetAllDiem();
                dataGridViewDangKy.DataSource = dt;

                foreach (DataGridViewColumn col in dataGridViewDangKy.Columns)
                {
                    col.ReadOnly = !(col.Name == "DIEMTH" || col.Name == "DIEMQT" || col.Name == "DIEMCK" || col.Name == "DIEMTK");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewDangKy.Rows)
                {
                    if (row.IsNewRow) continue;

                    string masv = row.Cells["MASV"].Value?.ToString();
                    string mamm = row.Cells["MAMM"].Value?.ToString();

                    if (decimal.TryParse(row.Cells["DIEMTH"].Value?.ToString(), out decimal diemth) &&
                        decimal.TryParse(row.Cells["DIEMQT"].Value?.ToString(), out decimal diemqt) &&
                        decimal.TryParse(row.Cells["DIEMCK"].Value?.ToString(), out decimal diemck) &&
                        decimal.TryParse(row.Cells["DIEMTK"].Value?.ToString(), out decimal diemtk))
                    {
                        NVPKTService.UpdateDiem(masv, mamm, diemth, diemqt, diemck, diemtk);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid data for student {masv}, subject {mamm}. Please check input.");
                    }
                }

                MessageBox.Show("Grades updated successfully.");
                LoadGrades();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating grades: " + ex.Message);
            }
        }
    }
}
