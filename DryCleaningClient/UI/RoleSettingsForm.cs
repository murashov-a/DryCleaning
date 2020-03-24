using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class RoleSettingsForm : Form
    {
        /// <summary>
        /// Modified role
        /// </summary>
        public Role Role { get; private set; }
        public RoleSettingsForm(Role role)
        {
            Role = role.Clone();

            InitializeComponent();

            textBox_Name.Text = string.Format(textBox_Name.Text, Role.Name);
            textBox_Salary.Text = string.Format(textBox_Salary.Text, Role.Salary);
        }

        private void CheckCurrectInputs()
        {
            //name
            bool nameValid = !string.IsNullOrEmpty(textBox_Name.Text);

            //role
            int salary;
            bool salaryValid = string.IsNullOrEmpty(textBox_Salary.Text) || Int32.TryParse(textBox_Salary.Text, out salary);

            button_Save.Enabled = nameValid && salaryValid;
        }

        private void button_Save_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
        private void textBox_Name_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();
        private void textBox_Salary_TextChanged(object sender, EventArgs e) => CheckCurrectInputs();

        private void RoleSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Role.Name = textBox_Name.Text;
            if (string.IsNullOrEmpty(textBox_Salary.Text))
            {
                Role.Salary = null;
            }
            else
            {
                Role.Salary = Int32.Parse(textBox_Salary.Text);
            }
        }
    }
}
