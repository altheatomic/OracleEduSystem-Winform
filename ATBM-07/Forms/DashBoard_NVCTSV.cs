// DashBoard_NVCTSV.cs
using ATBM_07.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace ATBM_07.Forms
{
    public partial class DashBoard_NVCTSV : Form
    {
        public DashBoard_NVCTSV()
        {
            InitializeComponent();
            LoadSinhVienData();
            buttonSave.Click += buttonSave_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonInsert.Click += buttonInsert_Click;
        }

        private void LoadSinhVienData()
        {
            try
            {
                DataTable dt = NVCTSVService.GetAllSinhVien();
                dataGridViewSinhVien.DataSource = dt;

                if (dataGridViewSinhVien.Columns.Contains("TINHTRANG"))
                {
                    dataGridViewSinhVien.Columns["TINHTRANG"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading SV: " + ex.Message);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var form = new InsertSinhVienForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NVCTSVService.InsertSinhVien(
                        form.MASV, form.HOTEN, form.PHAI, form.NGSINH, form.DCHI, form.DT, form.KHOA
                    );
                    MessageBox.Show("Insert success.");
                    LoadSinhVienData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewSinhVien.Rows)
                {
                    if (row.IsNewRow) continue;

                    string masv = row.Cells["MASV"].Value.ToString();
                    string hoten = row.Cells["HOTEN"].Value.ToString();
                    string phai = row.Cells["PHAI"].Value.ToString();
                    DateTime ngsinh = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                    string dchi = row.Cells["DCHI"].Value.ToString();
                    string dt = row.Cells["DT"].Value.ToString();
                    string khoa = row.Cells["KHOA"].Value.ToString();

                    NVCTSVService.UpdateSinhVien(masv, hoten, phai, ngsinh, dchi, dt, khoa);
                }

                MessageBox.Show("Cập nhật thành công.");
                LoadSinhVienData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.SelectedRows.Count > 0)
            {
                var row = dataGridViewSinhVien.SelectedRows[0];
                string masv = row.Cells["MASV"].Value.ToString();

                var confirm = MessageBox.Show($"Delete {masv}?", "OK", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        NVCTSVService.DeleteSinhVien(masv);
                        MessageBox.Show("Delete success.");
                        LoadSinhVienData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}