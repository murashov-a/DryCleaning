using System;
using System.ComponentModel;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;
using Type = DryCleaningClient.API.Responses.Type;

namespace DryCleaningClient.UI
{
    public partial class TypesForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;

        /// <summary>
        /// Modified Types
        /// </summary>
        public BindingList<Type> Types { get; private set; } = new BindingList<Type>();

        private readonly User _currentUser;
        public TypesForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            Types = new BindingList<Type>(_client.Types.GetTypes());
            _currentUser = _client.Users.GetCurrentUser();

            InitializeComponent();

            UpdateTypesList();
        }

        private void UpdateTypesList()
        {
            Types = new BindingList<Type>(_client.Types.GetTypes());
            objectListView_Types.SetObjects(Types);
            objectListView_Types.Update();
        }

        private void button_MaterialEdit_Click(object sender, EventArgs e)
        {
            if (objectListView_Types.SelectedObject is Type type)
            {
                var typeSettingsForm = new TypeSettingsForm(type);
                if (typeSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Types.Edit(type.Name, typeSettingsForm.Type);
                    UpdateTypesList();
                }
            }
        }

        private void button_MaterialAdd_Click(object sender, EventArgs e)
        {
            var type = Type.Default;
            var typeSettingsForm = new TypeSettingsForm(type);
            if (typeSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Types.Add(typeSettingsForm.Type);
                UpdateTypesList();
            }
        }

        private void button_MaterialDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_Types.SelectedObject is Type type)
            {
                if (MessageBox.Show($"Удалить тип '{type.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Types.Delete(type);
                    UpdateTypesList();
                }
            }
        }

        private void button_TypeDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_Types.SelectedObject is Type type)
            {
                if (MessageBox.Show($"Удалить тип '{type.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Types.Delete(type);
                    UpdateTypesList();
                }
            }
        }

        private void button_TypeEdit_Click(object sender, EventArgs e)
        {
            if (objectListView_Types.SelectedObject is Type type)
            {
                var typeSettingsForm = new TypeSettingsForm(type);
                if (typeSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Types.Edit(type.Name, typeSettingsForm.Type);
                    UpdateTypesList();
                }
            }
        }

        private void button_TypeAdd_Click(object sender, EventArgs e)
        {
            var type = Type.Default;
            var typeSettingsForm = new TypeSettingsForm(type);
            if (typeSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Types.Add(typeSettingsForm.Type);
                UpdateTypesList();
            }
        }
    }
}
