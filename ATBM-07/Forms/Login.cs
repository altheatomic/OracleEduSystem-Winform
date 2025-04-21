using System;
using System.Windows.Forms;
using ATBM_07.Forms;
using ATBM_07.Helpers;
using ATBM_07.Services;

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
                string role = DatabaseHelper.GetCurrentRole();

                this.Hide();
          
                if (role == "PDB_DBA" || username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    new DashBoard_Admin().Show(); 
                    return;
                }

                switch (role)
                {
                    case "SV":
                        new DashBoard_SV().Show();
                        break;
                    case "GV":
                        new DashBoard_GV().Show();
                        break;
                    case "NVPDT":
                        new DashBoard_NVPDT().Show();
                        break;
                    case "TRGDV":
                        new DashBoard_TRGDV().Show();
                        break;
                    case "NVCB":
                        new DashBoard_NVCB__().Show();
                        break;
                    case "NVCTSV":
                        new DashBoard_NVCTSV().Show();
                        break;
                    case "NVPKT":
                        new DashBoard_NVPTK().Show();
                        break;
                    case "NVTCHC":
                        new DashBoard_NVTCHC().Show();
                        break;
                    default:
                        MessageBox.Show("No roles.");
                        this.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Connection failed. Please try again.");
            }
        }
    }
}
