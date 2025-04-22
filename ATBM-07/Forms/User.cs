using ATBM_07.Services; 

namespace ATBM_07
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();

            // ListView Setup
            listViewUsers_User1.View = View.Details;
            listViewUsers_User1.FullRowSelect = true;
            listViewUsers_User1.GridLines = true;
            listViewUsers_User1.CheckBoxes = true;
            listViewUsers_User1.Columns.Clear();
            listViewUsers_User1.Columns.Add("Username", 300);

            comboBoxRoles_User1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxRoles_User1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRoles_User1.AutoCompleteSource = AutoCompleteSource.ListItems;

            // ComboBox Roles Setup
            try
            {
                comboBoxRoles_User1.Items.Add("None");
                foreach (var role in RoleService.GetAllRoles())
                {
                    comboBoxRoles_User1.Items.Add(role);
                }

                comboBoxRoles_User1.SelectedIndex = 0;
                comboBoxRoles_User1.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load the role list:\n" + ex.Message);
            }

            // ComboBoxUsers Setup
            comboBoxUsers_User1.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            comboBoxUsers_User1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUsers_User1.AutoCompleteSource = AutoCompleteSource.ListItems;
            listViewUsers_User1.ItemChecked += listViewUsers_User1_ItemChecked;
            textBoxUsername.TextChanged += textBoxUsernameOrPassword_TextChanged;
            textBoxPassword.TextChanged += textBoxUsernameOrPassword_TextChanged;
            buttonCreateUser.Click += buttonCreateUser_Click;
            buttonViewPriv_User.Click += buttonViewPriv_User_Click;
            buttonRevoke_User.Click += buttonRevoke_User_Click;
            listViewPrivs_User.SelectedIndexChanged += listViewPrivs_User_SelectedIndexChanged;
            buttonRevokeRole.Click += buttonRevokeRole_Click;
            buttonDelete_User.Click += buttonDelete_User_Click;
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBoxRoles_User1.SelectedItem?.ToString() ?? "";
            listViewUsers_User1.Items.Clear();
            comboBoxUsers_User1.Items.Clear();

            try
            {
                List<string> users = selectedRole == "None"
                    ? UserService.GetUsersWithoutRoles()
                    : RoleService.GetUsersByRole(selectedRole);

                foreach (var username in users)
                {
                    var item = new ListViewItem(username);
                    listViewUsers_User1.Items.Add(item);
                    comboBoxUsers_User1.Items.Add(username);
                }

                if (comboBoxUsers_User1.Items.Count > 0)
                    comboBoxUsers_User1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oracle error:\n" + ex.Message);
            }

            listViewUsers_User1_ItemChecked(null, null);
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = comboBoxUsers_User1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUser)) return;

            foreach (ListViewItem item in listViewUsers_User1.Items)
            {
                if (item.Text == selectedUser)
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    break;
                }
            }
        }

        private void listViewUsers_User1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int checkedCount = listViewUsers_User1.CheckedItems.Count;

            buttonDelete_User.Enabled = checkedCount >= 1;
            buttonViewPriv_User.Enabled = checkedCount == 1;

            bool validRoleSelected = comboBoxRoles_User1.SelectedItem != null &&
                                     comboBoxRoles_User1.SelectedItem.ToString() != "None";

            buttonRevokeRole.Enabled = (checkedCount == 1) && validRoleSelected;
        }

        private void textBoxUsernameOrPassword_TextChanged(object sender, EventArgs e)
        {
            buttonCreateUser.Enabled =
                !string.IsNullOrWhiteSpace(textBoxUsername.Text) &&
                !string.IsNullOrWhiteSpace(textBoxPassword.Text);
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the boxes.");
                return;
            }

            try
            {
                if (UserService.CheckUserExists(username))
                {
                    MessageBox.Show($"User '{username}' already exists.");
                    return;
                }

                UserService.CreateUser(username, password);
                MessageBox.Show($"Created user '{username}'.");

                textBoxUsername.Clear();
                textBoxPassword.Clear();
                buttonCreateUser.Enabled = false;

                if (comboBoxRoles_User1.SelectedItem?.ToString() != "None")
                {
                    comboBoxRoles_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }

        private void buttonViewPriv_User_Click(object sender, EventArgs e)
        {
            if (listViewUsers_User1.CheckedItems.Count != 1)
            {
                MessageBox.Show("Please select exactly one user.");
                return;
            }

            string selectedUser = listViewUsers_User1.CheckedItems[0].Text;

            listViewPrivs_User.Columns.Clear();
            listViewPrivs_User.Items.Clear();
            listViewPrivs_User.View = View.Details;
            listViewPrivs_User.FullRowSelect = true;
            listViewPrivs_User.GridLines = true;

            listViewPrivs_User.Columns.Add("Privilege", 120);
            listViewPrivs_User.Columns.Add("Object", 200);
            listViewPrivs_User.Columns.Add("Column", 120);
            listViewPrivs_User.Columns.Add("With Grant Option", 150);

            try
            {
                var privs = UserService.GetPrivilegesOfUser(selectedUser);

                foreach (var row in privs)
                {
                    var item = new ListViewItem(row);
                    listViewPrivs_User.Items.Add(item);
                }

                listViewPrivs_User.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading privileges:\n" + ex.Message);
            }
        }

        private void buttonRevoke_User_Click(object sender, EventArgs e)
        {
            if (listViewUsers_User1.CheckedItems.Count != 1 || listViewPrivs_User.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select one user and one privilege to revoke.");
                return;
            }

            string username = listViewUsers_User1.CheckedItems[0].Text;
            var selectedItem = listViewPrivs_User.SelectedItems[0];

            string privilege = selectedItem.SubItems[0].Text;
            string table = selectedItem.SubItems[1].Text;
            string objectName = string.IsNullOrWhiteSpace(table) ? null : table;

            try
            {
                UserService.RevokePrivilegeFromUser(username, privilege, objectName);
                MessageBox.Show("Revoked successfully!");
                buttonViewPriv_User_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }

        private void buttonRevokeRole_Click(object sender, EventArgs e)
        {
            if (listViewUsers_User1.CheckedItems.Count != 1 || comboBoxRoles_User1.SelectedItem?.ToString() == "None")
            {
                MessageBox.Show("Please select one user and a specific role (not 'None') to revoke.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUser = listViewUsers_User1.CheckedItems[0].Text;
            string selectedRole = comboBoxRoles_User1.SelectedItem.ToString();

            try
            {
                UserService.RevokeRoleFromUser(selectedUser, selectedRole);
                MessageBox.Show($"Role '{selectedRole}' revoked from user '{selectedUser}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxRoles_SelectedIndexChanged(null, null); // Refresh list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error revoking role:\n" + ex.Message);
            }
        }

        private void listViewPrivs_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRevoke_User.Enabled = listViewPrivs_User.SelectedItems.Count == 1;
        }

        private void buttonDelete_User_Click(object sender, EventArgs e)
        {
            if (listViewUsers_User1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete selected users?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            foreach (ListViewItem item in listViewUsers_User1.CheckedItems)
            {
                string username = item.Text;

                try
                {
                    UserService.DropUser(username);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user '{username}':\n" + ex.Message);
                }
            }

            MessageBox.Show("User(s) deleted successfully!");
            comboBoxRoles_SelectedIndexChanged(null, null); // reload user list
        }
    }
}