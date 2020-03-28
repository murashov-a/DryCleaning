using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class ChemicalAgentSettingsForm : Form
    {
        /// <summary>
        /// Modified ChemicalAgent
        /// </summary>
        public ChemicalAgent ChemicalAgent { get; private set; }
        public ChemicalAgentSettingsForm(ChemicalAgent chemicalAgent)
        {
            ChemicalAgent = chemicalAgent.Clone();

            InitializeComponent();

            textBox_Name.Text = string.Format(textBox_Name.Text, chemicalAgent.Name);
        }

        private void CheckCurrectInputs()
        {
            button_Save.Enabled = !string.IsNullOrEmpty(textBox_Name.Text);
        }

        private void button_Save_Click(object sender, System.EventArgs e) => this.DialogResult = DialogResult.OK;

        private void textBox_Name_TextChanged(object sender, System.EventArgs e) => CheckCurrectInputs();

        private void ChemicalAgentSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChemicalAgent.Name = textBox_Name.Text;
        }
    }
}
