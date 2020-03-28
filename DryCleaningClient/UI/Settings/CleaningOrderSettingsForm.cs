using System;
using System.Windows.Forms;
using DryCleaningAPI.API.Responses;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class CleaningOrderSettingsForm : Form
    {
        /// <summary>
        /// Modified CleaningOrder
        /// </summary>
        public CleaningOrder CleaningOrder { get; private set; }
        private readonly DryCleaningAPI.DryCleaningClient _client;
        public CleaningOrderSettingsForm(CleaningOrder cleaningOrder, DryCleaningAPI.DryCleaningClient client)
        {
            CleaningOrder = cleaningOrder.Clone();
            _client = client;

            InitializeComponent();

            dateTimePicker_DateOfReceipt.Value = CleaningOrder.DateOfReceipt;
            dateTimePicker_TargetTerm.Value = CleaningOrder.TargetTerm;

            if (dateTimePicker_DateOfReturn.Checked = CleaningOrder.DateOfReturn.HasValue)
            {
                dateTimePicker_DateOfReturn.Value = CleaningOrder.DateOfReturn.Value;
            }
            if (dateTimePicker_ActualTerm.Checked = CleaningOrder.ActualTerm.HasValue)
            {
                dateTimePicker_ActualTerm.Value = CleaningOrder.ActualTerm.Value;
            }

            comboBox_User.Items.AddRange(client.Users.GetUsers());
            var selectedUser = client.Users.GetUser(cleaningOrder.Employee);
            comboBox_User.SelectedItem = selectedUser;

            comboBox_Client.Items.AddRange(client.Clients.GetClients());
            var selectedClient = client.Clients.GetClient(cleaningOrder.Client);
            comboBox_Client.SelectedItem = selectedClient;
        }

        private void CheckCurrectInputs()
        {
            bool currect = true;
            if (dateTimePicker_ActualTerm.Checked && dateTimePicker_ActualTerm.Value < dateTimePicker_DateOfReceipt.Value)
                currect = false;
            if (dateTimePicker_TargetTerm.Value < dateTimePicker_DateOfReceipt.Value)
                currect = false;
            if (dateTimePicker_DateOfReturn.Value < dateTimePicker_DateOfReceipt.Value)
                currect = false;

            button_Save.Enabled = currect;
        }

        private void button_Save_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
        private void dateTimePicker_DateOfReceipt_ValueChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void dateTimePicker_DateOfReturn_ValueChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void dateTimePicker_TargetTerm_ValueChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void dateTimePicker_ActualTerm_ValueChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void comboBox_Users_SelectedIndexChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void comboBox_Client_SelectedIndexChanged(object sender, EventArgs e) => CheckCurrectInputs();

        private void CleaningOrderSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleaningOrder.DateOfReceipt = dateTimePicker_DateOfReceipt.Value;
            if (!dateTimePicker_DateOfReturn.Checked)
            {
                CleaningOrder.DateOfReturn = null;
            }
            else
            {
                CleaningOrder.DateOfReturn = dateTimePicker_DateOfReturn.Value;
            }

            CleaningOrder.TargetTerm = dateTimePicker_TargetTerm.Value;

            if (!dateTimePicker_ActualTerm.Checked)
            {
                CleaningOrder.ActualTerm = null;
            }
            else
            {
                CleaningOrder.ActualTerm = dateTimePicker_ActualTerm.Value;
            }
            CleaningOrder.Client = ((Client)comboBox_Client.SelectedItem).ID;
            CleaningOrder.Employee = ((User)comboBox_User.SelectedItem).PassportID;
        }
    }
}
