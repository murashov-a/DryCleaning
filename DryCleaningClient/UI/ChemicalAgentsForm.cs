using System;
using System.ComponentModel;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class ChemicalAgentsForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;

        /// <summary>
        /// Modified Results
        /// </summary>
        public BindingList<ChemicalAgent> ChemicalAgents { get; private set; } = new BindingList<ChemicalAgent>();
        public ChemicalAgentsForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            ChemicalAgents = new BindingList<ChemicalAgent>(_client.ChemicalAgent.GetChemicalAgents());

            InitializeComponent();

            UpdateChemicalAgentsList();
        }

        private void UpdateChemicalAgentsList()
        {
            ChemicalAgents = new BindingList<ChemicalAgent>(_client.ChemicalAgent.GetChemicalAgents());
            objectListView_ChemicalAgents.SetObjects(ChemicalAgents);
            objectListView_ChemicalAgents.Update();
        }

        private void button_ChemicalAgentAdd_Click(object sender, EventArgs e)
        {
            var chemicalAgent = ChemicalAgent.Default;
            var chemicalAgentSettingsForm = new ChemicalAgentSettingsForm(chemicalAgent);
            if (chemicalAgentSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.ChemicalAgent.Add(chemicalAgentSettingsForm.ChemicalAgent);
                UpdateChemicalAgentsList();
            }
        }

        private void button_ChemicalAgentEdit_Click(object sender, EventArgs e)
        {
            if (objectListView_ChemicalAgents.SelectedObject is ChemicalAgent chemicalAgent)
            {
                var chemicalAgentSettingsForm = new ChemicalAgentSettingsForm(chemicalAgent);
                if (chemicalAgentSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.ChemicalAgent.Edit(chemicalAgent.Name, chemicalAgentSettingsForm.ChemicalAgent);
                    UpdateChemicalAgentsList();
                }
            }
        }

        private void button_ChemicalAgentDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_ChemicalAgents.SelectedObject is ChemicalAgent chemicalAgent)
            {
                if (MessageBox.Show($"Удалить химическое средство '{chemicalAgent.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.ChemicalAgent.Delete(chemicalAgent);
                    UpdateChemicalAgentsList();
                }
            }
        }
    }
}
