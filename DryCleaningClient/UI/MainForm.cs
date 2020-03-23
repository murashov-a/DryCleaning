using System.Linq;
using System.Windows.Forms;
using DryCleaningAPI;

namespace DryCleaningClient.UI
{
    public partial class MainForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;
        public MainForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            InitializeComponent();
        }

        /// <summary>
        /// Настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var currentUser = _client.Users.GetCurrentUser();
            var userSettingsForm = new UserSettingsForm(currentUser, _client);
            if (userSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Users.Edit(currentUser.PassportID, userSettingsForm.User); //.EditCurrentUser(userSettingsForm.User);
                if (!currentUser.PassportID.Equals(userSettingsForm.User.PassportID))
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e) => this.Close();

        private void сотрудникиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new UsersForm(_client).ShowDialog();
        }

        private void nameToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e) => uSERNAMEToolStripMenuItem.Text = $"{_client.Users.GetCurrentUser().Name}";
    }
}
