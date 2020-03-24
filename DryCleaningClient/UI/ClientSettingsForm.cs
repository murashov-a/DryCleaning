using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class ClientSettingsForm : Form
    {
        /// <summary>
        /// Modified client
        /// </summary>
        public Client Client { get; private set; }

        public ClientSettingsForm(Client client)
        {
            Client = client.Clone();
            InitializeComponent();

            textBox_Name.Text = string.Format(textBox_Name.Text, Client.Name);
            textBox_Telephone.Text = string.Format(textBox_Telephone.Text, Client.Telephone);
        }

        private void CheckCurrectInputs()
        {
            //name
            bool nameValid = !string.IsNullOrEmpty(textBox_Name.Text);

            //telephone
            var regex = new Regex(@"^(\+7|7|8)?[\s\-]?\(?[489][0-9]{2}\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}$");
            bool telephoneValid = regex.IsMatch(textBox_Telephone.Text);

            button_Save.Enabled = nameValid && telephoneValid;
        }

        private void button_Save_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void textBox_Name_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void textBox_Telephone_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();

        private void ClientSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client.Name = textBox_Name.Text;
            Client.Telephone = textBox_Telephone.Text;
        }
    }
}
