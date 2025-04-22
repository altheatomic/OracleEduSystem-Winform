namespace ATBM_07
{
    partial class GrantRole
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
            buttonViewPriv = new Button();
            buttonRevokePriv = new Button();
            buttonGrantPriv = new Button();
            listViewRoles_Role2 = new ListView();
            comboBoxRoles_Role2 = new ComboBox();
            labelSearchRole_Role2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label9 = new Label();
            buttonRevoke_Role = new Button();
            buttonGrantPriv_Role = new Button();
            comboBoxColumns_Role = new ComboBox();
            labelColumn_Role = new Label();
            comboBoxPrivTypes_Role = new ComboBox();
            labelPrivType_Role = new Label();
            comboBoxPrivs_Role = new ComboBox();
            comboBoxObjects_Role = new ComboBox();
            labelObject_Role = new Label();
            labelPriv_Role = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonViewPriv
            // 
            buttonViewPriv.AutoSize = true;
            buttonViewPriv.BackColor = Color.Teal;
            buttonViewPriv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewPriv.ForeColor = Color.White;
            buttonViewPriv.Location = new Point(1108, 1287);
            buttonViewPriv.Margin = new Padding(4);
            buttonViewPriv.Name = "buttonViewPriv";
            buttonViewPriv.Size = new Size(321, 91);
            buttonViewPriv.TabIndex = 55;
            buttonViewPriv.Text = "VIEW PRIV";
            buttonViewPriv.UseVisualStyleBackColor = false;
            // 
            // buttonRevokePriv
            // 
            buttonRevokePriv.AutoSize = true;
            buttonRevokePriv.BackColor = Color.Teal;
            buttonRevokePriv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRevokePriv.ForeColor = Color.White;
            buttonRevokePriv.Location = new Point(720, 1287);
            buttonRevokePriv.Margin = new Padding(4);
            buttonRevokePriv.Name = "buttonRevokePriv";
            buttonRevokePriv.Size = new Size(321, 91);
            buttonRevokePriv.TabIndex = 54;
            buttonRevokePriv.Text = "REVOKE PRIV";
            buttonRevokePriv.UseVisualStyleBackColor = false;
            // 
            // buttonGrantPriv
            // 
            buttonGrantPriv.AutoSize = true;
            buttonGrantPriv.BackColor = Color.Teal;
            buttonGrantPriv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGrantPriv.ForeColor = Color.White;
            buttonGrantPriv.Location = new Point(346, 1287);
            buttonGrantPriv.Margin = new Padding(4);
            buttonGrantPriv.Name = "buttonGrantPriv";
            buttonGrantPriv.Size = new Size(312, 91);
            buttonGrantPriv.TabIndex = 53;
            buttonGrantPriv.Text = "GRANT PRIV";
            buttonGrantPriv.UseVisualStyleBackColor = false;
            // 
            // listViewRoles_Role2
            // 
            listViewRoles_Role2.Location = new Point(196, 442);
            listViewRoles_Role2.Margin = new Padding(4);
            listViewRoles_Role2.Name = "listViewRoles_Role2";
            listViewRoles_Role2.Size = new Size(574, 368);
            listViewRoles_Role2.TabIndex = 47;
            listViewRoles_Role2.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxRoles_Role2
            // 
            comboBoxRoles_Role2.FormattingEnabled = true;
            comboBoxRoles_Role2.Location = new Point(196, 363);
            comboBoxRoles_Role2.Margin = new Padding(4);
            comboBoxRoles_Role2.Name = "comboBoxRoles_Role2";
            comboBoxRoles_Role2.Size = new Size(574, 53);
            comboBoxRoles_Role2.TabIndex = 46;
            // 
            // labelSearchRole_Role2
            // 
            labelSearchRole_Role2.AutoSize = true;
            labelSearchRole_Role2.BackColor = Color.White;
            labelSearchRole_Role2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearchRole_Role2.ForeColor = Color.Teal;
            labelSearchRole_Role2.Location = new Point(196, 304);
            labelSearchRole_Role2.Margin = new Padding(4, 0, 4, 0);
            labelSearchRole_Role2.Name = "labelSearchRole_Role2";
            labelSearchRole_Role2.Size = new Size(226, 45);
            labelSearchRole_Role2.TabIndex = 48;
            labelSearchRole_Role2.Text = "SEARCH ROLE:";
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
            panel1.TabIndex = 84;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(786, 125);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(369, 45);
            label9.TabIndex = 85;
            label9.Text = "Grant Privileges To Roles";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRevoke_Role
            // 
            buttonRevoke_Role.AutoSize = true;
            buttonRevoke_Role.BackColor = Color.Teal;
            buttonRevoke_Role.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRevoke_Role.ForeColor = Color.White;
            buttonRevoke_Role.Location = new Point(1373, 719);
            buttonRevoke_Role.Margin = new Padding(4);
            buttonRevoke_Role.Name = "buttonRevoke_Role";
            buttonRevoke_Role.Size = new Size(321, 91);
            buttonRevoke_Role.TabIndex = 98;
            buttonRevoke_Role.Text = "REVOKE PRIV";
            buttonRevoke_Role.UseVisualStyleBackColor = false;
            // 
            // buttonGrantPriv_Role
            // 
            buttonGrantPriv_Role.AutoSize = true;
            buttonGrantPriv_Role.BackColor = Color.Teal;
            buttonGrantPriv_Role.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGrantPriv_Role.ForeColor = Color.White;
            buttonGrantPriv_Role.Location = new Point(974, 719);
            buttonGrantPriv_Role.Margin = new Padding(4);
            buttonGrantPriv_Role.Name = "buttonGrantPriv_Role";
            buttonGrantPriv_Role.Size = new Size(312, 91);
            buttonGrantPriv_Role.TabIndex = 97;
            buttonGrantPriv_Role.Text = "GRANT PRIV";
            buttonGrantPriv_Role.UseVisualStyleBackColor = false;
            buttonGrantPriv_Role.Click += buttonGrantPriv_Role_Click;
            // 
            // comboBoxColumns_Role
            // 
            comboBoxColumns_Role.FormattingEnabled = true;
            comboBoxColumns_Role.Location = new Point(1308, 504);
            comboBoxColumns_Role.Margin = new Padding(4);
            comboBoxColumns_Role.Name = "comboBoxColumns_Role";
            comboBoxColumns_Role.Size = new Size(386, 53);
            comboBoxColumns_Role.TabIndex = 95;
            // 
            // labelColumn_Role
            // 
            labelColumn_Role.AutoSize = true;
            labelColumn_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelColumn_Role.ForeColor = Color.Teal;
            labelColumn_Role.Location = new Point(1308, 442);
            labelColumn_Role.Margin = new Padding(4, 0, 4, 0);
            labelColumn_Role.Name = "labelColumn_Role";
            labelColumn_Role.Size = new Size(159, 45);
            labelColumn_Role.TabIndex = 94;
            labelColumn_Role.Text = "COLUMN:";
            // 
            // comboBoxPrivTypes_Role
            // 
            comboBoxPrivTypes_Role.FormattingEnabled = true;
            comboBoxPrivTypes_Role.Location = new Point(975, 363);
            comboBoxPrivTypes_Role.Margin = new Padding(4);
            comboBoxPrivTypes_Role.Name = "comboBoxPrivTypes_Role";
            comboBoxPrivTypes_Role.Size = new Size(190, 53);
            comboBoxPrivTypes_Role.TabIndex = 93;
            // 
            // labelPrivType_Role
            // 
            labelPrivType_Role.AutoSize = true;
            labelPrivType_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrivType_Role.ForeColor = Color.Teal;
            labelPrivType_Role.Location = new Point(975, 304);
            labelPrivType_Role.Margin = new Padding(4, 0, 4, 0);
            labelPrivType_Role.Name = "labelPrivType_Role";
            labelPrivType_Role.Size = new Size(172, 45);
            labelPrivType_Role.TabIndex = 92;
            labelPrivType_Role.Text = "PRIV TYPE:";
            // 
            // comboBoxPrivs_Role
            // 
            comboBoxPrivs_Role.FormattingEnabled = true;
            comboBoxPrivs_Role.Location = new Point(1308, 363);
            comboBoxPrivs_Role.Margin = new Padding(4);
            comboBoxPrivs_Role.Name = "comboBoxPrivs_Role";
            comboBoxPrivs_Role.Size = new Size(386, 53);
            comboBoxPrivs_Role.TabIndex = 91;
            // 
            // comboBoxObjects_Role
            // 
            comboBoxObjects_Role.FormattingEnabled = true;
            comboBoxObjects_Role.Location = new Point(975, 504);
            comboBoxObjects_Role.Margin = new Padding(4);
            comboBoxObjects_Role.Name = "comboBoxObjects_Role";
            comboBoxObjects_Role.Size = new Size(278, 53);
            comboBoxObjects_Role.TabIndex = 90;
            // 
            // labelObject_Role
            // 
            labelObject_Role.AutoSize = true;
            labelObject_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelObject_Role.ForeColor = Color.Teal;
            labelObject_Role.Location = new Point(975, 442);
            labelObject_Role.Margin = new Padding(4, 0, 4, 0);
            labelObject_Role.Name = "labelObject_Role";
            labelObject_Role.Size = new Size(133, 45);
            labelObject_Role.TabIndex = 89;
            labelObject_Role.Text = "OBJECT:";
            // 
            // labelPriv_Role
            // 
            labelPriv_Role.AutoSize = true;
            labelPriv_Role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPriv_Role.ForeColor = Color.Teal;
            labelPriv_Role.Location = new Point(1308, 304);
            labelPriv_Role.Margin = new Padding(4, 0, 4, 0);
            labelPriv_Role.Name = "labelPriv_Role";
            labelPriv_Role.Size = new Size(171, 45);
            labelPriv_Role.TabIndex = 88;
            labelPriv_Role.Text = "PRIVILEGE:";
            // 
            // GrantRole
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1894, 1009);
            Controls.Add(buttonRevoke_Role);
            Controls.Add(buttonGrantPriv_Role);
            Controls.Add(comboBoxColumns_Role);
            Controls.Add(labelColumn_Role);
            Controls.Add(comboBoxPrivTypes_Role);
            Controls.Add(labelPrivType_Role);
            Controls.Add(comboBoxPrivs_Role);
            Controls.Add(comboBoxObjects_Role);
            Controls.Add(labelObject_Role);
            Controls.Add(labelPriv_Role);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(buttonViewPriv);
            Controls.Add(buttonRevokePriv);
            Controls.Add(buttonGrantPriv);
            Controls.Add(listViewRoles_Role2);
            Controls.Add(comboBoxRoles_Role2);
            Controls.Add(labelSearchRole_Role2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "GrantRole";
            Text = "GrantRole";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonViewPriv;
        private Button buttonRevokePriv;
        private Button buttonGrantPriv;
        private ListView listViewRoles_Role2;
        private ComboBox comboBoxRoles_Role2;
        private Label labelSearchRole_Role2;
        private Panel panel1;
        private Label label1;
        private Label label9;
        private Button buttonRevoke_Role;
        private Button buttonGrantPriv_Role;
        private CheckBox checkBoxWithGrant_Role;
        private ComboBox comboBoxColumns_Role;
        private Label labelColumn_Role;
        private ComboBox comboBoxPrivTypes_Role;
        private Label labelPrivType_Role;
        private ComboBox comboBoxPrivs_Role;
        private ComboBox comboBoxObjects_Role;
        private Label labelObject_Role;
        private Label labelPriv_Role;
    }
}