using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class MaterialSettingsForm : Form
    {
        /// <summary>
        /// Modified material
        /// </summary>
        public Material Material { get; private set; }
        public MaterialSettingsForm(Material material)
        {
            Material = material.Clone();

            InitializeComponent();

            textBox_Name.Text = string.Format(textBox_Name.Text, material.Name);
        }

        private void CheckCurrectInputs()
        {
            button_Save.Enabled = !string.IsNullOrEmpty(textBox_Name.Text);
        }

        private void button_Save_Click(object sender, System.EventArgs e) => this.DialogResult = DialogResult.OK;

        private void textBox_Name_TextChanged(object sender, System.EventArgs e) => CheckCurrectInputs();

        private void MaterialSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Material.Name = textBox_Name.Text;
        }
    }
}
