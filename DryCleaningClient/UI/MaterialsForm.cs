using System;
using System.ComponentModel;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class MaterialsForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;

        /// <summary>
        /// Modified Materials
        /// </summary>
        public BindingList<Material> Materials { get; private set; } = new BindingList<Material>();

        public MaterialsForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            Materials = new BindingList<Material>(_client.Materials.GetMaterials());

            InitializeComponent();

            UpdateMaterialsList();
        }

        private void UpdateMaterialsList()
        {
            Materials = new BindingList<Material>(_client.Materials.GetMaterials());
            objectListView_Materials.SetObjects(Materials);
            objectListView_Materials.Update();
        }

        private void button_MaterialEdit_Click(object sender, EventArgs e)
        {
            if (objectListView_Materials.SelectedObject is Material material)
            {
                var materialSettingsForm = new MaterialSettingsForm(material);
                if (materialSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Materials.Edit(material.Name, materialSettingsForm.Material);
                    UpdateMaterialsList();
                }
            }
        }

        private void button_MaterialAdd_Click(object sender, EventArgs e)
        {
            var material = Material.Default;
            var materialSettingsForm = new MaterialSettingsForm(material);
            if (materialSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Materials.Add(materialSettingsForm.Material);
                UpdateMaterialsList();
            }
        }

        private void button_MaterialDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_Materials.SelectedObject is Material material)
            {
                if (MessageBox.Show($"Удалить материал '{material.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Materials.Delete(material);
                    UpdateMaterialsList();
                }
            }
        }
    }
}
