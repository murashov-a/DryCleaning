using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DryCleaningAPI.Exceptions;

namespace DryCleaningClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var dryCleaningClient = new DryCleaningAPI.DryCleaningClient("http://localhost",
                    Int32.Parse(textBox_PassportID.Text),
                    maskedTextBox_Password.Text);
            }
            catch (DryCleaningException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
