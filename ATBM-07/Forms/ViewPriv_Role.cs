using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_07.Forms
{
    public partial class ViewPriv_Role : Form
    {
        private string roleName;

        public ViewPriv_Role(string role)
        {
            InitializeComponent();
            roleName = role;
            Text = $"Privileges for role: {roleName}";
            label1.Text = $"Privileges for role: {roleName}";
            // TODO: Load privileges for this role
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
