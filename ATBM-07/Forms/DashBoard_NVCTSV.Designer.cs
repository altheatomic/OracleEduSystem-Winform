namespace ATBM_07.Forms
{
    partial class DashBoard_NVCTSV
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
            dataGridViewSinhVien = new DataGridView();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonInsert = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).BeginInit();
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
            panel1.TabIndex = 2;
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
            // dataGridViewSinhVien
            // 
            dataGridViewSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinhVien.Location = new Point(86, 174);
            dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            dataGridViewSinhVien.RowHeadersWidth = 82;
            dataGridViewSinhVien.Size = new Size(1294, 637);
            dataGridViewSinhVien.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.AutoSize = true;
            buttonSave.FlatAppearance.BorderColor = Color.Teal;
            buttonSave.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            buttonSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.Teal;
            buttonSave.Location = new Point(1474, 307);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 57);
            buttonSave.TabIndex = 93;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSize = true;
            buttonDelete.FlatAppearance.BorderColor = Color.Teal;
            buttonDelete.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            buttonDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.Teal;
            buttonDelete.Location = new Point(1474, 415);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 57);
            buttonDelete.TabIndex = 94;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            buttonInsert.AutoSize = true;
            buttonInsert.FlatAppearance.BorderColor = Color.Teal;
            buttonInsert.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            buttonInsert.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            buttonInsert.FlatStyle = FlatStyle.Flat;
            buttonInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInsert.ForeColor = Color.Teal;
            buttonInsert.Location = new Point(1474, 522);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(150, 57);
            buttonInsert.TabIndex = 95;
            buttonInsert.Text = "INSERT";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // DashBoard_NVCTSV
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1894, 1009);
            Controls.Add(buttonInsert);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewSinhVien);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DashBoard_NVCTSV";
            Text = "DashBoard_NVCTSV";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewSinhVien;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonInsert;
    }
}