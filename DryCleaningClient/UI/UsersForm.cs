using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class UsersForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;

        /// <summary>
        /// Modified users
        /// </summary>
        public BindingList<User> Users { get; private set; } = new BindingList<User>();
        public BindingList<Role> Roles { get; private set; } = new BindingList<Role>();

        private readonly User _currentUser;

        public UsersForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            Users = new BindingList<User>(_client.Users.GetUsers());
            _currentUser = _client.Users.GetCurrentUser();
            InitializeComponent();

            button_UserAdd.Enabled = _currentUser.IsAdmin;
            UpdateUsersList();
            UpdateRolesList();
        }

        private void UpdateUsersList()
        {
            Users = new BindingList<User>(_client.Users.GetUsers());
            objectListView_Users.SetObjects(Users);
            objectListView_Users.Update();
        }

        private void UpdateRolesList()
        {
            Roles = new BindingList<Role>(_client.Roles.GetRoles());
            objectListView_Roles.SetObjects(Roles);
            objectListView_Users.Update();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListView_Users.SelectedObject is User user)
            {
                var userSettingsForm = new UserSettingsForm(user, _client);
                if (userSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Users.Edit(user.PassportID, userSettingsForm.User);
                    if (user.PassportID == _currentUser.PassportID && !_currentUser.PassportID.Equals(userSettingsForm.User.PassportID))
                    {
                        this.Close();
                    }
                }

            }

            UpdateUsersList();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (objectListView_Users.SelectedObject is User user)
            {
                
                var userSettingsForm = new UserSettingsForm(user, _client);
                if (userSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Users.Edit(user.PassportID, userSettingsForm.User);
                    if (user.PassportID == _currentUser.PassportID && !_currentUser.PassportID.Equals(userSettingsForm.User.PassportID))
                    {
                        this.Close();
                    }
                }
            }
            UpdateUsersList();
        }

        private void objectListView_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_UserEdit.Enabled = button_UserDelete.Enabled = objectListView_Users.SelectedObject is User && _currentUser.IsAdmin;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (objectListView_Users.SelectedObject is User user)
            {
                if (MessageBox.Show($"Удалить сотрудника '{user.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Users.Delete(user.PassportID);
                    UpdateUsersList();
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var user = User.Default;
            var userSettingsForm = new UserSettingsForm(user, _client);
            if (userSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Users.Add(userSettingsForm.User);
                UpdateUsersList();
            }
        }

        private void button_RoleEdit_Click(object sender, EventArgs e)
        {
            if (objectListView_Roles.SelectedObject is Role role)
            {
                var roleSettingsForm = new RoleSettingsForm(role, _client);
                if (roleSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Roles.Edit(role.Name, roleSettingsForm.Role);
                    UpdateRolesList();
                }
            }
        }

        private void objectListView_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_RoleEdit.Enabled = button_RoleDelete.Enabled = objectListView_Roles.SelectedObject is Role && _currentUser.IsAdmin;
        }

        private void button_RoleDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_Roles.SelectedObject is Role role)
            {
                if (MessageBox.Show($"Удалить должность '{role.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Roles.Delete(role);
                    UpdateRolesList();
                }
            }
        }

        private void button_RoleAdd_Click(object sender, EventArgs e)
        {
            var role = Role.Default;
            var roleSettingsForm = new RoleSettingsForm(role, _client);
            if (roleSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Roles.Add(roleSettingsForm.Role);
                UpdateRolesList();
            }
        }
    }
}
