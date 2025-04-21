using System;
using System.Windows.Forms;

namespace ATBM_07.Forms
{
    public partial class DashBoard_Admin : Form
    {
        public DashBoard_Admin()
        {
            InitializeComponent();
          
        }

        private void DashBoard_Admin_Load(object sender, EventArgs e)
        {
            btnUsers.Click += (s, ev) => { new User().Show(); };
            btnGrantToUser.Click += (s, ev) => { new GrantUser().Show(); };
            btnRoles.Click += (s, ev) => { new Role().Show(); };
            btnGrantToRole.Click += (s, ev) => { new GrantRole().Show(); };
        }
    }
}
