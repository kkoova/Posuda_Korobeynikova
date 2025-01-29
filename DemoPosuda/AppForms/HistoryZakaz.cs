using DemoPosuda.Logick;
using DemoPosuda.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.AppForms
{
    /// <summary>
    /// Форма отоображения истории клиентов <see cref="HistoryZakaz"/>
    /// </summary>
    public partial class HistoryZakaz : Form
    {
        string client;

        /// <summary>
        /// Констркутор
        /// </summary>
        public HistoryZakaz()
        {
            InitializeComponent();

            Combo();

            ShowHistory();
        }

        /// <summary>
        /// Настройка <see cref="comboBoxClient"/>
        /// </summary>
        private void Combo()
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var clientist = context.Clietn.ToList();

                comboBoxClient.Items.Add("Все клиенты");
                foreach (var item in clientist)
                {
                    comboBoxClient.Items.Add(item.directort_client);
                }
            }
        }

        /// <summary>
        /// Показ историии в <see cref="dataGridViewHistory"/>
        /// </summary>
        private void ShowHistory()
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                if (client == null) 
                {
                    var zakazs = context.Zakaz
                    .Select(z => new
                    {
                        ФИО = z.Clietn.directort_client,
                        Рейтинг_клиента = z.Clietn.rate_client,
                        Дата_заказа = z.data_zakaz,
                        Сумма = z.Tovar.cost_tovar * z.kolvo_tovar_in_zakaz,
                        Пункт_выдачи = z.Punkt.index_punkt,
                        Статус_заказа = z.Status.name_state,
                    })
                    .ToList();

                    dataGridViewHistory.DataSource = zakazs;
                }
                else
                {
                    var zakazs = context.Zakaz
                    .Where(p => p.Clietn.directort_client == client)
                    .Select(z => new
                    {
                        ФИО = z.Clietn.directort_client,
                        Рейтинг_клиента = z.Clietn.rate_client,
                        Дата_заказа = z.data_zakaz,
                        Сумма = z.Tovar.cost_tovar * z.kolvo_tovar_in_zakaz,
                        Пункт_выдачи = z.Punkt.index_punkt,
                        Статус_заказа = z.Status.name_state,
                    })
                    .ToList();

                    dataGridViewHistory.DataSource = zakazs;
                }
            }
        }

        /// <summary>
        /// Настройка <see cref="comboBoxClient"/>
        /// </summary>
        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            client = comboBoxClient.Text;

            if (client == "Все клиенты") client = null;

            ShowHistory();

            if (client == "Все клиенты")
                buttonSaleChet.Enabled = false;
            else
                buttonSaleChet.Enabled = true;
        }

        /// <summary>
        /// Медот подсчета скидки заказчику
        /// </summary>
        private void buttonSaleChet_Click(object sender, EventArgs e)
        {
            var saleRas = new SaleRachetZakazchik();

            var result = saleRas.SaleRachet(client);

            MessageBox.Show($"Скидка для текущего Заказчика равна {result} %");
        }
    }
}
