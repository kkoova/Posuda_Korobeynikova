using DemoPosuda.AppForms;
using DemoPosuda.Models;
using System.Windows.Forms;

namespace DemoPosuda.CustomContrrols
{
    public partial class KlientControl : UserControl
    {
        private readonly Clietn client;
        public KlientControl(Clietn clietn)
        {
            InitializeComponent();

            this.client = clietn;

            SetDataClient();
        }

        private void SetDataClient()
        {
            labelYypeClient.Text = client.TypeClient.type_client;
            labelNameClient.Text = client.name_client;
            labelDirector.Text = client.directort_client;
            labelEmail.Text = client.email_client;
            labelPhone.Text = client.phone_client;
            labelIndex.Text = client.index_client.ToString();
            labelINN.Text = client.inn_client.ToString();
            labelRate.Text = client.rate_client.ToString();
        }

        private void buttonHistory_Click(object sender, System.EventArgs e)
        {
            var historyZakazClient = new HistoryZakaz(client);
            historyZakazClient.ShowDialog();
        }
    }
}
