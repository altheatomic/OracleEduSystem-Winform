using ATBM_07.Forms;
using ATBM_07.Services;
using Oracle.ManagedDataAccess.Client;

namespace ATBM_07
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
            comboBoxRoles_Role1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxRoles_Role1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRoles_Role1.AutoCompleteSource = AutoCompleteSource.ListItems;

            LoadRoles();
            comboBoxRoles_Role1.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
            listViewRoles_Role1.ItemChecked += listViewRoles_Role1_ItemChecked;
            textBoxNewRole.TextChanged += textBoxNewRole_TextChanged;
            buttonCreateRole.Click += buttonCreateRole_Click;
        }

        private void LoadRoles()
        {
            try
            {
                listViewRoles_Role1.Columns.Clear();
                listViewRoles_Role1.Items.Clear();
                comboBoxRoles_Role1.Items.Clear();

                listViewRoles_Role1.View = View.Details;
                listViewRoles_Role1.FullRowSelect = true;
                listViewRoles_Role1.GridLines = true;
                listViewRoles_Role1.CheckBoxes = true;
                listViewRoles_Role1.Columns.Add("Role", 300);

                foreach (var role in RoleService.GetApplicationRoles())
                {
                    var item = new ListViewItem(role);
                    listViewRoles_Role1.Items.Add(item);
                    comboBoxRoles_Role1.Items.Add(role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oracle error:\n" + ex.Message);
            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBoxRoles_Role1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedRole)) return;

            foreach (ListViewItem item in listViewRoles_Role1.Items)
            {
                if (item.Text.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    break;
                }
            }
        }

        private void listViewRoles_Role1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int checkedCount = listViewRoles_Role1.CheckedItems.Count;

            buttonDelete_Role.Enabled = checkedCount >= 1;
            buttonViewPriv_Role.Enabled = checkedCount == 1;
        }

        private void textBoxNewRole_TextChanged(object sender, EventArgs e)
        {
            buttonCreateRole.Enabled = !string.IsNullOrWhiteSpace(textBoxNewRole.Text);
        }

        private void buttonViewPriv_Role_Click(object sender, EventArgs e)
        {
            if (listViewRoles_Role1.CheckedItems.Count != 1)
            {
                MessageBox.Show("Please select exactly one role to view privileges.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = listViewRoles_Role1.CheckedItems[0].Text;

        }

        private void buttonCreateRole_Click(object sender, EventArgs e)
        {
            string newRole = textBoxNewRole.Text.Trim();

            if (string.IsNullOrEmpty(newRole))
            {
                MessageBox.Show("Please enter a role name.");
                return;
            }

            try
            {
                if (RoleService.CheckRoleExists(newRole))
                {
                    MessageBox.Show($"Role '{newRole}' already exists.");
                    return;
                }

                RoleService.CreateRole(newRole);
                MessageBox.Show($"Created role '{newRole}'.");

                textBoxNewRole.Clear();
                buttonCreateRole.Enabled = false;
                LoadRoles(); // Reload the list of roles
            }
            catch (OracleException ex)
            {
                if (ex.Number == 20002) // Custom error code for existing role
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show("Oracle error:\n" + ex.Message);
            }
        }

    }
}