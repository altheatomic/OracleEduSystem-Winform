namespace ATBM_07.Forms
{
    partial class DashBoard_Admin
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
            btnUsers = new Button();
            btnRoles = new Button();
            btnGrantToUser = new Button();
            btnGrantToRole = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1894, 75);
            panel1.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(745, 13);
            label1.Name = "label1";
            label1.Size = new Size(451, 45);
            label1.TabIndex = 0;
            label1.Text = "ORACLE DATABASE MANAGER";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnUsers
            // 
            btnUsers.AutoSize = true;
            btnUsers.FlatAppearance.BorderColor = Color.Teal;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.Teal;
            btnUsers.Location = new Point(891, 328);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(150, 57);
            btnUsers.TabIndex = 91;
            btnUsers.Text = "USERS";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            btnRoles.AutoSize = true;
            btnRoles.FlatAppearance.BorderColor = Color.Teal;
            btnRoles.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoles.ForeColor = Color.Teal;
            btnRoles.Location = new Point(891, 439);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(150, 57);
            btnRoles.TabIndex = 92;
            btnRoles.Text = "ROLES";
            btnRoles.UseVisualStyleBackColor = true;
            // 
            // btnGrantToUser
            // 
            btnGrantToUser.AutoSize = true;
            btnGrantToUser.FlatAppearance.BorderColor = Color.Teal;
            btnGrantToUser.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnGrantToUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnGrantToUser.FlatStyle = FlatStyle.Flat;
            btnGrantToUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrantToUser.ForeColor = Color.Teal;
            btnGrantToUser.Location = new Point(783, 552);
            btnGrantToUser.Name = "btnGrantToUser";
            btnGrantToUser.Size = new Size(369, 57);
            btnGrantToUser.TabIndex = 93;
            btnGrantToUser.Text = "Grant Privileges To User";
            btnGrantToUser.UseVisualStyleBackColor = true;
            // 
            // btnGrantToRole
            // 
            btnGrantToRole.AutoSize = true;
            btnGrantToRole.FlatAppearance.BorderColor = Color.Teal;
            btnGrantToRole.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnGrantToRole.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnGrantToRole.FlatStyle = FlatStyle.Flat;
            btnGrantToRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrantToRole.ForeColor = Color.Teal;
            btnGrantToRole.Location = new Point(785, 666);
            btnGrantToRole.Name = "btnGrantToRole";
            btnGrantToRole.Size = new Size(367, 57);
            btnGrantToRole.TabIndex = 94;
            btnGrantToRole.Text = "Grant Privileges To Role";
            btnGrantToRole.UseVisualStyleBackColor = true;
            // 
            // DashBoard_Admin
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1894, 1009);
            Controls.Add(btnGrantToRole);
            Controls.Add(btnGrantToUser);
            Controls.Add(btnRoles);
            Controls.Add(btnUsers);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DashBoard_Admin";
            Text = "DashBoard_Admin";
            Load += DashBoard_Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button btnUsers;
        private Button btnRoles;
        private Button btnGrantToUser;
        private Button btnGrantToRole;
    }
}