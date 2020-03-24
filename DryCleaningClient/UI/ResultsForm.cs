using System;
using System.ComponentModel;
using System.Windows.Forms;
using DryCleaningClient.API.Responses;

namespace DryCleaningClient.UI
{
    public partial class ResultsForm : Form
    {
        private readonly DryCleaningAPI.DryCleaningClient _client;

        /// <summary>
        /// Modified Results
        /// </summary>
        public BindingList<Result> Results { get; private set; } = new BindingList<Result>();

        public ResultsForm(DryCleaningAPI.DryCleaningClient client)
        {
            _client = client;
            Results = new BindingList<Result>(_client.Results.GetResults());

            InitializeComponent();

            UpdateResultsList();
        }

        private void UpdateResultsList()
        {
            Results = new BindingList<Result>(_client.Results.GetResults());
            objectListView_Results.SetObjects(Results);
            objectListView_Results.Update();
        }

        private void button_ResultAdd_Click(object sender, EventArgs e)
        {
            var result = Result.Default;
            var resultSettingsForm = new ResultSettingsForm(result);
            if (resultSettingsForm.ShowDialog() == DialogResult.OK)
            {
                _client.Results.Add(resultSettingsForm.Result);
                UpdateResultsList();
            }
        }

        private void button_ResultEdit_Click(object sender, EventArgs e)
        {
            if (objectListView_Results.SelectedObject is Result result)
            {
                var resultSettingsForm = new ResultSettingsForm(result);
                if (resultSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _client.Results.Edit(result.Name, resultSettingsForm.Result);
                    UpdateResultsList();
                }
            }
        }

        private void button_ResultDelete_Click(object sender, EventArgs e)
        {
            if (objectListView_Results.SelectedObject is Result result)
            {
                if (MessageBox.Show($"Удалить результат '{result.Name}'?", "Подтверждение", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _client.Results.Delete(result);
                    UpdateResultsList();
                }
            }
        }
    }
}
