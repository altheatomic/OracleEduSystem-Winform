using System.Data;
using ATBM_07.Services;

namespace ATBM_07
{
    public partial class GrantUser : Form
    {
        public GrantUser()
        {
            InitializeComponent();
            InitializeListViewUsers();
            LoadRolesToComboBox();
            SetupComboBoxUsers();

            comboBoxRoles_User2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxRoles_User2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRoles_User2.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxPrivTypes_User.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxPrivTypes_User.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPrivTypes_User.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxPrivTypes_User.Items.AddRange(new string[] { "System", "Object" });
            comboBoxPrivTypes_User.SelectedIndexChanged += comboBoxPrivTypes_User_SelectedIndexChanged;

            comboBoxPrivs_User.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxPrivs_User.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPrivs_User.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxPrivs_User.SelectedIndexChanged += comboBoxPrivs_User_SelectedIndexChanged;

            comboBoxObjects_User.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxObjects_User.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxObjects_User.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxObjects_User.SelectedIndexChanged += comboBoxObjects_User_SelectedIndexChanged;

            comboBoxColumns_User.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxColumns_User.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxColumns_User.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxColumns_User.Enabled = false;

            checkBoxWithGrant_User.Enabled = false;
            checkBoxWithGrant_User.Checked = false;

            comboBoxGrantRole.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxGrantRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxGrantRole.AutoCompleteSource = AutoCompleteSource.ListItems;

            checkBoxGrantRole.CheckedChanged += checkBoxGrantRole_CheckedChanged;
            comboBoxGrantRole.SelectedIndexChanged += comboBoxGrantRole_SelectedIndexChanged;

            listViewUsers_User2.ItemCheck += listViewUsers_User2_ItemCheck;

        }

        private void InitializeListViewUsers()
        {
            listViewUsers_User2.View = View.Details;
            listViewUsers_User2.FullRowSelect = true;
            listViewUsers_User2.GridLines = true;
            listViewUsers_User2.CheckBoxes = true;
            listViewUsers_User2.Columns.Clear();
            listViewUsers_User2.Columns.Add("Username", 300);
        }

        private void LoadRolesToComboBox()
        {
            try
            {
                comboBoxRoles_User2.Items.Clear();

                comboBoxRoles_User2.Items.Add("None");
                foreach (var role in RoleService.GetAllRoles())
                {
                    comboBoxRoles_User2.Items.Add(role);
                }

                comboBoxRoles_User2.SelectedIndex = 0;
                comboBoxRoles_User2.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load the role list:\n" + ex.Message);
            }
        }

