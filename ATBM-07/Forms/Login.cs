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
                string role = DatabaseHelper.GetRole(username);

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Can't get role.");
                    return;
                }

                this.Hide();

                switch (role)
                {
                    case "PDB_DBA":
                        new DashBoard_Admin().Show(); break;
                    case "SV":
                        new DashBoard_SV().Show(); break;
                    case "GV":
                        new DashBoard_GV().Show(); break;
                    case "NVCB":
                        new DashBoard_NVCB().Show(); break;
                    case "NVPDT":
                        new DashBoard_NVPDT().Show(); break;
                    case "NVPKT":
                        new DashBoard_NVPKT().Show(); break;
                    case "NVCTSV":
                        new DashBoard_NVCTSV().Show(); break;
                    case "TRGDV":
                        new DashBoard_TRGDV().Show(); break;
                    case "NVTCHC":
                        new DashBoard_NVTCHC().Show(); break;
                    default:
                        MessageBox.Show("Invalid role: " + role);
                        this.Show(); break;
                }
            }
            else
            {
                MessageBox.Show("Wrong information. Please try again.");
            }

        }
    }
}
