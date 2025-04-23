namespace ATBM_07.Forms
{
    partial class DashBoard_NVPKT
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
            dataGridViewGrades = new DataGridView();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).BeginInit();
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
            panel1.TabIndex = 1;
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
            // dataGridViewGrades
            // 
            dataGridViewGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrades.Location = new Point(147, 213);
            dataGridViewGrades.Name = "dataGridViewGrades";
            dataGridViewGrades.RowHeadersWidth = 82;
            dataGridViewGrades.Size = new Size(1294, 637);
            dataGridViewGrades.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.FlatAppearance.BorderColor = Color.Teal;
            btnSave.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Teal;
            btnSave.Location = new Point(1597, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 57);
            btnSave.TabIndex = 92;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // DashBoard_NVPKT
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1894, 1009);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewGrades);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DashBoard_NVPKT";
            Text = "DashBoard_NVPKT";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewGrades;
        private Button btnSave;
    }
}