using System;
using System.Windows.Forms;

namespace ATBM_07.Forms
{
    public partial class InsertSinhVienForm : Form
    {
        public string MASV => txtMASV.Text.Trim();
        public string HOTEN => txtHOTEN.Text.Trim();
        public string PHAI => cmbPHAI.SelectedItem?.ToString();
        public DateTime NGSINH => dtpNGSINH.Value.Date;
        public string DCHI => txtDCHI.Text.Trim();
        public string DT => txtDT.Text.Trim();
        public string KHOA => cmbKHOA.SelectedItem?.ToString();

        private TextBox txtMASV, txtHOTEN, txtDCHI, txtDT;
        private ComboBox cmbPHAI, cmbKHOA;
        private DateTimePicker dtpNGSINH;
        private Button btnInsert, btnCancel;

        public InsertSinhVienForm()
        {
            InitializeSinhVienForm();
        }

        private void InitializeSinhVienForm()
        {
            this.Text = "Thêm sinh viên";
            this.Size = new System.Drawing.Size(400, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblMASV = new Label { Text = "Mã SV", Top = 20, Left = 20, Width = 100 };
            txtMASV = new TextBox { Top = 20, Left = 130, Width = 200 };

            Label lblHOTEN = new Label { Text = "Họ tên", Top = 60, Left = 20, Width = 100 };
            txtHOTEN = new TextBox { Top = 60, Left = 130, Width = 200 };

            Label lblPHAI = new Label { Text = "Phái", Top = 100, Left = 20, Width = 100 };
            cmbPHAI = new ComboBox { Top = 100, Left = 130, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbPHAI.Items.AddRange(new object[] { "Nam", "Nữ" });

            Label lblNGSINH = new Label { Text = "Ngày sinh", Top = 140, Left = 20, Width = 100 };
            dtpNGSINH = new DateTimePicker { Top = 140, Left = 130, Width = 200 };

            Label lblDCHI = new Label { Text = "Địa chỉ", Top = 180, Left = 20, Width = 100 };
            txtDCHI = new TextBox { Top = 180, Left = 130, Width = 200 };

            Label lblDT = new Label { Text = "Điện thoại", Top = 220, Left = 20, Width = 100 };
            txtDT = new TextBox { Top = 220, Left = 130, Width = 200 };

            Label lblKHOA = new Label { Text = "Mã khoa", Top = 260, Left = 20, Width = 100 };
            cmbKHOA = new ComboBox { Top = 260, Left = 130, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbKHOA.Items.AddRange(new object[] {
                "TTHC", "CNTT", "VLKT", "HOHC", "SHCN",
                "MTRG", "DCHT", "KCVL", "DTVT", "KHLN", "QLCL"
            });

            btnInsert = new Button { Text = "Insert", Top = 320, Left = 80, Width = 100 };
            btnInsert.Click += btnInsert_Click;

            btnCancel = new Button { Text = "Cancel", Top = 320, Left = 200, Width = 100 };
            btnCancel.Click += btnCancel_Click;

            this.Controls.AddRange(new Control[] {
                lblMASV, txtMASV,
                lblHOTEN, txtHOTEN,
                lblPHAI, cmbPHAI,
                lblNGSINH, dtpNGSINH,
                lblDCHI, txtDCHI,
                lblDT, txtDT,
                lblKHOA, cmbKHOA,
                btnInsert, btnCancel
            });
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MASV) || string.IsNullOrWhiteSpace(HOTEN) || PHAI == null || KHOA == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}