using ATBM_07.Forms;
using ATBM_07.Helpers;
using ATBM_07.Services;
using Oracle.ManagedDataAccess.Client;
using System.Data;

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
            buttonViewPriv_Role.Click += buttonViewPriv_Role_Click;
            buttonRevoke_Role.Click += buttonRevoke_Role_Click;
            listViewPrivs_Role.View = View.Details;
            listViewPrivs_Role.FullRowSelect = true;
            listViewPrivs_Role.GridLines = true;
            listViewPrivs_Role.Columns.Clear();
            listViewPrivs_Role.Columns.Add("Privilege Details", 500); 
            listViewPrivs_Role.SelectedIndexChanged += listViewPrivs_Role_SelectedIndexChanged;
            buttonDelete_Role.Click += buttonDelete_Role_Click;


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

                foreach (var role in RoleService.GetAllRoles())
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
                item.Checked = false;
            }

            foreach (ListViewItem item in listViewRoles_Role1.Items)
            {
                if (item.Text.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    item.Checked = true; 
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

            listViewPrivs_Role.Columns.Clear();
            listViewPrivs_Role.Items.Clear();
            listViewPrivs_Role.View = View.Details;
            listViewPrivs_Role.FullRowSelect = true;
            listViewPrivs_Role.GridLines = true;

            listViewPrivs_Role.Columns.Add("Privilege", 150);
            listViewPrivs_Role.Columns.Add("Object", 350);
            buttonRevoke_Role.Enabled = false;

            try
            {
                using (var cmd = new OracleCommand("get_privs_of_role", DatabaseHelper.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = selectedRole;
                    cmd.Parameters.Add("p_privs", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string raw = reader.GetString(0);

                            string privilege = raw;
                            string obj = "";

                            if (raw.Contains(" ON "))
                            {
                                var parts = raw.Split(new[] { " ON " }, StringSplitOptions.None);
                                privilege = parts[0];
                                obj = parts.Length > 1 ? parts[1] : "";
                            }

                            var item = new ListViewItem(privilege);
                            item.SubItems.Add(obj);
                            listViewPrivs_Role.Items.Add(item);
                        }

                        listViewPrivs_Role.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading privileges:\n" + ex.Message);
            }
        }

        private void listViewPrivs_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRevoke_Role.Enabled = listViewPrivs_Role.SelectedItems.Count == 1;
        }

        private void buttonRevoke_Role_Click(object sender, EventArgs e)
        {
            if (listViewPrivs_Role.SelectedItems.Count != 1 || listViewRoles_Role1.CheckedItems.Count != 1)
            {
                MessageBox.Show("Please select one role and one privilege to revoke.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPriv = listViewPrivs_Role.SelectedItems[0].SubItems[0].Text;
            string selectedObj = listViewPrivs_Role.SelectedItems[0].SubItems[1].Text;
            string selectedRole = listViewRoles_Role1.CheckedItems[0].Text;

            try
            {
                if (string.IsNullOrWhiteSpace(selectedObj))
                {
                    // System privilege
                    RoleService.RevokeSystemPrivilege(selectedRole, selectedPriv);
                }
                else
                {
                    // Object privilege
                    RoleService.RevokeObjectPrivilege(selectedRole, selectedPriv, selectedObj);
                }

                MessageBox.Show("Revoked successfully!");
                buttonViewPriv_Role_Click(null, null); // Refresh privileges
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error revoking:\n" + ex.Message);
            }
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

        private void buttonDelete_Role_Click(object sender, EventArgs e)
        {
            if (listViewRoles_Role1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one role to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete the selected role(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            foreach (ListViewItem item in listViewRoles_Role1.CheckedItems)
            {
                string roleToDelete = item.Text;

                try
                {
                    RoleService.DeleteRole(roleToDelete);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting role '{roleToDelete}':\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Role(s) deleted successfully.");
            LoadRoles(); // refresh list
        }

    }
}