using System;
using System.Windows.Forms;
using DryCleaningAPI.Exceptions;
using DryCleaningClient.UI;

namespace DryCleaningClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

#if DEBUG
            textBox_PassportID.Text = "123456";
            maskedTextBox_Password.Text = "1234";

#endif
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            int passportid;
            string password;
            if (Int32.TryParse(textBox_PassportID.Text, out passportid) && !string.IsNullOrEmpty(maskedTextBox_Password.Text))
            {
                password = maskedTextBox_Password.Text;

                DryCleaningAPI.DryCleaningClient client = null;
                try
                {
                    client = new DryCleaningAPI.DryCleaningClient(textBox_Server.Text, passportid, password);
                }
                catch (DryCleaningException exception)
                {
                    MessageBox.Show($"Ошибка: {exception.Message}", "Авторизация", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (client != null)
                {
                    var mainForm = new MainForm(client);
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
            }
        }
    }
}
