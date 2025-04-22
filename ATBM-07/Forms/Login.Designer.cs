namespace ATBM_07
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 1080);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(797, 56);
            label1.Name = "label1";
            label1.Size = new Size(456, 43);
            label1.TabIndex = 1;
            label1.Text = "ORACLE DATABASE MANAGER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(912, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(815, 433);
            label2.Name = "label2";
            label2.Size = new Size(163, 45);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(815, 494);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 50);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(815, 637);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 50);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(815, 576);
            label3.Name = "label3";
            label3.Size = new Size(153, 45);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.FlatAppearance.BorderColor = Color.Teal;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Teal;
            btnLogin.Location = new Point(934, 775);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 57);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
    }
}
