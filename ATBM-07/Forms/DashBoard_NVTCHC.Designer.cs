namespace ATBM_07.Forms
{
    partial class DashBoard_NVTCHC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPhuCap = new TextBox();
            btnUpdateNV = new Button();
            txtNewPhuCap = new TextBox();
            label10 = new Label();
            txtNewDT = new TextBox();
            label16 = new Label();
            cbbNewMaDV = new ComboBox();
            cbbNewVaiTro = new ComboBox();
            groupBox2 = new GroupBox();
            dtpNewNgSinh = new DateTimePicker();
            txtNewHoTen = new TextBox();
            txtNewMaNV = new TextBox();
            txtNewPhai = new TextBox();
            btnDeleteNV = new Button();
            btnAddNV = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtNewLuong = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label11 = new Label();
            dgvNhanVienList = new DataGridView();
            groupBox1 = new GroupBox();
            txtLuong = new TextBox();
            btnUpdateTeleEmployee = new Button();
            txtHoTen = new TextBox();
            label1 = new Label();
            txtVaiTro = new TextBox();
            txtMaNV = new TextBox();
            label7 = new Label();
            label2 = new Label();
            txtMaDV = new TextBox();
            txtPhai = new TextBox();
            label8 = new Label();
            label3 = new Label();
            txtDT = new TextBox();
            label9 = new Label();
            label4 = new Label();
            txtNgSinh = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnLogout = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPhuCap
            // 
            txtPhuCap.BackColor = SystemColors.Control;
            txtPhuCap.Font = new Font("Segoe UI", 12F);
            txtPhuCap.Location = new Point(474, 148);
            txtPhuCap.Name = "txtPhuCap";
            txtPhuCap.ReadOnly = true;
            txtPhuCap.Size = new Size(120, 29);
            txtPhuCap.TabIndex = 95;
            // 
            // btnUpdateNV
            // 
            btnUpdateNV.AutoSize = true;
            btnUpdateNV.FlatAppearance.BorderColor = Color.Teal;
            btnUpdateNV.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnUpdateNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnUpdateNV.FlatStyle = FlatStyle.Flat;
            btnUpdateNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateNV.ForeColor = Color.Teal;
            btnUpdateNV.Location = new Point(407, 305);
            btnUpdateNV.Name = "btnUpdateNV";
            btnUpdateNV.Size = new Size(150, 33);
            btnUpdateNV.TabIndex = 106;
            btnUpdateNV.Text = "Update";
            btnUpdateNV.UseVisualStyleBackColor = true;
            // 
            // txtNewPhuCap
            // 
            txtNewPhuCap.Font = new Font("Segoe UI", 12F);
            txtNewPhuCap.Location = new Point(474, 148);
            txtNewPhuCap.Name = "txtNewPhuCap";
            txtNewPhuCap.Size = new Size(120, 29);
            txtNewPhuCap.TabIndex = 105;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(388, 148);
            label10.Name = "label10";
            label10.Size = new Size(81, 21);
            label10.TabIndex = 104;
            label10.Text = "Allowance";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNewDT
            // 
            txtNewDT.Font = new Font("Segoe UI", 12F);
            txtNewDT.Location = new Point(127, 250);
            txtNewDT.Name = "txtNewDT";
            txtNewDT.Size = new Size(120, 29);
            txtNewDT.TabIndex = 103;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.ForeColor = Color.Teal;
            label16.Location = new Point(36, 253);
            label16.Name = "label16";
            label16.Size = new Size(80, 21);
            label16.TabIndex = 102;
            label16.Text = "Telephone";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbbNewMaDV
            // 
            cbbNewMaDV.FormattingEnabled = true;
            cbbNewMaDV.Location = new Point(127, 201);
            cbbNewMaDV.Name = "cbbNewMaDV";
            cbbNewMaDV.Size = new Size(120, 23);
            cbbNewMaDV.TabIndex = 101;
            // 
            // cbbNewVaiTro
            // 
            cbbNewVaiTro.FormattingEnabled = true;
            cbbNewVaiTro.Location = new Point(474, 198);
            cbbNewVaiTro.Name = "cbbNewVaiTro";
            cbbNewVaiTro.Size = new Size(120, 23);
            cbbNewVaiTro.TabIndex = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpNewNgSinh);
            groupBox2.Controls.Add(btnUpdateNV);
            groupBox2.Controls.Add(txtNewPhuCap);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtNewDT);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(cbbNewMaDV);
            groupBox2.Controls.Add(cbbNewVaiTro);
            groupBox2.Controls.Add(txtNewHoTen);
            groupBox2.Controls.Add(txtNewMaNV);
            groupBox2.Controls.Add(txtNewPhai);
            groupBox2.Controls.Add(btnDeleteNV);
            groupBox2.Controls.Add(btnAddNV);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtNewLuong);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label19);
            groupBox2.Location = new Point(804, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(643, 355);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // dtpNewNgSinh
            // 
            dtpNewNgSinh.CustomFormat = "dd/MM/yyyy";
            dtpNewNgSinh.Format = DateTimePickerFormat.Custom;
            dtpNewNgSinh.Location = new Point(474, 103);
            dtpNewNgSinh.Name = "dtpNewNgSinh";
            dtpNewNgSinh.Size = new Size(120, 23);
            dtpNewNgSinh.TabIndex = 108;
            // 
            // txtNewHoTen
            // 
            txtNewHoTen.Font = new Font("Segoe UI", 12F);
            txtNewHoTen.Location = new Point(474, 55);
            txtNewHoTen.Name = "txtNewHoTen";
            txtNewHoTen.Size = new Size(120, 29);
            txtNewHoTen.TabIndex = 97;
            // 
            // txtNewMaNV
            // 
            txtNewMaNV.Font = new Font("Segoe UI", 12F);
            txtNewMaNV.Location = new Point(127, 55);
            txtNewMaNV.Name = "txtNewMaNV";
            txtNewMaNV.Size = new Size(120, 29);
            txtNewMaNV.TabIndex = 95;
            // 
            // txtNewPhai
            // 
            txtNewPhai.Font = new Font("Segoe UI", 12F);
            txtNewPhai.Location = new Point(127, 102);
            txtNewPhai.Name = "txtNewPhai";
            txtNewPhai.Size = new Size(120, 29);
            txtNewPhai.TabIndex = 94;
            // 
            // btnDeleteNV
            // 
            btnDeleteNV.AutoSize = true;
            btnDeleteNV.FlatAppearance.BorderColor = Color.Teal;
            btnDeleteNV.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnDeleteNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnDeleteNV.FlatStyle = FlatStyle.Flat;
            btnDeleteNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteNV.ForeColor = Color.Teal;
            btnDeleteNV.Location = new Point(251, 305);
            btnDeleteNV.Name = "btnDeleteNV";
            btnDeleteNV.Size = new Size(150, 33);
            btnDeleteNV.TabIndex = 93;
            btnDeleteNV.Text = "Delete";
            btnDeleteNV.UseVisualStyleBackColor = true;
            btnDeleteNV.Click += btnDeleteNV_Click;
            // 
            // btnAddNV
            // 
            btnAddNV.AutoSize = true;
            btnAddNV.FlatAppearance.BorderColor = Color.Teal;
            btnAddNV.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnAddNV.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnAddNV.FlatStyle = FlatStyle.Flat;
            btnAddNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNV.ForeColor = Color.Teal;
            btnAddNV.Location = new Point(95, 305);
            btnAddNV.Name = "btnAddNV";
            btnAddNV.Size = new Size(150, 33);
            btnAddNV.TabIndex = 92;
            btnAddNV.Text = "Add";
            btnAddNV.UseVisualStyleBackColor = true;
            btnAddNV.Click += btnAddNV_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(63, 58);
            label12.Name = "label12";
            label12.Size = new Size(56, 21);
            label12.TabIndex = 1;
            label12.Text = "MANV";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.ForeColor = Color.Teal;
            label13.Location = new Point(427, 197);
            label13.Name = "label13";
            label13.Size = new Size(41, 21);
            label13.TabIndex = 15;
            label13.Text = "Role";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.ForeColor = Color.Teal;
            label14.Location = new Point(58, 105);
            label14.Name = "label14";
            label14.Size = new Size(61, 21);
            label14.TabIndex = 3;
            label14.Text = "Gender";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.ForeColor = Color.Teal;
            label15.Location = new Point(39, 201);
            label15.Name = "label15";
            label15.Size = new Size(77, 21);
            label15.TabIndex = 13;
            label15.Text = "Faculty ID";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNewLuong
            // 
            txtNewLuong.Font = new Font("Segoe UI", 12F);
            txtNewLuong.Location = new Point(127, 149);
            txtNewLuong.Name = "txtNewLuong";
            txtNewLuong.Size = new Size(120, 29);
            txtNewLuong.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.ForeColor = Color.Teal;
            label17.Location = new Point(63, 151);
            label17.Name = "label17";
            label17.Size = new Size(53, 21);
            label17.TabIndex = 11;
            label17.Text = "Salary";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.ForeColor = Color.Teal;
            label18.Location = new Point(391, 58);
            label18.Name = "label18";
            label18.Size = new Size(77, 21);
            label18.TabIndex = 7;
            label18.Text = "FullName";
            label18.TextAlign = ContentAlignment.TopCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.ForeColor = Color.Teal;
            label19.Location = new Point(371, 105);
            label19.Name = "label19";
            label19.Size = new Size(97, 21);
            label19.TabIndex = 9;
            label19.Text = "Date of birth";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.ForeColor = Color.Teal;
            label20.Location = new Point(1047, 35);
            label20.Name = "label20";
            label20.Size = new Size(121, 21);
            label20.TabIndex = 27;
            label20.Text = "ADD EMPLOYEE";
            label20.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(387, 151);
            label11.Name = "label11";
            label11.Size = new Size(81, 21);
            label11.TabIndex = 94;
            label11.Text = "Allowance";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvNhanVienList
            // 
            dgvNhanVienList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVienList.Location = new Point(137, 436);
            dgvNhanVienList.Name = "dgvNhanVienList";
            dgvNhanVienList.Size = new Size(1309, 376);
            dgvNhanVienList.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhuCap);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtLuong);
            groupBox1.Controls.Add(btnUpdateTeleEmployee);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtVaiTro);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaDV);
            groupBox1.Controls.Add(txtPhai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDT);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNgSinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(137, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 355);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // txtLuong
            // 
            txtLuong.BackColor = SystemColors.Control;
            txtLuong.Font = new Font("Segoe UI", 12F);
            txtLuong.Location = new Point(127, 148);
            txtLuong.Name = "txtLuong";
            txtLuong.ReadOnly = true;
            txtLuong.Size = new Size(120, 29);
            txtLuong.TabIndex = 93;
            // 
            // btnUpdateTeleEmployee
            // 
            btnUpdateTeleEmployee.AutoSize = true;
            btnUpdateTeleEmployee.FlatAppearance.BorderColor = Color.Teal;
            btnUpdateTeleEmployee.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnUpdateTeleEmployee.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnUpdateTeleEmployee.FlatStyle = FlatStyle.Flat;
            btnUpdateTeleEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateTeleEmployee.ForeColor = Color.Teal;
            btnUpdateTeleEmployee.Location = new Point(254, 305);
            btnUpdateTeleEmployee.Name = "btnUpdateTeleEmployee";
            btnUpdateTeleEmployee.Size = new Size(150, 33);
            btnUpdateTeleEmployee.TabIndex = 92;
            btnUpdateTeleEmployee.Text = "Update";
            btnUpdateTeleEmployee.UseVisualStyleBackColor = true;
            btnUpdateTeleEmployee.Click += btnUpdateTeleEmployee_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.Control;
            txtHoTen.Font = new Font("Segoe UI", 12F);
            txtHoTen.Location = new Point(474, 55);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(120, 29);
            txtHoTen.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(63, 58);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 1;
            label1.Text = "MANV";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtVaiTro
            // 
            txtVaiTro.BackColor = SystemColors.Control;
            txtVaiTro.Font = new Font("Segoe UI", 12F);
            txtVaiTro.Location = new Point(474, 198);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.ReadOnly = true;
            txtVaiTro.Size = new Size(120, 29);
            txtVaiTro.TabIndex = 16;
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = SystemColors.Control;
            txtMaNV.Font = new Font("Segoe UI", 12F);
            txtMaNV.Location = new Point(127, 55);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(120, 29);
            txtMaNV.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(427, 201);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 15;
            label7.Text = "Role";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(58, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Gender";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMaDV
            // 
            txtMaDV.BackColor = SystemColors.Control;
            txtMaDV.Font = new Font("Segoe UI", 12F);
            txtMaDV.Location = new Point(127, 247);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.ReadOnly = true;
            txtMaDV.Size = new Size(120, 29);
            txtMaDV.TabIndex = 14;
            // 
            // txtPhai
            // 
            txtPhai.BackColor = SystemColors.Control;
            txtPhai.Font = new Font("Segoe UI", 12F);
            txtPhai.Location = new Point(127, 102);
            txtPhai.Name = "txtPhai";
            txtPhai.ReadOnly = true;
            txtPhai.Size = new Size(120, 29);
            txtPhai.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(39, 250);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 13;
            label8.Text = "Faculty ID";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(63, 151);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Salary";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDT
            // 
            txtDT.Font = new Font("Segoe UI", 12F);
            txtDT.Location = new Point(127, 198);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(120, 29);
            txtDT.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(36, 201);
            label9.Name = "label9";
            label9.Size = new Size(80, 21);
            label9.TabIndex = 11;
            label9.Text = "Telephone";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(391, 58);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = "FullName";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNgSinh
            // 
            txtNgSinh.BackColor = SystemColors.Control;
            txtNgSinh.Font = new Font("Segoe UI", 12F);
            txtNgSinh.Location = new Point(474, 102);
            txtNgSinh.Name = "txtNgSinh";
            txtNgSinh.ReadOnly = true;
            txtNgSinh.Size = new Size(120, 29);
            txtNgSinh.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(371, 105);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 9;
            label5.Text = "Date of birth";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(380, 35);
            label6.Name = "label6";
            label6.Size = new Size(136, 21);
            label6.TabIndex = 25;
            label6.Text = "EMPLOYEE's INFO";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(768, 826);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 30;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashBoard_NVTCHC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(btnLogout);
            Controls.Add(groupBox2);
            Controls.Add(label20);
            Controls.Add(dgvNhanVienList);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Name = "DashBoard_NVTCHC";
            Text = "DashBoard_NVTCHC";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhuCap;
        private Button btnUpdateNV;
        private TextBox txtNewPhuCap;
        private Label label10;
        private TextBox txtNewDT;
        private Label label16;
        private ComboBox cbbNewMaDV;
        private ComboBox cbbNewVaiTro;
        private GroupBox groupBox2;
        private Button btnResetForm;
        private TextBox txtNewHoTen;
        private TextBox txtNewMaNV;
        private TextBox txtNewPhai;
        private Button btnDeleteNV;
        private Button btnAddNV;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtNewLuong;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label11;
        private DataGridView dgvNhanVienList;
        private GroupBox groupBox1;
        private TextBox txtLuong;
        private Button btnUpdateTeleEmployee;
        private TextBox txtHoTen;
        private Label label1;
        private TextBox txtVaiTro;
        private TextBox txtMaNV;
        private Label label7;
        private Label label2;
        private TextBox txtMaDV;
        private TextBox txtPhai;
        private Label label8;
        private Label label3;
        private TextBox txtDT;
        private Label label9;
        private Label label4;
        private TextBox txtNgSinh;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpNewNgSinh;
        private Button btnLogout;
    }
}