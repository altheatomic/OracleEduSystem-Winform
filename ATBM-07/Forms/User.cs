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

            // ComboBox Roles Setup
            try
            {
                comboBoxRoles_User1.Items.Add("None");
                foreach (var role in RoleService.GetApplicationRoles())
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

        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBoxRoles_User1.SelectedItem?.ToString() ?? "";
            listViewUsers_User1.Items.Clear();
            comboBoxUsers_User1.Items.Clear();

            if (selectedRole != "None")
            {
                try
                {
                    var users = RoleService.GetUsersByRole(selectedRole);

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
            }
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

    }
}