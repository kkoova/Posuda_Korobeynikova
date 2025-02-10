using DemoPosuda.CustomContrrols;
using DemoPosuda.Models;
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
        public HistoryZakaz(Clietn clietn = null)
        {
            InitializeComponent();

            this.client = clietn;

            if (client != null) 
            {
                SetDataClientHisstory();
            }
            else
            {
                SetDataClientHisstoryNoDone();
            }
            
        }

        /// <summary>
        /// Список заказов клиента
        /// </summary>
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

        /// <summary>
        /// Форма подтверждение заказа клиента
        /// </summary>
        public void SetDataClientHisstoryNoDone()
        {
            flowLayoutPanelZazaz.Controls.Clear();

            using (var context = new KorobeynikovaPosudaEntities())
            {
                var zakaz = context.Zakaz
                    .Where(c => c.id_state_zakaz == 2)
                    .ToList();

                foreach (var z in zakaz)
                {
                    var zalazNew = new UpdateZakazControl(z, this);
                    flowLayoutPanelZazaz.Controls.Add(zalazNew);
                }
            }
        }
    }
}
