namespace ATBM_07.Forms
{
    partial class DashBoard_SV
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
            lbMaSV = new Label();
            txtMaSV = new TextBox();
            txtPhai = new TextBox();
            lbPhai = new Label();
            txtDiaChi = new TextBox();
            lbDiaChi = new Label();
            txtHoTen = new TextBox();
            lbHoTen = new Label();
            txtNgSinh = new TextBox();
            lbNgSinh = new Label();
            txtKhoa = new TextBox();
            lbKhoa = new Label();
            txtTinhTrang = new TextBox();
            lbTrangThai = new Label();
            txtDT = new TextBox();
            lbDT = new Label();
            lbSTUDENTINFO = new Label();
            groupBox1 = new GroupBox();
            btnStudentUpdateStudent = new Button();
            lbREGISTERFORCOURSES = new Label();
            dataGridView1 = new DataGridView();
            btnSudentInsertCourse = new Button();
            txtMaMM = new TextBox();
            label11 = new Label();
            btnSudentDeleteCourse = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbMaSV
            // 
            lbMaSV.AutoSize = true;
            lbMaSV.Font = new Font("Segoe UI", 12F);
            lbMaSV.ForeColor = Color.Teal;
            lbMaSV.Location = new Point(83, 60);
            lbMaSV.Name = "lbMaSV";
            lbMaSV.Size = new Size(53, 21);
            lbMaSV.TabIndex = 1;
            lbMaSV.Text = "MASV";
            lbMaSV.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMaSV
            // 
            txtMaSV.BackColor = SystemColors.Control;
            txtMaSV.Font = new Font("Segoe UI", 12F);
            txtMaSV.Location = new Point(147, 57);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.ReadOnly = true;
            txtMaSV.Size = new Size(120, 29);
            txtMaSV.TabIndex = 2;
            txtMaSV.TextChanged += txtMaSV_TextChanged;
            // 
            // txtPhai
            // 
            txtPhai.BackColor = SystemColors.Control;
            txtPhai.Font = new Font("Segoe UI", 12F);
            txtPhai.Location = new Point(147, 101);
            txtPhai.Name = "txtPhai";
            txtPhai.ReadOnly = true;
            txtPhai.Size = new Size(120, 29);
            txtPhai.TabIndex = 4;
            // 
            // lbPhai
            // 
            lbPhai.AutoSize = true;
            lbPhai.Font = new Font("Segoe UI", 12F);
            lbPhai.ForeColor = Color.Teal;
            lbPhai.Location = new Point(75, 104);
            lbPhai.Name = "lbPhai";
            lbPhai.Size = new Size(61, 21);
            lbPhai.TabIndex = 3;
            lbPhai.Text = "Gender";
            lbPhai.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(147, 150);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(467, 29);
            txtDiaChi.TabIndex = 6;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Font = new Font("Segoe UI", 12F);
            lbDiaChi.ForeColor = Color.Teal;
            lbDiaChi.Location = new Point(70, 153);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(66, 21);
            lbDiaChi.TabIndex = 5;
            lbDiaChi.Text = "Address";
            lbDiaChi.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.Control;
            txtHoTen.Font = new Font("Segoe UI", 12F);
            txtHoTen.Location = new Point(494, 57);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(120, 29);
            txtHoTen.TabIndex = 8;
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Font = new Font("Segoe UI", 12F);
            lbHoTen.ForeColor = Color.Teal;
            lbHoTen.Location = new Point(399, 60);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(72, 27);
            lbHoTen.TabIndex = 7;
            lbHoTen.Text = "Fullname";
            lbHoTen.TextAlign = ContentAlignment.TopCenter;
            lbHoTen.UseCompatibleTextRendering = true;
            // 
            // txtNgSinh
            // 
            txtNgSinh.BackColor = SystemColors.Control;
            txtNgSinh.Font = new Font("Segoe UI", 12F);
            txtNgSinh.Location = new Point(494, 101);
            txtNgSinh.Name = "txtNgSinh";
            txtNgSinh.ReadOnly = true;
            txtNgSinh.Size = new Size(120, 29);
            txtNgSinh.TabIndex = 10;
            // 
            // lbNgSinh
            // 
            lbNgSinh.AutoSize = true;
            lbNgSinh.Font = new Font("Segoe UI", 12F);
            lbNgSinh.ForeColor = Color.Teal;
            lbNgSinh.Location = new Point(385, 104);
            lbNgSinh.Name = "lbNgSinh";
            lbNgSinh.Size = new Size(97, 21);
            lbNgSinh.TabIndex = 9;
            lbNgSinh.Text = "Date of birth";
            lbNgSinh.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtKhoa
            // 
            txtKhoa.BackColor = SystemColors.Control;
            txtKhoa.Font = new Font("Segoe UI", 12F);
            txtKhoa.Location = new Point(494, 205);
            txtKhoa.Name = "txtKhoa";
            txtKhoa.ReadOnly = true;
            txtKhoa.Size = new Size(120, 29);
            txtKhoa.TabIndex = 16;
            // 
            // lbKhoa
            // 
            lbKhoa.AutoSize = true;
            lbKhoa.Font = new Font("Segoe UI", 12F);
            lbKhoa.ForeColor = Color.Teal;
            lbKhoa.Location = new Point(389, 208);
            lbKhoa.Name = "lbKhoa";
            lbKhoa.Size = new Size(93, 21);
            lbKhoa.TabIndex = 15;
            lbKhoa.Text = "Department";
            lbKhoa.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.BackColor = SystemColors.Control;
            txtTinhTrang.Font = new Font("Segoe UI", 12F);
            txtTinhTrang.Location = new Point(147, 249);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.ReadOnly = true;
            txtTinhTrang.Size = new Size(120, 29);
            txtTinhTrang.TabIndex = 14;
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Font = new Font("Segoe UI", 12F);
            lbTrangThai.ForeColor = Color.Teal;
            lbTrangThai.Location = new Point(84, 252);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(52, 21);
            lbTrangThai.TabIndex = 13;
            lbTrangThai.Text = "Status";
            lbTrangThai.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtDT
            // 
            txtDT.Font = new Font("Segoe UI", 12F);
            txtDT.Location = new Point(147, 205);
            txtDT.Name = "txtDT";
            txtDT.Size = new Size(120, 29);
            txtDT.TabIndex = 12;
            // 
            // lbDT
            // 
            lbDT.AutoSize = true;
            lbDT.Font = new Font("Segoe UI", 12F);
            lbDT.ForeColor = Color.Teal;
            lbDT.Location = new Point(23, 208);
            lbDT.Name = "lbDT";
            lbDT.Size = new Size(113, 21);
            lbDT.TabIndex = 11;
            lbDT.Text = "Phone number";
            lbDT.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbSTUDENTINFO
            // 
            lbSTUDENTINFO.AutoSize = true;
            lbSTUDENTINFO.Font = new Font("Segoe UI", 12F);
            lbSTUDENTINFO.ForeColor = Color.Teal;
            lbSTUDENTINFO.Location = new Point(324, 35);
            lbSTUDENTINFO.Name = "lbSTUDENTINFO";
            lbSTUDENTINFO.Size = new Size(128, 21);
            lbSTUDENTINFO.TabIndex = 17;
            lbSTUDENTINFO.Text = "STUDENT's INFO";
            lbSTUDENTINFO.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStudentUpdateStudent);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(lbMaSV);
            groupBox1.Controls.Add(txtKhoa);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(lbKhoa);
            groupBox1.Controls.Add(lbPhai);
            groupBox1.Controls.Add(txtTinhTrang);
            groupBox1.Controls.Add(txtPhai);
            groupBox1.Controls.Add(lbTrangThai);
            groupBox1.Controls.Add(lbDiaChi);
            groupBox1.Controls.Add(txtDT);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(lbDT);
            groupBox1.Controls.Add(lbHoTen);
            groupBox1.Controls.Add(txtNgSinh);
            groupBox1.Controls.Add(lbNgSinh);
            groupBox1.Location = new Point(39, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 355);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // btnStudentUpdateStudent
            // 
            btnStudentUpdateStudent.AutoSize = true;
            btnStudentUpdateStudent.FlatAppearance.BorderColor = Color.Teal;
            btnStudentUpdateStudent.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnStudentUpdateStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnStudentUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnStudentUpdateStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentUpdateStudent.ForeColor = Color.Teal;
            btnStudentUpdateStudent.Location = new Point(263, 305);
            btnStudentUpdateStudent.Name = "btnStudentUpdateStudent";
            btnStudentUpdateStudent.Size = new Size(150, 33);
            btnStudentUpdateStudent.TabIndex = 92;
            btnStudentUpdateStudent.Text = "Update";
            btnStudentUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // lbREGISTERFORCOURSES
            // 
            lbREGISTERFORCOURSES.AutoSize = true;
            lbREGISTERFORCOURSES.Font = new Font("Segoe UI", 12F);
            lbREGISTERFORCOURSES.ForeColor = Color.Teal;
            lbREGISTERFORCOURSES.Location = new Point(372, 441);
            lbREGISTERFORCOURSES.Name = "lbREGISTERFORCOURSES";
            lbREGISTERFORCOURSES.Size = new Size(185, 21);
            lbREGISTERFORCOURSES.TabIndex = 19;
            lbREGISTERFORCOURSES.Text = "REGISTER FOR COURSES";
            lbREGISTERFORCOURSES.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(483, 271);
            dataGridView1.TabIndex = 20;
            // 
            // btnSudentInsertCourse
            // 
            btnSudentInsertCourse.AutoSize = true;
            btnSudentInsertCourse.FlatAppearance.BorderColor = Color.Teal;
            btnSudentInsertCourse.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnSudentInsertCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnSudentInsertCourse.FlatStyle = FlatStyle.Flat;
            btnSudentInsertCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSudentInsertCourse.ForeColor = Color.Teal;
            btnSudentInsertCourse.Location = new Point(593, 553);
            btnSudentInsertCourse.Name = "btnSudentInsertCourse";
            btnSudentInsertCourse.Size = new Size(64, 33);
            btnSudentInsertCourse.TabIndex = 93;
            btnSudentInsertCourse.Text = "Insert";
            btnSudentInsertCourse.UseVisualStyleBackColor = true;
            btnSudentInsertCourse.Click += btnSudentInsertCourse_Click;
            // 
            // txtMaMM
            // 
            txtMaMM.Font = new Font("Segoe UI", 12F);
            txtMaMM.Location = new Point(667, 500);
            txtMaMM.Name = "txtMaMM";
            txtMaMM.Size = new Size(120, 29);
            txtMaMM.TabIndex = 94;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(593, 503);
            label11.Name = "label11";
            label11.Size = new Size(62, 21);
            label11.TabIndex = 93;
            label11.Text = "MAMM";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSudentDeleteCourse
            // 
            btnSudentDeleteCourse.AutoSize = true;
            btnSudentDeleteCourse.FlatAppearance.BorderColor = Color.Teal;
            btnSudentDeleteCourse.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnSudentDeleteCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnSudentDeleteCourse.FlatStyle = FlatStyle.Flat;
            btnSudentDeleteCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSudentDeleteCourse.ForeColor = Color.Teal;
            btnSudentDeleteCourse.Location = new Point(593, 663);
            btnSudentDeleteCourse.Name = "btnSudentDeleteCourse";
            btnSudentDeleteCourse.Size = new Size(66, 33);
            btnSudentDeleteCourse.TabIndex = 95;
            btnSudentDeleteCourse.Text = "Delete";
            btnSudentDeleteCourse.UseVisualStyleBackColor = true;
            btnSudentDeleteCourse.Click += btnSudentDeleteCourse_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(39, 465);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 326);
            groupBox2.TabIndex = 96;
            groupBox2.TabStop = false;
            // 
            // DashBoard_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(btnSudentDeleteCourse);
            Controls.Add(txtMaMM);
            Controls.Add(label11);
            Controls.Add(btnSudentInsertCourse);
            Controls.Add(lbREGISTERFORCOURSES);
            Controls.Add(groupBox1);
            Controls.Add(lbSTUDENTINFO);
            Controls.Add(groupBox2);
            Name = "DashBoard_SV";
            Text = "SV";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbMaSV;
        private TextBox txtMaSV;
        private TextBox txtPhai;
        private Label lbPhai;
        private TextBox txtDiaChi;
        private Label lbDiaChi;
        private TextBox txtHoTen;
        private Label lbHoTen;
        private TextBox txtNgSinh;
        private Label lbNgSinh;
        private TextBox txtKhoa;
        private Label lbKhoa;
        private TextBox txtTinhTrang;
        private Label lbTrangThai;
        private TextBox txtDT;
        private Label lbDT;
        private Label lbSTUDENTINFO;
        private GroupBox groupBox1;
        private Button btnStudentUpdateStudent;
        private Label lbREGISTERFORCOURSES;
        private DataGridView dataGridView1;
        private Button btnSudentInsertCourse;
        private TextBox txtMaMM;
        private Label label11;
        private Button btnSudentDeleteCourse;
        private GroupBox groupBox2;
    }
}