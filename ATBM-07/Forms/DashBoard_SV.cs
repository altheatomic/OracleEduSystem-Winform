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
            this.Load += DashBoard_SV_Load;
        }

        private void DashBoard_SV_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
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
                    MessageBox.Show("Please enter the MAMM!");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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

    }
}
