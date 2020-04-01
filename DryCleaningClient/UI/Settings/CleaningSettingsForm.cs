using System;
using System.Linq;
using System.Windows.Forms;
using DryCleaningAPI.API.Responses;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class CleaningSettingsForm : Form
    {
        /// <summary>
        /// Modified Cleaning
        /// </summary>
        public Cleaning Cleaning { get; private set; }
        private readonly DryCleaningAPI.DryCleaningClient _client;
        public CleaningSettingsForm(Cleaning cleaning, DryCleaningAPI.DryCleaningClient client)
        {
            Cleaning = cleaning.Clone();
            _client = client;

            InitializeComponent();

            dateTimePicker_Date.Value = Cleaning.Date;

            comboBox_User.Items.AddRange(client.Users.GetUsers());
            var selectedUser = client.Users.GetUser(Cleaning.Employee);
            comboBox_User.SelectedItem = selectedUser;

            var allChemicalAgents = client.ChemicalAgent.GetChemicalAgents();
            comboBox_ChemicalAgent.Items.AddRange(allChemicalAgents);
            var selectedChemicalAgent = allChemicalAgents.First(x => x.Name.Equals(Cleaning.ChemicalAgent));
            comboBox_ChemicalAgent.SelectedItem = selectedChemicalAgent;

            var allResults = client.Results.GetResults();
            comboBox_Result.Items.AddRange(allResults);
            var selectedResult= allResults.First(x => x.Name.Equals(Cleaning.Result));
            comboBox_Result.SelectedItem = selectedResult;
        }

        private void CheckCurrectInputs()
        {
            button_Save.Enabled = dateTimePicker_Date.Value <= DateTime.Now;
        }

        private void dateTimePicker_Date_ValueChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void comboBox_Result_SelectedIndexChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void comboBox_User_SelectedIndexChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void comboBox_ChemicalAgent_SelectedIndexChanged(object sender, EventArgs e) => CheckCurrectInputs();

        private void button_Save_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void CleaningSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cleaning.Result = ((Result)comboBox_Result.SelectedItem).Name;
            Cleaning.Employee = ((User)comboBox_User.SelectedItem).PassportID;
            Cleaning.ChemicalAgent = ((ChemicalAgent)comboBox_ChemicalAgent.SelectedItem).Name;
            Cleaning.Date = dateTimePicker_Date.Value;
        }
    }
}
