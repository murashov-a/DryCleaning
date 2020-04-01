using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DryCleaningAPI.API.Responses;
using DryCleaningAPI.Extensions;

namespace DryCleaningClient.UI.Settings
{
    public partial class CleaningThingsSettings : Form
    {
        /// <summary>
        /// Selected things
        /// </summary>
        public BindingList<Thing> AllThings { get; private set; }
        public BindingList<Thing> CheckedThings { get; private set; }

        private readonly DryCleaningAPI.DryCleaningClient _client;
        public CleaningThingsSettings(DryCleaningAPI.DryCleaningClient dryCleaningClient, IEnumerable<Thing> selectedThings = null)
        {
            _client = dryCleaningClient;
            InitializeComponent();

            AllThings = new BindingList<Thing>(_client.Things.GetThings());

            objectListView_Things.SetObjects(AllThings.Except(selectedThings));
            objectListView_Things.Update();

            olvColumn_CleaningOrder.AspectGetter += delegate(object thingObj)
            {
                if (thingObj is Thing thing)
                {
                    var cleaningOrder = _client.CleaningOrders.GetCleaningOrders().First(x => x.ID == thing.CleaningOrder);
                    var user = _client.Users.GetUser(cleaningOrder.Employee);
                    var client = _client.Clients.GetClient(cleaningOrder.Client);
                    return $"Заказ №{cleaningOrder.ID} Получен: {cleaningOrder.DateOfReceipt.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT)} Сотрудник: {user.Name} Клиент: {client.Name}";
                }
                return null;
            };
            objectListView_Things.BuildGroups(olvColumn_CleaningOrder, SortOrder.Ascending);

        }

        private void CleaningThingsSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckedThings = new BindingList<Thing>(objectListView_Things.CheckedObjects.Cast<Thing>().ToArray());
        }

        private void button_Ok_Click(object sender, System.EventArgs e) => this.DialogResult = DialogResult.OK;
    }
}
