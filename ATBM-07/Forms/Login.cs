using System;
using System.Windows.Forms;
using ATBM_07.Forms;
using ATBM_07.Helpers;

namespace ATBM_07
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (DatabaseHelper.Connect(username, password))
            {
                string role = DatabaseHelper.GetRoleFromVaitroFunction(); // GỌI SP MỚI

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Không xác định được vai trò.");
                    return;
                }

                this.Hide();

                switch (role)
                {
                    case "SV":
                        new DashBoard_SV().Show(); break;
                    case "GV":
                        new DashBoard_GV().Show(); break;
                    case "NVCB":
                        new DashBoard_NVCB().Show(); break;
                    case "NVPDT":
                        new DashBoard_NVPDT().Show(); break;
                    case "NVPKT":
                        new DashBoard_NVPTK().Show(); break;
                    case "NVCTSV":
                        new DashBoard_NVCTSV().Show(); break;
                    case "TRGDV":
                        new DashBoard_TRGDV().Show(); break;
                    case "NVTCHC":
                        new DashBoard_NVTCHC().Show(); break;
                    case "ADMIN":
                        new DashBoard_Admin().Show(); break;
                    default:
                        MessageBox.Show("Vai trò không hợp lệ: " + role);
                        this.Show(); break;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
    }
}
