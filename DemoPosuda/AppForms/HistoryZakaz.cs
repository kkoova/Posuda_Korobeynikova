using DemoPosuda.CustomContrrols;
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
        Clietn client;

        /// <summary>
        /// Констркутор
        /// </summary>
        public HistoryZakaz(Clietn clietn)
        {
            InitializeComponent();

            this.client = clietn;

            SetDataClientHisstory();
        }

        private void SetDataClientHisstory()
        {
            flowLayoutPanelZazaz.Controls.Clear();

            using(var context = new KorobeynikovaPosudaEntities())
            {
                var zakaz = context.Zakaz
                    .Where(c => c.id_name_client == client.id)
                    .ToList();

                foreach (var z in zakaz) {
                    var zalazNew = new ZakazControl(z);
                    flowLayoutPanelZazaz.Controls.Add(zalazNew);
                }
            }
        }
    }
}
