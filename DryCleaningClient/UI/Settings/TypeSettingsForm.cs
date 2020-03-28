using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;
using Type = DryCleaningClient.API.Responses.Type;

namespace DryCleaningClient.UI
{
    public partial class TypeSettingsForm : Form
    {
        /// <summary>
        /// Modified type
        /// </summary>
        public Type Type { get; private set; }
        public TypeSettingsForm(Type type)
        {
            Type = type.Clone();
            InitializeComponent();

            textBox_Name.Text = string.Format(textBox_Name.Text, Type.Name);
            textBox_Compensation.Text = string.Format(textBox_Compensation.Text, Type.Compensation);
            textBox_CleaningPrice.Text = string.Format(textBox_CleaningPrice.Text, Type.CleaningPrice);

            CheckCurrectInputs();
        }

        private void CheckCurrectInputs()
        {
            //Compensation
            int compensation = 0;
            bool compensationValid = false;
            if (Int32.TryParse(textBox_Compensation.Text, out compensation))
            {
                compensationValid = compensation > 0;
            }

            //CleaningPrice
            int cleaningPrice = 0;
            bool cleaningPriceValid = false;
            if (Int32.TryParse(textBox_CleaningPrice.Text, out cleaningPrice))
            {
                cleaningPriceValid = cleaningPrice > 0;
            }

            //name
            bool nameValid = !string.IsNullOrEmpty(textBox_Name.Text);

            button_Save.Enabled = compensationValid && cleaningPriceValid && nameValid;
        }

        private void TypeSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Type.Name = textBox_Name.Text;
            Type.Compensation = Int32.Parse(textBox_Compensation.Text);
            Type.CleaningPrice = Int32.Parse(textBox_CleaningPrice.Text);
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void textBox_Compensation_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void textBox_CleaningPrice_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();

        private void button_Save_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
    }
}
