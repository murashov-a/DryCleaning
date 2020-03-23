using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DryCleaningAPI;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class UserSettingsForm : Form
    {
        /// <summary>
        /// Modified user
        /// </summary>
        public User User { get; private set; }
        private readonly DryCleaningAPI.DryCleaningClient _client;

        public UserSettingsForm(User user, DryCleaningAPI.DryCleaningClient client)
        {
            User = user.Clone();
            _client = client;

            InitializeComponent();

            textBox_PassportID.Text = string.Format(textBox_PassportID.Text, User.PassportID);
            textBox_Name.Text = string.Format(textBox_Name.Text, User.Name);

            //only admin can edit role and isAdmin
            var currentUser = _client.Users.GetCurrentUser();
            comboBox_Role.Enabled = checkBox_IsAdmin.Enabled = currentUser.IsAdmin;
            checkBox_IsAdmin.CheckState = User.IsAdmin ? CheckState.Checked : CheckState.Unchecked;
            comboBox_Role.Items.AddRange(client.Roles.GetRoles());
            comboBox_Role.Text = User.Role;

            CheckCurrectInputs();
        }

        private void MaskedTextBox_PasswordOnTextChanged(object sender, EventArgs e)
        {
            bool identicalPassword = maskedTextBox_Password.Text == maskedTextBox_Password2.Text;

            //Pass color
            Color passFrameColor = identicalPassword ? Color.Green : Color.Red;
            if (string.IsNullOrEmpty(maskedTextBox_Password.Text))
            {
                passFrameColor = Color.White;
            }
            maskedTextBox_Password.BackColor = maskedTextBox_Password2.BackColor = passFrameColor;

            CheckCurrectInputs();
        }

        private void CheckCurrectInputs()
        {
            //password
            bool passwordValid = maskedTextBox_Password.Text == maskedTextBox_Password2.Text;

            //passport
            int passportId = 0;
            bool passportValid = false;
            if(Int32.TryParse(textBox_PassportID.Text, out passportId))
            {
                passportValid = passportId == User.PassportID || !_client.Users.GetUsers().Any(x => x.PassportID == passportId);
            }

            //name
            bool nameValid = !string.IsNullOrEmpty(textBox_Name.Text);

            //role
            bool roleValid = _client.Roles.GetRoles().Contains(comboBox_Role.SelectedItem);

            button_Save.Enabled = passwordValid && passportValid && nameValid && roleValid;
        }

        private void UserSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            User.PassportID = Int32.Parse(textBox_PassportID.Text);
            User.Name = textBox_Name.Text;
            User.Role = comboBox_Role.Text;
            User.Password = maskedTextBox_Password.Text;
            User.IsAdmin = checkBox_IsAdmin.CheckState == CheckState.Checked ? true : false;
        }

        private void textBox_PassportID_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void textBox_Name_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void comboBox_Role_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();

        private void button_Save_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
    }
}
