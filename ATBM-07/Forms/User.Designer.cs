namespace ATBM_07
{
    partial class User
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
            label2 = new Label();
            labelRoles_User1 = new Label();
            comboBoxRoles_User1 = new ComboBox();
            comboBoxUsers_User1 = new ComboBox();
            listViewUsers_User1 = new ListView();
            labelSearchUser_User1 = new Label();
            buttonDelete_User = new Button();
            textBoxUsername = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBoxPassword = new TextBox();
            buttonCreateUser = new Button();
            buttonViewPriv_User = new Button();
            buttonRevoke_User = new Button();
            listViewPrivs_User = new ListView();
            buttonRevokeRole = new Button();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(725, 16);
            label1.Name = "label1";
            label1.Size = new Size(451, 45);
            label1.TabIndex = 0;
            label1.Text = "ORACLE DATABASE MANAGER";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(829, 98);
            label2.Name = "label2";
            label2.Size = new Size(222, 45);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelRoles_User1
            // 
            labelRoles_User1.AutoSize = true;
            labelRoles_User1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRoles_User1.ForeColor = Color.Teal;
            labelRoles_User1.Location = new Point(132, 262);
            labelRoles_User1.Name = "labelRoles_User1";
            labelRoles_User1.Size = new Size(118, 45);
            labelRoles_User1.TabIndex = 4;
            labelRoles_User1.Text = "ROLES:";
            // 
            // comboBoxRoles_User1
            // 
            comboBoxRoles_User1.FormattingEnabled = true;
            comboBoxRoles_User1.Location = new Point(132, 320);
            comboBoxRoles_User1.Name = "comboBoxRoles_User1";
            comboBoxRoles_User1.Size = new Size(382, 53);
            comboBoxRoles_User1.TabIndex = 5;
            // 
            // comboBoxUsers_User1
            // 
            comboBoxUsers_User1.FormattingEnabled = true;
            comboBoxUsers_User1.Location = new Point(132, 461);
            comboBoxUsers_User1.Name = "comboBoxUsers_User1";
            comboBoxUsers_User1.Size = new Size(382, 53);
            comboBoxUsers_User1.TabIndex = 6;
            // 
            // listViewUsers_User1
            // 
            listViewUsers_User1.Location = new Point(133, 553);
            listViewUsers_User1.Name = "listViewUsers_User1";
            listViewUsers_User1.Size = new Size(381, 317);
            listViewUsers_User1.TabIndex = 7;
            listViewUsers_User1.UseCompatibleStateImageBehavior = false;
            // 
            // labelSearchUser_User1
            // 
            labelSearchUser_User1.AutoSize = true;
            labelSearchUser_User1.BackColor = Color.White;
            labelSearchUser_User1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearchUser_User1.ForeColor = Color.Teal;
            labelSearchUser_User1.Location = new Point(132, 399);
            labelSearchUser_User1.Name = "labelSearchUser_User1";
            labelSearchUser_User1.Size = new Size(226, 45);
            labelSearchUser_User1.TabIndex = 8;
            labelSearchUser_User1.Text = "SEARCH USER:";
            // 
            // buttonDelete_User
            // 
            buttonDelete_User.AutoSize = true;
            buttonDelete_User.BackColor = Color.Teal;
            buttonDelete_User.Enabled = false;
            buttonDelete_User.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete_User.ForeColor = Color.White;
            buttonDelete_User.Location = new Point(609, 456);
            buttonDelete_User.Name = "buttonDelete_User";
            buttonDelete_User.Size = new Size(232, 65);
            buttonDelete_User.TabIndex = 9;
            buttonDelete_User.Text = "DELETE";
            buttonDelete_User.UseVisualStyleBackColor = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(840, 257);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(348, 50);
            textBoxUsername.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(612, 257);
            label5.Name = "label5";
            label5.Size = new Size(191, 45);
            label5.TabIndex = 11;
            label5.Text = "USERNAME:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(612, 354);
            label6.Name = "label6";
            label6.Size = new Size(193, 45);
            label6.TabIndex = 13;
            label6.Text = "PASSWORD:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(840, 351);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(348, 50);
            textBoxPassword.TabIndex = 12;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.AutoSize = true;
            buttonCreateUser.BackColor = Color.Teal;
            buttonCreateUser.Enabled = false;
            buttonCreateUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateUser.ForeColor = Color.White;
            buttonCreateUser.Location = new Point(1260, 308);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(249, 65);
            buttonCreateUser.TabIndex = 14;
            buttonCreateUser.Text = "CREATE USER";
            buttonCreateUser.UseVisualStyleBackColor = false;
            // 
            // buttonViewPriv_User
            // 
            buttonViewPriv_User.AutoSize = true;
            buttonViewPriv_User.BackColor = Color.Teal;
            buttonViewPriv_User.Enabled = false;
            buttonViewPriv_User.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewPriv_User.ForeColor = Color.White;
            buttonViewPriv_User.Location = new Point(873, 456);
            buttonViewPriv_User.Name = "buttonViewPriv_User";
            buttonViewPriv_User.Size = new Size(232, 65);
            buttonViewPriv_User.TabIndex = 83;
            buttonViewPriv_User.Text = "VIEW PRIV";
            buttonViewPriv_User.UseVisualStyleBackColor = false;
            // 
            // buttonRevoke_User
            // 
            buttonRevoke_User.AutoSize = true;
            buttonRevoke_User.BackColor = Color.Teal;
            buttonRevoke_User.Enabled = false;
            buttonRevoke_User.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRevoke_User.ForeColor = Color.White;
            buttonRevoke_User.Location = new Point(1135, 456);
            buttonRevoke_User.Margin = new Padding(4);
            buttonRevoke_User.Name = "buttonRevoke_User";
            buttonRevoke_User.Size = new Size(232, 65);
            buttonRevoke_User.TabIndex = 100;
            buttonRevoke_User.Text = "REVOKE PRIV";
            buttonRevoke_User.UseVisualStyleBackColor = false;
            // 
            // listViewPrivs_User
            // 
            listViewPrivs_User.Location = new Point(608, 553);
            listViewPrivs_User.Name = "listViewPrivs_User";
            listViewPrivs_User.Size = new Size(1018, 317);
            listViewPrivs_User.TabIndex = 101;
            listViewPrivs_User.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRevokeRole
            // 
            buttonRevokeRole.AutoSize = true;
            buttonRevokeRole.BackColor = Color.Teal;
            buttonRevokeRole.Enabled = false;
            buttonRevokeRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRevokeRole.ForeColor = Color.White;
            buttonRevokeRole.Location = new Point(1394, 456);
            buttonRevokeRole.Margin = new Padding(4);
            buttonRevokeRole.Name = "buttonRevokeRole";
            buttonRevokeRole.Size = new Size(238, 65);
            buttonRevokeRole.TabIndex = 102;
            buttonRevokeRole.Text = "REVOKE ROLE";
            buttonRevokeRole.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1894, 1009);
            Controls.Add(buttonRevokeRole);
            Controls.Add(listViewPrivs_User);
            Controls.Add(buttonRevoke_User);
            Controls.Add(buttonViewPriv_User);
            Controls.Add(buttonCreateUser);
            Controls.Add(label6);
            Controls.Add(textBoxPassword);
            Controls.Add(label5);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonDelete_User);
            Controls.Add(labelSearchUser_User1);
            Controls.Add(listViewUsers_User1);
            Controls.Add(comboBoxUsers_User1);
            Controls.Add(comboBoxRoles_User1);
            Controls.Add(labelRoles_User1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "User";
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label labelRoles_User1;
        private ComboBox comboBoxRoles_User1;
        private ComboBox comboBoxUsers_User1;
        private ListView listViewUsers_User1;
        private Label labelSearchUser_User1;
        private Button buttonDelete_User;
        private TextBox textBoxUsername;
        private Label label5;
        private Label label6;
        private TextBox textBoxPassword;
        private Button buttonCreateUser;
        private Button buttonViewPriv_User;
        private Button buttonRevoke_User;
        private ListView listViewPrivs_User;
        private Button buttonRevokeRole;
    }
}