using System.Linq;
using System.Windows.Forms;
using DryCleaningAPI.API.Responses;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class ThingSettingsForm : Form
    {
        /// <summary>
        /// Modified thing
        /// </summary>
        public Thing Thing { get; private set; }
        private readonly DryCleaningAPI.DryCleaningClient _client;

        public ThingSettingsForm(Thing thing, DryCleaningAPI.DryCleaningClient client)
        {
            Thing = thing.Clone();
            _client = client;

            InitializeComponent();

            textBox_Name.Text = Thing.Name;

            var materials = _client.Materials.GetMaterials();
            var types = _client.Types.GetTypes();
            var cleaningOrders = _client.CleaningOrders.GetCleaningOrders();

            comboBox_Material.Items.AddRange(materials);
            comboBox_Type.Items.AddRange(types);
            comboBox_CleaningOrder.Items.AddRange(cleaningOrders);

            comboBox_Material.SelectedItem = materials.First(x => x.Name.Equals(Thing.Material));
            comboBox_Type.SelectedItem = types.First(x => x.Name.Equals(Thing.Type));
            comboBox_CleaningOrder.SelectedItem = cleaningOrders.First(x => x.ID.Equals(Thing.CleaningOrder));
        }

        void CheckCurrectInputs()
        {
            button_Save.Enabled = !string.IsNullOrEmpty(textBox_Name.Text);
        }

        private void textBox_Name_TextChanged(object sender, System.EventArgs e) => CheckCurrectInputs();
        private void comboBox_Material_SelectedIndexChanged(object sender, System.EventArgs e) => CheckCurrectInputs();
        private void comboBox_Type_SelectedIndexChanged(object sender, System.EventArgs e) => CheckCurrectInputs();
        private void comboBox_CleaningOrder_SelectedIndexChanged(object sender, System.EventArgs e) => CheckCurrectInputs();

        private void ThingSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thing.Name = textBox_Name.Text;
            Thing.Material = ((Material)comboBox_Material.SelectedItem).Name;
            Thing.Type = ((Type)comboBox_Type.SelectedItem).Name;
            Thing.CleaningOrder = ((CleaningOrder)comboBox_CleaningOrder.SelectedItem).ID;
        }
        private void button_Save_Click(object sender, System.EventArgs e) => this.DialogResult = DialogResult.OK;
    }
}
