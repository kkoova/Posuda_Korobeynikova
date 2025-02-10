using DemoPosuda.AppForms;
using DemoPosuda.Models;
using System.Windows.Forms;

namespace DemoPosuda.CustomContrrols
{
    /// <summary>
    /// 
    /// </summary>
    public partial class KlientControl : UserControl
    {
        Clietn client;
        KlientList klientList;

        /// <summary>
        /// ктор
        /// </summary>
        public KlientControl(Clietn clietn, KlientList klientList)
        {
            InitializeComponent();

            this.client = clietn;
            this.klientList = klientList;

            SetDataClient();
        }

        /// <summary>
        /// Заполнение полей
        /// </summary>
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

        /// <summary>
        /// ФОрма истории заказов
        /// </summary>
        private void buttonHistory_Click(object sender, System.EventArgs e)
        {
            var historyZakazClient = new HistoryZakaz(client);
            historyZakazClient.ShowDialog();
        }

        /// <summary>
        /// Форма редактирование клиента
        /// </summary>
        private void buttonEdit_Click(object sender, System.EventArgs e)
        {
            using (var formUpate = new AddAndUpdatKlientForm(client))
            {
                if (formUpate.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Вы успешно обновили пользователя!");
                    klientList.SetConrlossClient();
                }
            }
        }
    }
}
