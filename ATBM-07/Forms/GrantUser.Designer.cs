 namespace ATBM_07
{
    partial class GrantUser
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
            buttonGrantPriv_User = new Button();
            checkBoxWithGrant_User = new CheckBox();
            comboBoxColumns_User = new ComboBox();
            labelColumn_User = new Label();
            comboBoxPrivTypes_User = new ComboBox();
            labelPrivType_User = new Label();
            comboBoxPrivs_User = new ComboBox();
            comboBoxObjects_User = new ComboBox();
            labelObject_User = new Label();
            labelPriv_User = new Label();
            comboBoxGrantRole = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            labelSearchUser_User2 = new Label();
            listViewUsers_User2 = new ListView();
            comboBoxUsers_User2 = new ComboBox();
            comboBoxRoles_User2 = new ComboBox();
            labelRoles_User2 = new Label();
            checkBoxGrantRole = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGrantPriv_User
            // 
            buttonGrantPriv_User.AutoSize = true;
            buttonGrantPriv_User.BackColor = Color.Teal;
            buttonGrantPriv_User.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGrantPriv_User.ForeColor = Color.White;
            buttonGrantPriv_User.Location = new Point(1192, 816);
            buttonGrantPriv_User.Margin = new Padding(4);
            buttonGrantPriv_User.Name = "buttonGrantPriv_User";
            buttonGrantPriv_User.Size = new Size(312, 91);
            buttonGrantPriv_User.TabIndex = 80;
            buttonGrantPriv_User.Text = "GRANT PRIV";
            buttonGrantPriv_User.UseVisualStyleBackColor = false;
            buttonGrantPriv_User.Click += buttonGrantPriv_User_Click;
            // 
            // checkBoxWithGrant_User
            // 
            checkBoxWithGrant_User.AutoSize = true;
            checkBoxWithGrant_User.ForeColor = Color.Teal;
            checkBoxWithGrant_User.Location = new Point(1338, 692);
            checkBoxWithGrant_User.Margin = new Padding(4);
            checkBoxWithGrant_User.Name = "checkBoxWithGrant_User";
            checkBoxWithGrant_User.Size = new Size(368, 49);
            checkBoxWithGrant_User.TabIndex = 79;
            checkBoxWithGrant_User.Text = "WITH GRANT OPTION";
            checkBoxWithGrant_User.UseVisualStyleBackColor = true;
            // 
            // comboBoxColumns_User
            // 
            comboBoxColumns_User.FormattingEnabled = true;
            comboBoxColumns_User.Location = new Point(1320, 601);
            comboBoxColumns_User.Margin = new Padding(4);
            comboBoxColumns_User.Name = "comboBoxColumns_User";
            comboBoxColumns_User.Size = new Size(386, 53);
            comboBoxColumns_User.TabIndex = 78;
            // 
            // labelColumn_User
            // 
            labelColumn_User.AutoSize = true;
            labelColumn_User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelColumn_User.ForeColor = Color.Teal;
            labelColumn_User.Location = new Point(1320, 539);
            labelColumn_User.Margin = new Padding(4, 0, 4, 0);
            labelColumn_User.Name = "labelColumn_User";
            labelColumn_User.Size = new Size(159, 45);
            labelColumn_User.TabIndex = 77;
            labelColumn_User.Text = "COLUMN:";
            // 
            // comboBoxPrivTypes_User
            // 
            comboBoxPrivTypes_User.FormattingEnabled = true;
            comboBoxPrivTypes_User.Location = new Point(987, 460);
            comboBoxPrivTypes_User.Margin = new Padding(4);
            comboBoxPrivTypes_User.Name = "comboBoxPrivTypes_User";
            comboBoxPrivTypes_User.Size = new Size(190, 53);
            comboBoxPrivTypes_User.TabIndex = 76;
            // 
            // labelPrivType_User
            // 
            labelPrivType_User.AutoSize = true;
            labelPrivType_User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrivType_User.ForeColor = Color.Teal;
            labelPrivType_User.Location = new Point(987, 401);
            labelPrivType_User.Margin = new Padding(4, 0, 4, 0);
            labelPrivType_User.Name = "labelPrivType_User";
            labelPrivType_User.Size = new Size(172, 45);
            labelPrivType_User.TabIndex = 75;
            labelPrivType_User.Text = "PRIV TYPE:";
            // 
            // comboBoxPrivs_User
            // 
            comboBoxPrivs_User.FormattingEnabled = true;
            comboBoxPrivs_User.Location = new Point(1320, 460);
            comboBoxPrivs_User.Margin = new Padding(4);
            comboBoxPrivs_User.Name = "comboBoxPrivs_User";
            comboBoxPrivs_User.Size = new Size(386, 53);
            comboBoxPrivs_User.TabIndex = 74;
            // 
            // comboBoxObjects_User
            // 
            comboBoxObjects_User.FormattingEnabled = true;
            comboBoxObjects_User.Location = new Point(987, 601);
            comboBoxObjects_User.Margin = new Padding(4);
            comboBoxObjects_User.Name = "comboBoxObjects_User";
            comboBoxObjects_User.Size = new Size(278, 53);
            comboBoxObjects_User.TabIndex = 73;
            // 
            // labelObject_User
            // 
            labelObject_User.AutoSize = true;
            labelObject_User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObject_User.ForeColor = Color.Teal;
            labelObject_User.Location = new Point(987, 539);
            labelObject_User.Margin = new Padding(4, 0, 4, 0);
            labelObject_User.Name = "labelObject_User";
            labelObject_User.Size = new Size(133, 45);
            labelObject_User.TabIndex = 72;
            labelObject_User.Text = "OBJECT:";
            // 
            // labelPriv_User
            // 
            labelPriv_User.AutoSize = true;
            labelPriv_User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPriv_User.ForeColor = Color.Teal;
            labelPriv_User.Location = new Point(1320, 401);
            labelPriv_User.Margin = new Padding(4, 0, 4, 0);
            labelPriv_User.Name = "labelPriv_User";
            labelPriv_User.Size = new Size(171, 45);
            labelPriv_User.TabIndex = 71;
            labelPriv_User.Text = "PRIVILEGE:";
            // 
            // comboBoxGrantRole
            // 
            comboBoxGrantRole.Enabled = false;
            comboBoxGrantRole.FormattingEnabled = true;
            comboBoxGrantRole.Location = new Point(986, 313);
            comboBoxGrantRole.Margin = new Padding(4);
            comboBoxGrantRole.Name = "comboBoxGrantRole";
            comboBoxGrantRole.Size = new Size(480, 53);
            comboBoxGrantRole.TabIndex = 70;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1894, 105);
            panel1.TabIndex = 83;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(745, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(451, 45);
            label1.TabIndex = 0;
            label1.Text = "ORACLE DATABASE MANAGER";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(781, 128);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(371, 45);
            label5.TabIndex = 84;
            label5.Text = "Grant Privileges To Users";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSearchUser_User2
            // 
            labelSearchUser_User2.AutoSize = true;
            labelSearchUser_User2.BackColor = Color.White;
            labelSearchUser_User2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearchUser_User2.ForeColor = Color.Teal;
            labelSearchUser_User2.Location = new Point(180, 401);
            labelSearchUser_User2.Name = "labelSearchUser_User2";
            labelSearchUser_User2.Size = new Size(226, 45);
            labelSearchUser_User2.TabIndex = 89;
            labelSearchUser_User2.Text = "SEARCH USER:";
            // 
            // listViewUsers_User2
            // 
            listViewUsers_User2.Location = new Point(181, 601);
            listViewUsers_User2.Name = "listViewUsers_User2";
            listViewUsers_User2.Size = new Size(574, 306);
            listViewUsers_User2.TabIndex = 88;
            listViewUsers_User2.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxUsers_User2
            // 
            comboBoxUsers_User2.FormattingEnabled = true;
            comboBoxUsers_User2.Location = new Point(181, 460);
            comboBoxUsers_User2.Name = "comboBoxUsers_User2";
            comboBoxUsers_User2.Size = new Size(574, 53);
            comboBoxUsers_User2.TabIndex = 87;
            // 
            // comboBoxRoles_User2
            // 
            comboBoxRoles_User2.FormattingEnabled = true;
            comboBoxRoles_User2.Location = new Point(181, 313);
            comboBoxRoles_User2.Name = "comboBoxRoles_User2";
            comboBoxRoles_User2.Size = new Size(575, 53);
            comboBoxRoles_User2.TabIndex = 86;
            // 
            // labelRoles_User2
            // 
            labelRoles_User2.AutoSize = true;
            labelRoles_User2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRoles_User2.ForeColor = Color.Teal;
            labelRoles_User2.Location = new Point(181, 254);
            labelRoles_User2.Name = "labelRoles_User2";
            labelRoles_User2.Size = new Size(118, 45);
            labelRoles_User2.TabIndex = 85;
            labelRoles_User2.Text = "ROLES:";
            // 
            // checkBoxGrantRole
            // 
            checkBoxGrantRole.AutoSize = true;
            checkBoxGrantRole.ForeColor = Color.Teal;
            checkBoxGrantRole.Location = new Point(987, 250);
            checkBoxGrantRole.Margin = new Padding(4);
            checkBoxGrantRole.Name = "checkBoxGrantRole";
            checkBoxGrantRole.Size = new Size(245, 49);
            checkBoxGrantRole.TabIndex = 91;
            checkBoxGrantRole.Text = "GRANT ROLE:";
            checkBoxGrantRole.UseVisualStyleBackColor = true;
            // 
            // GrantUser
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1894, 1009);
            Controls.Add(checkBoxGrantRole);
            Controls.Add(labelSearchUser_User2);
            Controls.Add(listViewUsers_User2);
            Controls.Add(comboBoxUsers_User2);
            Controls.Add(comboBoxRoles_User2);
            Controls.Add(labelRoles_User2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(buttonGrantPriv_User);
            Controls.Add(checkBoxWithGrant_User);
            Controls.Add(comboBoxColumns_User);
            Controls.Add(labelColumn_User);
            Controls.Add(comboBoxPrivTypes_User);
            Controls.Add(labelPrivType_User);
            Controls.Add(comboBoxPrivs_User);
            Controls.Add(comboBoxObjects_User);
            Controls.Add(labelObject_User);
            Controls.Add(labelPriv_User);
            Controls.Add(comboBoxGrantRole);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "GrantUser";
            Text = "GrantUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonGrantPriv_User;
        private CheckBox checkBoxWithGrant_User;
        private ComboBox comboBoxColumns_User;
        private Label labelColumn_User;
        private ComboBox comboBoxPrivTypes_User;
        private Label labelPrivType_User;
        private ComboBox comboBoxPrivs_User;
        private ComboBox comboBoxObjects_User;
        private Label labelObject_User;
        private Label labelPriv_User;
        private ComboBox comboBoxGrantRole;
        private Label labelGrantRole;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label labelSearchUser_User2;
        private ListView listViewUsers_User2;
        private ComboBox comboBoxUsers_User2;
        private ComboBox comboBoxRoles_User2;
        private Label labelRoles_User2;
        private CheckBox checkBoxGrantRole;
    }
}