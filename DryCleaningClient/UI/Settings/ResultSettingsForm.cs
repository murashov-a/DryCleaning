using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class ResultSettingsForm : Form
    {
        /// <summary>
        /// Modified result
        /// </summary>
        public Result Result { get; private set; }
        public ResultSettingsForm(Result result)
        {
            Result = result.Clone();

            InitializeComponent();

            textBox_Name.Text = string.Format(textBox_Name.Text, result.Name);
        }

        private void CheckCurrectInputs()
        {
            button_Save.Enabled = !string.IsNullOrEmpty(textBox_Name.Text);
        }

        private void button_Save_Click(object sender, System.EventArgs e) => this.DialogResult = DialogResult.OK;

        private void textBox_Name_TextChanged(object sender, System.EventArgs e) => CheckCurrectInputs();

        private void ResultSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Result.Name = textBox_Name.Text;
        }
    }
}
