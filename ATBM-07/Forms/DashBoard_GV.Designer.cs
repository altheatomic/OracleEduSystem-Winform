namespace ATBM_07.Forms
{
    partial class DashBoard_GV
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
            panel1 = new Panel();
            label1 = new Label();
            label_user = new Label();
            label_subject = new Label();
            cbb_subject = new ComboBox();
            label_class = new Label();
            cbb_class = new ComboBox();
            label2 = new Label();
            txt_user = new TextBox();
            txt_department = new TextBox();
            dgv_listofstudent = new DataGridView();
            txt_enterIDofstudent = new TextBox();
            btnFind = new Button();
            label_idofstudent = new Label();
            label_listofstudent = new Label();
            lable_Role = new Label();
            txt_role = new TextBox();
            btn_ResetForm = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listofstudent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 75);
            panel1.TabIndex = 91;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(745, 13);
            label1.Name = "label1";
            label1.Size = new Size(281, 28);
            label1.TabIndex = 0;
            label1.Text = "ORACLE DATABASE MANAGER";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_user.ForeColor = Color.Teal;
            label_user.Location = new Point(170, 160);
            label_user.Margin = new Padding(2, 0, 2, 0);
            label_user.Name = "label_user";
            label_user.Size = new Size(63, 28);
            label_user.TabIndex = 93;
            label_user.Text = "USER:";
            label_user.Click += label2_Click;
            // 
            // label_subject
            // 
            label_subject.AutoSize = true;
            label_subject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_subject.ForeColor = Color.Teal;
            label_subject.Location = new Point(979, 160);
            label_subject.Margin = new Padding(2, 0, 2, 0);
            label_subject.Name = "label_subject";
            label_subject.Size = new Size(91, 28);
            label_subject.TabIndex = 95;
            label_subject.Text = "SUBJECT:";
            // 
            // cbb_subject
            // 
            cbb_subject.FormattingEnabled = true;
            cbb_subject.Location = new Point(979, 213);
            cbb_subject.Name = "cbb_subject";
            cbb_subject.Size = new Size(291, 36);
            cbb_subject.TabIndex = 94;
            cbb_subject.SelectedIndexChanged += cbb_subject_SelectedIndexChanged;
            // 
            // label_class
            // 
            label_class.AutoSize = true;
            label_class.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_class.ForeColor = Color.Teal;
            label_class.Location = new Point(1340, 160);
            label_class.Margin = new Padding(2, 0, 2, 0);
            label_class.Name = "label_class";
            label_class.Size = new Size(73, 28);
            label_class.TabIndex = 97;
            label_class.Text = "CLASS:";
            // 
            // cbb_class
            // 
            cbb_class.FormattingEnabled = true;
            cbb_class.Location = new Point(1340, 213);
            cbb_class.Name = "cbb_class";
            cbb_class.Size = new Size(291, 36);
            cbb_class.TabIndex = 96;
            cbb_class.SelectedIndexChanged += cbb_class_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(470, 160);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 98;
            label2.Text = "DEPARTMENT:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(170, 213);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(275, 34);
            txt_user.TabIndex = 99;
            txt_user.TextChanged += textBox1_TextChanged;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(470, 213);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(339, 34);
            txt_department.TabIndex = 100;
            txt_department.TextChanged += textBox2_TextChanged;
            // 
            // dgv_listofstudent
            // 
            dgv_listofstudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listofstudent.Location = new Point(170, 460);
            dgv_listofstudent.Name = "dgv_listofstudent";
            dgv_listofstudent.RowHeadersWidth = 51;
            dgv_listofstudent.Size = new Size(1461, 463);
            dgv_listofstudent.TabIndex = 101;
            dgv_listofstudent.CellContentClick += dgv_listofstudent_CellContentClick;
            // 
            // txt_enterIDofstudent
            // 
            txt_enterIDofstudent.Location = new Point(170, 320);
            txt_enterIDofstudent.Name = "txt_enterIDofstudent";
            txt_enterIDofstudent.Size = new Size(639, 34);
            txt_enterIDofstudent.TabIndex = 102;
            txt_enterIDofstudent.TextChanged += txt_enterIDofstudent_TextChanged;
            // 
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.FlatAppearance.BorderColor = Color.Teal;
            btnFind.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnFind.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.Teal;
            btnFind.Location = new Point(845, 309);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(150, 57);
            btnFind.TabIndex = 103;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label_idofstudent
            // 
            label_idofstudent.AutoSize = true;
            label_idofstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_idofstudent.ForeColor = Color.Teal;
            label_idofstudent.Location = new Point(170, 277);
            label_idofstudent.Margin = new Padding(2, 0, 2, 0);
            label_idofstudent.Name = "label_idofstudent";
            label_idofstudent.Size = new Size(216, 28);
            label_idofstudent.TabIndex = 104;
            label_idofstudent.Text = "ENTER ID OF STUDENT:";
            // 
            // label_listofstudent
            // 
            label_listofstudent.AutoSize = true;
            label_listofstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_listofstudent.ForeColor = Color.Teal;
            label_listofstudent.Location = new Point(170, 399);
            label_listofstudent.Margin = new Padding(2, 0, 2, 0);
            label_listofstudent.Name = "label_listofstudent";
            label_listofstudent.Size = new Size(181, 28);
            label_listofstudent.TabIndex = 105;
            label_listofstudent.Text = "LIST OF STUDENTS:";
            // 
            // lable_Role
            // 
            lable_Role.AutoSize = true;
            lable_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lable_Role.ForeColor = Color.Teal;
            lable_Role.Location = new Point(845, 160);
            lable_Role.Margin = new Padding(2, 0, 2, 0);
            lable_Role.Name = "lable_Role";
            lable_Role.Size = new Size(62, 28);
            lable_Role.TabIndex = 106;
            lable_Role.Text = "ROLE:";
            lable_Role.Click += label3_Click;
            // 
            // txt_role
            // 
            txt_role.Location = new Point(845, 213);
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(101, 34);
            txt_role.TabIndex = 107;
            txt_role.TextChanged += txt_role_TextChanged;
            // 
            // btn_ResetForm
            // 
            btn_ResetForm.AutoSize = true;
            btn_ResetForm.FlatAppearance.BorderColor = Color.Teal;
            btn_ResetForm.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btn_ResetForm.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btn_ResetForm.FlatStyle = FlatStyle.Flat;
            btn_ResetForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ResetForm.ForeColor = Color.Teal;
            btn_ResetForm.Location = new Point(1080, 309);
            btn_ResetForm.Name = "btn_ResetForm";
            btn_ResetForm.Size = new Size(150, 57);
            btn_ResetForm.TabIndex = 108;
            btn_ResetForm.Text = "RESET FORM";
            btn_ResetForm.UseVisualStyleBackColor = true;
            btn_ResetForm.Click += btn_ResetForm_Click;
            // 
            // DashBoard_GV
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btn_ResetForm);
            Controls.Add(txt_role);
            Controls.Add(lable_Role);
            Controls.Add(label_listofstudent);
            Controls.Add(label_idofstudent);
            Controls.Add(btnFind);
            Controls.Add(txt_enterIDofstudent);
            Controls.Add(dgv_listofstudent);
            Controls.Add(txt_department);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label_class);
            Controls.Add(cbb_class);
            Controls.Add(label_subject);
            Controls.Add(cbb_subject);
            Controls.Add(label_user);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "DashBoard_GV";
            Text = "DashBoard_GV";
            Load += DashBoard_GV_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listofstudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label_user;
        private Label label_subject;
        private ComboBox cbb_subject;
        private Label label_class;
        private ComboBox cbb_class;
        private Label label2;
        private TextBox txt_user;
        private TextBox txt_department;
        private DataGridView dgv_listofstudent;
        private TextBox txt_enterIDofstudent;
        private Button btnFind;
        private Label label_idofstudent;
        private Label label_listofstudent;
        private Label lable_Role;
        private TextBox txt_role;
        private Button btn_ResetForm;
    }
}