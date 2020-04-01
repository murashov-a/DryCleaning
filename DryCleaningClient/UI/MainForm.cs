using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DryCleaningAPI.API.Responses;
using DryCleaningAPI.Extensions;
using DryCleaningClient.API.Responses;
using DryCleaningClient.UI.Settings;

namespace DryCleaningClient.UI
{
    public partial class MainForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;

        /// <summary>
        /// Modified Results
        /// </summary>
        public BindingList<CleaningOrder> CleaningOrders { get; private set; } = new BindingList<CleaningOrder>();
        public BindingList<Cleaning> Cleanings { get; private set; } = new BindingList<Cleaning>();


        public BindingList<Thing> Things = new BindingList<Thing>();
        public BindingList<Thing> CleaningThings = new BindingList<Thing>();

        public MainForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            CleaningOrders = new BindingList<CleaningOrder>(_client.CleaningOrders.GetCleaningOrders());
            Cleanings = new BindingList<Cleaning>(_client.Cleanings.GetCleanings());
            InitializeComponent();

            olvColumn_OrderEmployee.AspectGetter = delegate (object objCleaningOrder)
            {
                if (objCleaningOrder is CleaningOrder cleaningOrder)
                {
                    var selectedUser = _client.Users.GetUser(cleaningOrder.Employee);
                    return selectedUser.Name;
                }
                return null;
            };
            olvColumn_CleaningEmployee.AspectGetter = delegate(object objCleaning)
            {
                if (objCleaning is Cleaning cleaning)
                {
                    var selectedUser = _client.Users.GetUser(cleaning.Employee);
                    return selectedUser.Name;
                }
                return null;
            };
            olvColumn_Client.AspectGetter = delegate (object objCleaningOrder)
            {
                if (objCleaningOrder is CleaningOrder cleaningOrder)
                {
                    var selectedClient = _client.Clients.GetClient(cleaningOrder.Client);
                    return selectedClient.Name;
                }
                return null;
            };
            olvColumn_ActualTerm.AspectGetter = delegate (object objCleaningOrder)
            {
                if (objCleaningOrder is CleaningOrder cleaningOrder)
                {
                    return cleaningOrder.ActualTerm?.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT);
                }
                return null;
            };
            olvColumn_DateOfReceipt.AspectGetter = delegate (object objCleaningOrder)
            {
                if (objCleaningOrder is CleaningOrder cleaningOrder)
                {
                    return cleaningOrder.DateOfReceipt.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT);
                }
                return null;
            };
            olvColumn_DateOfReturn.AspectGetter = delegate (object objCleaningOrder)
            {
                if (objCleaningOrder is CleaningOrder cleaningOrder)
                {
                    return cleaningOrder.DateOfReturn?.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT);
                }
                return null;
            };
            olvColumn_TargetTerm.AspectGetter = delegate (object objCleaningOrder)
            {
                if (objCleaningOrder is CleaningOrder cleaningOrder)
                {
                    return cleaningOrder.TargetTerm.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT);
                }
                return null;
            };
            olvColumn_Date.AspectGetter = delegate (object objCleaning)
            {
                if (objCleaning is Cleaning cleaning)
                {
                    return cleaning.Date.ToString(SqliteDateTimeConverter.SQLITE_DATE_FORMAT);
                }
                return null;
            };

            UpdateCleaningOrdersList();
            UpdateCleaningsList();
        }

        private void UpdateCleaningOrdersList()
        {
            CleaningOrders = new BindingList<CleaningOrder>(_client.CleaningOrders.GetCleaningOrders());
            objectListView_Orders.SetObjects(CleaningOrders);
        }
        private void UpdateCleaningsList()
        {
            Cleanings = new BindingList<Cleaning>(_client.Cleanings.GetCleanings());
            objectListView_Cleanings.SetObjects(Cleanings);
        }
        private void UpdateThingsList(CleaningOrder cleaningOrder)
        {
            UpdateThingsList(cleaningOrder.ID);
        }
        private void UpdateThingsList(int cleaningOrderID)
        {
            Things.Clear();
            foreach (var thing in _client.Things.GetThings().Where(x => x.CleaningOrder == cleaningOrderID).ToArray())
            {
                Things.Add(thing);
            }
            objectListView_Things.SetObjects(Things);
        }

        /// <summary>
        /// Настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var currentUser = _client.Users.GetCurrentUser();
            var userSettingsForm = new UserSettingsForm(currentUser, _client);
            if (userSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Users.Edit(currentUser.PassportID, userSettingsForm.User); //.EditCurrentUser(userSettingsForm.User);
                if (!currentUser.PassportID.Equals(userSettingsForm.User.PassportID))
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e) => this.Close();

        private void nameToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e) => uSERNAMEToolStripMenuItem.Text = $"{_client.Users.GetCurrentUser().Name}";

        private void сотрудникиToolStripMenuItem_Click(object sender, System.EventArgs e) => new UsersForm(_client).ShowDialog();

        private void клиентыToolStripMenuItem_Click(object sender, System.EventArgs e) => new ClientsForm(_client).ShowDialog();

        private void материалыToolStripMenuItem_Click(object sender, System.EventArgs e) => new MaterialsForm(_client).ShowDialog();

        private void типыВещейToolStripMenuItem_Click(object sender, System.EventArgs e) => new TypesForm(_client).ShowDialog();

        private void результатыToolStripMenuItem_Click(object sender, System.EventArgs e) => new ResultsForm(_client).ShowDialog();

        private void химСредстваcommingSoonToolStripMenuItem_Click(object sender, System.EventArgs e) => new ChemicalAgentsForm(_client).ShowDialog();

        private void button_OrderAdd_Click(object sender, System.EventArgs e)
        {
            var cleaningOrder = _client.CleaningOrders.Add(DateTime.Now, DateTime.Now,
                _client.Users.GetCurrentUser().PassportID, _client.Clients.GetClients().First().ID);

            var cleaningOrderSettingsForm = new CleaningOrderSettingsForm(cleaningOrder, _client);
            if (cleaningOrderSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.CleaningOrders.Edit(cleaningOrder.ID, cleaningOrderSettingsForm.CleaningOrder);
                UpdateCleaningOrdersList();
            }
            else
            {
                _client.CleaningOrders.Delete(cleaningOrder);
            }
        }

        private void button_OrderEdit_Click(object sender, System.EventArgs e)
        {
            if (objectListView_Orders.SelectedObject is CleaningOrder cleaningOrder)
            {
                var cleaningOrderSettingsForm = new CleaningOrderSettingsForm(cleaningOrder, _client);
                if (cleaningOrderSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.CleaningOrders.Edit(cleaningOrder.ID, cleaningOrderSettingsForm.CleaningOrder);
                    UpdateCleaningOrdersList();
                }
            }
        }

        private void button_OrderDelete_Click(object sender, System.EventArgs e)
        {
            if (objectListView_Orders.SelectedObject is CleaningOrder сleaningOrder)
            {
                if (MessageBox.Show($"Удалить заказ?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.CleaningOrders.Delete(сleaningOrder);
                    UpdateCleaningOrdersList();
                }
            }
        }

        private void objectListView_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView_Orders.SelectedObject is CleaningOrder cleaningOrder)
            {
                UpdateThingsList(cleaningOrder);
            }

            CanOrderEditCheckAndBlockButton();
        }

        private void button_ThingDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_Things.SelectedObject is Thing thing)
            {
                if (MessageBox.Show($"Удалить вещь '{thing.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Things.Delete(thing);
                    UpdateThingsList(thing.CleaningOrder);
                }
            }
        }

        private void button_ThingEdit_Click(object sender, EventArgs e)
        {
            if (objectListView_Things.SelectedObject is Thing thing)
            {
                var thingSettingsForm = new ThingSettingsForm(thing, _client);
                if (thingSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Things.Edit(thing.ID, thingSettingsForm.Thing);
                    UpdateThingsList(thing.CleaningOrder); //update current selected cleaning order! not new cleaning order
                }
            }
        }

        private void objectListView_Things_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            CanThingEditCheckAndBlockButton();
        }

        private void objectListView_Things_SelectedIndexChanged(object sender, EventArgs e)
        {
            CanThingEditCheckAndBlockButton();
        }

        void CanThingEditCheckAndBlockButton()
        {
            button_ThingEdit.Enabled = button_ThingDelete.Enabled = objectListView_Things.SelectedObject is Thing;
        }
        void CanOrderEditCheckAndBlockButton()
        {
            button_ThingAdd.Enabled = button_OrderEdit.Enabled = button_OrderDelete.Enabled = objectListView_Orders.SelectedObject is CleaningOrder;
        }

        private void objectListView_Orders_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            CanOrderEditCheckAndBlockButton();
        }

        private void button_ThingAdd_Click(object sender, EventArgs e)
        {
            var thing = _client.Things.Add("new thing", _client.Materials.GetMaterials().First().Name,
                _client.Types.GetTypes().First().Name, ((CleaningOrder)objectListView_Orders.SelectedObject).ID);

            var thingSettingsForm = new ThingSettingsForm(thing, _client);
            if (thingSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Things.Edit(thing.ID, thingSettingsForm.Thing);
                UpdateThingsList(thing.CleaningOrder);
            }
            else
            {
                _client.Things.Delete(thing);
            }
        }

        private void objectListView_Cleanings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView_Cleanings.SelectedObject is Cleaning cleaning)
            {
                UpdateCleaningThingsList(cleaning);
            }

            CanCleaningEditCheckAndBlockButton();
        }

        void CanCleaningEditCheckAndBlockButton()
        {
            button_ThingCleaningAdd.Enabled = button_EditCleaning.Enabled = button_DeleteCleaning.Enabled = objectListView_Cleanings.SelectedObject is Cleaning;
        }

        private void UpdateCleaningThingsList(Cleaning cleaning)
        {
            UpdateCleaningThingsList(cleaning.ID);
        }

        private int lastSelectCleaningID;
        private void UpdateCleaningThingsList(int cleaningID)
        {
            lastSelectCleaningID = cleaningID;

            CleaningThings.Clear();
            var cleanings = _client.CleaningsThings.GetCleanings();
            foreach (var cleaningThing in cleanings.Where(x => x.CleaningID == cleaningID))
            {
                CleaningThings.Add(_client.Things.Get(cleaningThing.ThingID));
            }
            objectListView_CleaningThings.SetObjects(CleaningThings);
        }

        private void button_DeleteCleaning_Click(object sender, EventArgs e)
        {
            if (objectListView_Cleanings.SelectedObject is Cleaning cleaning)
            {
                if (MessageBox.Show($"Удалить чистку?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Cleanings.Delete(cleaning);
                    UpdateCleaningsList();
                }
            }
        }

        private void button_EditCleaning_Click(object sender, EventArgs e)
        {
            if (objectListView_Cleanings.SelectedObject is Cleaning cleaning)
            {
                var cleaningSettingsForm = new CleaningSettingsForm(cleaning, _client);
                if (cleaningSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Cleanings.Edit(cleaning.ID, cleaningSettingsForm.Cleaning);
                    UpdateCleaningsList();
                }
            }
        }

        private void button_AddCleaning_Click(object sender, EventArgs e)
        {
            var cleaning = _client.Cleanings.Add(DateTime.Now, _client.Results.GetResults().First().Name,
                _client.Users.GetCurrentUser().PassportID, _client.ChemicalAgent.GetChemicalAgents().First().Name);

            var cleaningSettingsForm = new CleaningSettingsForm(cleaning, _client);
            if (cleaningSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Cleanings.Edit(cleaning.ID, cleaningSettingsForm.Cleaning);
                UpdateCleaningsList();
            }
            else
            {
                _client.Cleanings.Delete(cleaning);
            }
        }

        private void button_ThingCleaningAdd_Click(object sender, EventArgs e)
        {
            var cleaningThingsSettings = new CleaningThingsSettings(_client, objectListView_CleaningThings.Objects?.Cast<Thing>());
            if (cleaningThingsSettings.ShowDialog() == DialogResult.OK)
            {
                List<CleaningThing> cleaningThings = new List<CleaningThing>();
                foreach (var checkedThing in cleaningThingsSettings.CheckedThings)
                {
                    cleaningThings.Add(new CleaningThing() { CleaningID = lastSelectCleaningID, ThingID = checkedThing.ID});
                }
                _client.CleaningsThings.Add(cleaningThings);
                UpdateCleaningThingsList(lastSelectCleaningID);
            }
        }

        private void button_ThingCleaningDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_CleaningThings.SelectedObject is Thing thing)
            {
                if (MessageBox.Show($"Удалить чистку вещь '{thing.Name}' из чистки №{lastSelectCleaningID}?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.CleaningsThings.Delete(lastSelectCleaningID, thing.ID);
                    UpdateCleaningThingsList(lastSelectCleaningID);
                }
            }
        }

        private void objectListView_CleaningThings_SelectedIndexChanged(object sender, EventArgs e)
        {
            CanCleaningThingsEditCheckAndBlockButton();
        }
        void CanCleaningThingsEditCheckAndBlockButton()
        {
            button_ThingCleaningDelete.Enabled = objectListView_CleaningThings.SelectedObject is Thing;
        }
    }
}
