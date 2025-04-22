using ATBM_07.Services;

namespace ATBM_07
{
    public partial class GrantRole : Form
    {
        public GrantRole()
        {
            InitializeComponent();

            comboBoxRoles_Role2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxRoles_Role2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRoles_Role2.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxPrivTypes_Role.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxPrivTypes_Role.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPrivTypes_Role.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxPrivs_Role.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxPrivs_Role.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxPrivs_Role.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxObjects_Role.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxObjects_Role.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxObjects_Role.AutoCompleteSource = AutoCompleteSource.ListItems;

            LoadRoles();
            comboBoxRoles_Role2.SelectedIndexChanged += comboBoxRoles_Role_SelectedIndexChanged;
            comboBoxPrivTypes_Role.Items.AddRange(new string[] { "System", "Object" });
            comboBoxPrivTypes_Role.SelectedIndexChanged += comboBoxPrivTypes_Role_SelectedIndexChanged;
            comboBoxPrivs_Role.SelectedIndexChanged += comboBoxPrivs_Role_SelectedIndexChanged;
            comboBoxObjects_Role.SelectedIndexChanged += comboBoxObjects_Role_SelectedIndexChanged;

            listViewRoles_Role2.ItemChecked += listViewRoles_Role2_ItemChecked;
        }

        private void LoadRoles()
        {
            try
            {
                listViewRoles_Role2.Columns.Clear();
                listViewRoles_Role2.Items.Clear();
                comboBoxRoles_Role2.Items.Clear();

                listViewRoles_Role2.View = View.Details;
                listViewRoles_Role2.FullRowSelect = true;
                listViewRoles_Role2.GridLines = true;
                listViewRoles_Role2.CheckBoxes = true;
                listViewRoles_Role2.Columns.Add("Role", 300);

                foreach (var role in RoleService.GetAllRoles())
                {
                    var item = new ListViewItem(role);
                    listViewRoles_Role2.Items.Add(item);
                    comboBoxRoles_Role2.Items.Add(role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oracle error:\n" + ex.Message);
            }
        }

        private void comboBoxRoles_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBoxRoles_Role2.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedRole)) return;

            foreach (ListViewItem item in listViewRoles_Role2.Items)
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

        private bool suppressPrivTypeChange = false;
        private void comboBoxPrivTypes_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressPrivTypeChange) return;

            bool hasCheckedRole = false;
            foreach (ListViewItem item in listViewRoles_Role2.Items)
            {
                if (item.Checked)
                {
                    hasCheckedRole = true;
                    break;
                }
            }

            if (!hasCheckedRole)
            {
                suppressPrivTypeChange = true;
                comboBoxPrivTypes_Role.SelectedIndex = -1;
                suppressPrivTypeChange = false;
                MessageBox.Show("Please choose a role before choosing Priv Type!", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comboBoxPrivs_Role.Items.Clear();
            comboBoxPrivs_Role.Text = "";
            comboBoxObjects_Role.Items.Clear();
            comboBoxObjects_Role.Text = "";
            comboBoxColumns_Role.Items.Clear();
            comboBoxColumns_Role.Text = "";
            comboBoxColumns_Role.Enabled = false;

            string selectedType = comboBoxPrivTypes_Role.SelectedItem?.ToString();
            if (selectedType == "System")
            {
                var systemPrivs = PrivilegeService.GetSystemPrivileges();
                comboBoxPrivs_Role.Items.AddRange(systemPrivs.ToArray());
            }
            else if (selectedType == "Object")
            {
                var objectPrivs = PrivilegeService.GetObjectPrivileges();
                comboBoxPrivs_Role.Items.AddRange(objectPrivs.ToArray());
            }

            if (comboBoxPrivs_Role.Items.Count > 0)
                comboBoxPrivs_Role.SelectedIndex = 0;
        }

        private void comboBoxPrivs_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxObjects_Role.Items.Clear();
            comboBoxObjects_Role.Text = "";
            comboBoxColumns_Role.Items.Clear();
            comboBoxColumns_Role.Text = "";

            string selectedPriv = comboBoxPrivs_Role.SelectedItem?.ToString()?.ToUpper() ?? "";

            if (selectedPriv == "SELECT" || selectedPriv == "UPDATE")
            {
                comboBoxColumns_Role.Enabled = true;
            }
            else
            {
                comboBoxColumns_Role.Enabled = false;
            }

            var compatibleObjects = ObjectService.GetCompatibleObjects(selectedPriv);
            comboBoxObjects_Role.Items.AddRange(compatibleObjects.ToArray());

            if (comboBoxObjects_Role.Items.Count > 0)
                comboBoxObjects_Role.SelectedIndex = 0;
        }

        private void comboBoxObjects_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedObject = comboBoxObjects_Role.SelectedItem?.ToString() ?? "";
            string selectedPriv = comboBoxPrivs_Role.SelectedItem?.ToString()?.ToUpper() ?? "";

            comboBoxColumns_Role.Items.Clear();
            comboBoxColumns_Role.Text = "";

            if (string.IsNullOrEmpty(selectedObject) || string.IsNullOrEmpty(selectedPriv))
                return;

            if ((selectedPriv == "SELECT" || selectedPriv == "UPDATE") &&
                ObjectService.GetTables().Contains(selectedObject.ToUpper()))
            {
                try
                {
                    var columns = ObjectService.GetTableColumns(selectedObject.ToUpper());
                    comboBoxColumns_Role.Items.AddRange(columns.ToArray());

                    if (comboBoxColumns_Role.Items.Count > 0)
                        comboBoxColumns_Role.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't load the column list:\n" + ex.Message);
                }
            }
        }

        private void listViewRoles_Role2_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int checkedCount = listViewRoles_Role2.CheckedItems.Count;

            if (checkedCount < 1)
            {
                comboBoxPrivTypes_Role.SelectedIndex = -1;
                comboBoxPrivTypes_Role.Text = "";
                comboBoxPrivs_Role.Items.Clear();
                comboBoxPrivs_Role.Text = "";
                comboBoxObjects_Role.Items.Clear();
                comboBoxObjects_Role.Text = "";
                comboBoxColumns_Role.Items.Clear();
                comboBoxColumns_Role.Text = "";
                comboBoxColumns_Role.Enabled = false;
            }
        }

        private void buttonGrantPriv_Role_Click(object sender, EventArgs e)
        {
            if (listViewRoles_Role2.CheckedItems.Count != 1)
            {
                MessageBox.Show("Please select exactly one role to grant privilege.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRole = listViewRoles_Role2.CheckedItems[0].Text;
            var selectedType = comboBoxPrivTypes_Role.SelectedItem?.ToString();
            var selectedPriv = comboBoxPrivs_Role.SelectedItem?.ToString();
            var selectedObject = comboBoxObjects_Role.SelectedItem?.ToString();
            var selectedColumn = comboBoxColumns_Role.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedPriv) || string.IsNullOrEmpty(selectedType))
            {
                MessageBox.Show("No privs is chosen!");
                return;
            }

            try
            {
                RoleService.GrantPrivilegeToRole(selectedRole, selectedPriv, selectedType,
                selectedType == "Object" ? selectedObject : null,
                comboBoxColumns_Role.Enabled ? selectedColumn : null);

                MessageBox.Show("Privilege granted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}