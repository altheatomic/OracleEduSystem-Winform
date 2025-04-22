namespace ATBM_07
{
    partial class Role
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
            buttonDelete_Role = new Button();
            labelSearchRole_Role1 = new Label();
            listViewRoles_Role1 = new ListView();
            comboBoxRoles_Role1 = new ComboBox();
            buttonViewPriv_Role = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBoxNewRole = new TextBox();
            labelNewRole = new Label();
            buttonCreateRole = new Button();
            listViewPrivs_Role = new ListView();
            buttonRevoke_Role = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDelete_Role
            // 
            buttonDelete_Role.AutoSize = true;
            buttonDelete_Role.BackColor = Color.Teal;
            buttonDelete_Role.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete_Role.ForeColor = Color.White;
            buttonDelete_Role.Location = new Point(952, 485);
            buttonDelete_Role.Name = "buttonDelete_Role";
            buttonDelete_Role.Size = new Size(232, 65);
            buttonDelete_Role.TabIndex = 24;
            buttonDelete_Role.Text = "DELETE";
            buttonDelete_Role.UseVisualStyleBackColor = false;
            // 
            // labelSearchRole_Role1
            // 
            labelSearchRole_Role1.AutoSize = true;
            labelSearchRole_Role1.BackColor = Color.White;
            labelSearchRole_Role1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearchRole_Role1.ForeColor = Color.Teal;
            labelSearchRole_Role1.Location = new Point(183, 303);
            labelSearchRole_Role1.Name = "labelSearchRole_Role1";
            labelSearchRole_Role1.Size = new Size(226, 45);
            labelSearchRole_Role1.TabIndex = 23;
            labelSearchRole_Role1.Text = "SEARCH ROLE:";
            // 
            // listViewRoles_Role1
            // 
            listViewRoles_Role1.Location = new Point(183, 463);
            listViewRoles_Role1.Name = "listViewRoles_Role1";
            listViewRoles_Role1.Size = new Size(574, 449);
            listViewRoles_Role1.TabIndex = 22;
            listViewRoles_Role1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxRoles_Role1
            // 
            comboBoxRoles_Role1.FormattingEnabled = true;
            comboBoxRoles_Role1.Location = new Point(183, 374);
            comboBoxRoles_Role1.Name = "comboBoxRoles_Role1";
            comboBoxRoles_Role1.Size = new Size(575, 53);
            comboBoxRoles_Role1.TabIndex = 20;
            // 
            // buttonViewPriv_Role
            // 
            buttonViewPriv_Role.AutoSize = true;
            buttonViewPriv_Role.BackColor = Color.Teal;
            buttonViewPriv_Role.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewPriv_Role.ForeColor = Color.White;
            buttonViewPriv_Role.Location = new Point(1223, 485);
            buttonViewPriv_Role.Name = "buttonViewPriv_Role";
            buttonViewPriv_Role.Size = new Size(232, 65);
            buttonViewPriv_Role.TabIndex = 32;
            buttonViewPriv_Role.Text = "VIEW PRIV";
            buttonViewPriv_Role.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1894, 75);
            panel1.TabIndex = 44;
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
            label2.Size = new Size(220, 45);
            label2.TabIndex = 2;
            label2.Text = "Manage Roles";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxNewRole
            // 
            textBoxNewRole.Location = new Point(952, 374);
            textBoxNewRole.Name = "textBoxNewRole";
            textBoxNewRole.Size = new Size(296, 50);
            textBoxNewRole.TabIndex = 25;
            // 
            // labelNewRole
            // 
            labelNewRole.AutoSize = true;
            labelNewRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewRole.ForeColor = Color.Teal;
            labelNewRole.Location = new Point(952, 303);
            labelNewRole.Name = "labelNewRole";
            labelNewRole.Size = new Size(180, 45);
            labelNewRole.TabIndex = 26;
            labelNewRole.Text = "NEW ROLE:";
            // 
            // buttonCreateRole
            // 
            buttonCreateRole.AutoSize = true;
            buttonCreateRole.BackColor = Color.Teal;
            buttonCreateRole.Enabled = false;
            buttonCreateRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateRole.ForeColor = Color.White;
            buttonCreateRole.Location = new Point(1386, 367);
            buttonCreateRole.Name = "buttonCreateRole";
            buttonCreateRole.Size = new Size(232, 64);
            buttonCreateRole.TabIndex = 29;
            buttonCreateRole.Text = "CREATE ROLE";
            buttonCreateRole.UseVisualStyleBackColor = false;
            // 
            // listViewPrivs_Role
            // 
            listViewPrivs_Role.Location = new Point(952, 595);
            listViewPrivs_Role.Name = "listViewPrivs_Role";
            listViewPrivs_Role.Size = new Size(767, 317);
            listViewPrivs_Role.TabIndex = 45;
            listViewPrivs_Role.UseCompatibleStateImageBehavior = false;
            // 
            // buttonRevoke_Role
            // 
            buttonRevoke_Role.AutoSize = true;
            buttonRevoke_Role.BackColor = Color.Teal;
            buttonRevoke_Role.Enabled = false;
            buttonRevoke_Role.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRevoke_Role.ForeColor = Color.White;
            buttonRevoke_Role.Location = new Point(1487, 485);
            buttonRevoke_Role.Margin = new Padding(4);
            buttonRevoke_Role.Name = "buttonRevoke_Role";
            buttonRevoke_Role.Size = new Size(232, 65);
            buttonRevoke_Role.TabIndex = 99;
            buttonRevoke_Role.Text = "REVOKE PRIV";
            buttonRevoke_Role.UseVisualStyleBackColor = false;
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1894, 1009);
            Controls.Add(buttonRevoke_Role);
            Controls.Add(listViewPrivs_Role);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(buttonViewPriv_Role);
            Controls.Add(listViewRoles_Role1);
            Controls.Add(buttonCreateRole);
            Controls.Add(comboBoxRoles_Role1);
            Controls.Add(labelNewRole);
            Controls.Add(labelSearchRole_Role1);
            Controls.Add(textBoxNewRole);
            Controls.Add(buttonDelete_Role);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Role";
            Text = "Role";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDelete_Role;
        private Label labelSearchRole_Role1;
        private ListView listViewRoles_Role1;
        private ComboBox comboBoxRoles_Role1;
        private Button buttonViewPriv_Role;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBoxNewRole;
        private Label labelNewRole;
        private Button buttonCreateRole;
        private ListView listViewPrivs_Role;
        private Button buttonRevoke_Role;
    }
}