        private void SetupComboBoxUsers()
        {
            comboBoxUsers_User2.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            comboBoxUsers_User2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUsers_User2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBoxRoles_User2.SelectedItem?.ToString() ?? "";
            listViewUsers_User2.Items.Clear();
            comboBoxUsers_User2.Items.Clear();

            // Reset các combobox và checkbox
            comboBoxGrantRole.SelectedIndex = -1;
            comboBoxGrantRole.Text = "";
            comboBoxPrivTypes_User.SelectedIndex = -1;
            comboBoxPrivTypes_User.Text = "";
            comboBoxPrivs_User.Items.Clear();
            comboBoxPrivs_User.Text = "";
            comboBoxObjects_User.Items.Clear();
            comboBoxObjects_User.Text = "";
            comboBoxColumns_User.Items.Clear();
            comboBoxColumns_User.Text = "";
            comboBoxColumns_User.Enabled = false;
            checkBoxWithGrant_User.Checked = false;
            checkBoxWithGrant_User.Enabled = false;

            try
            {
                List<string> users;

                if (selectedRole == "None")
                {
                    // Lấy danh sách user chưa được gán role nào
                    users = UserService.GetUsersWithoutRoles();
                }
                else
                {
                    // Lấy danh sách user đang có role được chọn
                    users = RoleService.GetUsersByRole(selectedRole);
                }

                foreach (var username in users)
                {
                    var item = new ListViewItem(username);
                    listViewUsers_User2.Items.Add(item);
                    comboBoxUsers_User2.Items.Add(username);
                }

                if (comboBoxUsers_User2.Items.Count > 0)
                    comboBoxUsers_User2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oracle error:\n" + ex.Message);
            }
        }


        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = comboBoxUsers_User2.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUser)) return;

            foreach (ListViewItem item in listViewUsers_User2.Items)
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

        private bool suppressPrivTypeChange_User = false;
        private void comboBoxPrivTypes_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressPrivTypeChange_User) return;

            bool hasCheckedUser = listViewUsers_User2.Items.Cast<ListViewItem>().Any(item => item.Checked);

            if (!hasCheckedUser)
            {
                suppressPrivTypeChange_User = true;
                comboBoxPrivTypes_User.SelectedIndex = -1;
                suppressPrivTypeChange_User = false;
                MessageBox.Show("Please choose a user before choosing Priv Type!", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comboBoxPrivs_User.Items.Clear();
            comboBoxPrivs_User.Text = "";
            comboBoxObjects_User.Items.Clear();
            comboBoxObjects_User.Text = "";
            comboBoxColumns_User.Items.Clear();
            comboBoxColumns_User.Text = "";
            comboBoxColumns_User.Enabled = false;

            string selectedType = comboBoxPrivTypes_User.SelectedItem?.ToString();
            if (selectedType == "System")
            {
                var systemPrivs = PrivilegeService.GetSystemPrivileges();
                comboBoxPrivs_User.Items.AddRange(systemPrivs.ToArray());

                checkBoxWithGrant_User.Enabled = false;
                checkBoxWithGrant_User.Checked = false;
            }
            else if (selectedType == "Object")
            {
                var objectPrivs = PrivilegeService.GetObjectPrivileges();
                comboBoxPrivs_User.Items.AddRange(objectPrivs.ToArray());

                checkBoxWithGrant_User.Enabled = true;
            }

            if (comboBoxPrivs_User.Items.Count > 0)
                comboBoxPrivs_User.SelectedIndex = 0;
        }

        private void comboBoxPrivs_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxObjects_User.Items.Clear();
            comboBoxObjects_User.Text = "";
            comboBoxColumns_User.Items.Clear();
            comboBoxColumns_User.Text = "";

            string selectedPriv = comboBoxPrivs_User.SelectedItem?.ToString()?.ToUpper() ?? "";
            if (selectedPriv == "SELECT" || selectedPriv == "UPDATE" || selectedPriv == "REFERENCES")
            {
                comboBoxColumns_User.Enabled = true;
            }
            else
            {
                comboBoxColumns_User.Enabled = false;
            }

            var compatibleObjects = ObjectService.GetCompatibleObjects(selectedPriv);
            comboBoxObjects_User.Items.AddRange(compatibleObjects.ToArray());

            if (comboBoxObjects_User.Items.Count > 0)
                comboBoxObjects_User.SelectedIndex = 0;
        }

        private void comboBoxObjects_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedObject = comboBoxObjects_User.SelectedItem?.ToString() ?? "";
            string selectedPriv = comboBoxPrivs_User.SelectedItem?.ToString()?.ToUpper() ?? "";

            comboBoxColumns_User.Items.Clear();
            comboBoxColumns_User.Text = "";

            if (string.IsNullOrEmpty(selectedObject) || string.IsNullOrEmpty(selectedPriv))
                return;

            if ((selectedPriv == "SELECT" || selectedPriv == "UPDATE") &&
                ObjectService.GetTables().Contains(selectedObject.ToUpper()))
            {
                try
                {
                    var columns = ObjectService.GetTableColumns(selectedObject.ToUpper());
                    comboBoxColumns_User.Items.AddRange(columns.ToArray());

                    if (comboBoxColumns_User.Items.Count > 0)
                        comboBoxColumns_User.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't load the column list:\n" + ex.Message);
                }
            }
        }

        private void checkBoxGrantRole_CheckedChanged(object sender, EventArgs e)
        {
            bool isGrantRoleMode = checkBoxGrantRole.Checked;

            comboBoxPrivTypes_User.Enabled = !isGrantRoleMode;
            comboBoxPrivs_User.Enabled = !isGrantRoleMode;
            comboBoxObjects_User.Enabled = !isGrantRoleMode;
            comboBoxColumns_User.Enabled = !isGrantRoleMode;
            checkBoxWithGrant_User.Enabled = !isGrantRoleMode;

            comboBoxGrantRole.Enabled = isGrantRoleMode;

            // Grant role mode
            if (isGrantRoleMode)
            {
                comboBoxGrantRole.Items.Clear();
                try
                {
                    foreach (var role in RoleService.GetApplicationRoles())
                    {
                        comboBoxGrantRole.Items.Add(role);
                    }

                    if (comboBoxGrantRole.Items.Count > 0)
                        comboBoxGrantRole.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't load the role list for granting:\n" + ex.Message);
                }
            }
            else
            {
                // Reset when it's not in grant role mode
                comboBoxGrantRole.Items.Clear();
                comboBoxGrantRole.Text = "";
            }
        }


        private bool suppressGrantRoleChange = false;
        private void comboBoxGrantRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressGrantRoleChange) return;

            bool hasCheckedUser = listViewUsers_User2.Items.Cast<ListViewItem>().Any(item => item.Checked);

            if (!hasCheckedUser)
            {
                suppressGrantRoleChange = true;
                comboBoxGrantRole.SelectedIndex = -1;
                suppressGrantRoleChange = false;

                MessageBox.Show("Please choose at least one user before assigning a Role!", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listViewUsers_User2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Delay to make sure the newest Checked status is updated
            this.BeginInvoke((MethodInvoker)delegate
            {
                bool hasCheckedUser = listViewUsers_User2.Items.Cast<ListViewItem>().Any(item => item.Checked || item.Index == e.Index && e.NewValue == CheckState.Checked);

                if (!hasCheckedUser)
                {
                    if (checkBoxGrantRole.Checked)
                    {
                        // Reset Grant Role
                        comboBoxGrantRole.SelectedIndex = -1;
                        comboBoxGrantRole.Text = "";
                    }
                    else
                    {
                        // Reset PrivType
                        comboBoxPrivTypes_User.SelectedIndex = -1;
                        comboBoxPrivTypes_User.Text = "";
                        comboBoxPrivs_User.Items.Clear();
                        comboBoxPrivs_User.Text = "";
                        comboBoxObjects_User.Items.Clear();
                        comboBoxObjects_User.Text = "";
                        comboBoxColumns_User.Items.Clear();
                        comboBoxColumns_User.Text = "";
                        comboBoxColumns_User.Enabled = false;
                        checkBoxWithGrant_User.Checked = false;
                        checkBoxWithGrant_User.Enabled = false;
                    }
                }
            });
        }


        private void buttonGrantPriv_User_Click(object sender, EventArgs e)
        {
            bool isGrantRoleMode = checkBoxGrantRole.Checked;

            if (isGrantRoleMode)
            {
                string selectedGrantRole = comboBoxGrantRole.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedGrantRole))
                {
                    MessageBox.Show("Please choose a role to grant!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (ListViewItem item in listViewUsers_User2.CheckedItems)
                {
                    string username = item.Text;
                    UserService.GrantRoleToUser(username, selectedGrantRole);
                }

                MessageBox.Show("Role granted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedType = comboBoxPrivTypes_User.SelectedItem?.ToString();
            string selectedPriv = comboBoxPrivs_User.SelectedItem?.ToString();
            string selectedObject = comboBoxObjects_User.SelectedItem?.ToString();
            string selectedColumn = comboBoxColumns_User.Enabled ? comboBoxColumns_User.SelectedItem?.ToString() : null;
            bool withGrant = checkBoxWithGrant_User.Checked;

            if (string.IsNullOrEmpty(selectedType) || string.IsNullOrEmpty(selectedPriv) || string.IsNullOrEmpty(selectedObject))
            {
                MessageBox.Show("Please select all required privilege fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (ListViewItem item in listViewUsers_User2.CheckedItems)
                {
                    string username = item.Text;
                    UserService.GrantPrivilegeToUser(username, selectedPriv, selectedType, selectedObject, selectedColumn, withGrant);
                }

                MessageBox.Show("Privileges granted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error granting privilege:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
