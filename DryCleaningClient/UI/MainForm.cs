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

            UpdateToolStripUserName();
        }

        private void UpdateToolStripUserName()
        {
            nameToolStripMenuItem.Text = string.Format(nameToolStripMenuItem.Text, _client.Users.GetCurrentUser().Name);
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
                UpdateToolStripUserName();
                currentUser = userSettingsForm.User;
                // push
            }

        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
