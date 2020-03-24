using System.ComponentModel;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class ClientsForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;

        /// <summary>
        /// Modified clients
        /// </summary>
        public BindingList<Client> Clients { get; private set; } = new BindingList<Client>();

        private readonly User _currentUser;

        public ClientsForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            Clients = new BindingList<Client>(_client.Clients.GetClients());
            _currentUser = _client.Users.GetCurrentUser();
            InitializeComponent();

            button_ClientAdd.Enabled = _currentUser.IsAdmin;

            UpdateClientsList();
        }

        private void UpdateClientsList()
        {
            Clients = new BindingList<Client>(_client.Clients.GetClients());
            objectListView_Clients.SetObjects(Clients);
            objectListView_Clients.Update();
        }

        private void button_ClientAdd_Click(object sender, System.EventArgs e)
        {
            var client = _client.Clients.Add("", "");
            var clientSettingsForm = new ClientSettingsForm(client);
            if (clientSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Clients.Edit(clientSettingsForm.Client);
                UpdateClientsList();
            }
            else
            {
                _client.Clients.Delete(client.ID);
            }
        }

        private void button_ClientEdit_Click(object sender, System.EventArgs e)
        {
            if (objectListView_Clients.SelectedObject is Client client)
            {
                var clientSettingsForm = new ClientSettingsForm(client);
                if (clientSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Clients.Edit(clientSettingsForm.Client);
                    UpdateClientsList();
                }
            }
        }

        private void button_ClientDelete_Click(object sender, System.EventArgs e)
        {
            if (objectListView_Clients.SelectedObject is Client client)
            {
                if (MessageBox.Show($"Удалить клиента '{client.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Clients.Delete(client.ID);
                    UpdateClientsList();
                }
            }
        }

        private void objectListView_Clients_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            button_ClientEdit.Enabled = button_ClientDelete.Enabled = objectListView_Clients.SelectedObject is Client && _currentUser.IsAdmin;
        }
    }
}
