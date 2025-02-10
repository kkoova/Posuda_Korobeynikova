using DemoPosuda.AppForms;
using DemoPosuda.Models;
using System.Windows.Forms;

namespace DemoPosuda.CustomContrrols
{
    /// <summary>
    /// Обновление заказов менеджером
    /// </summary>
    public partial class UpdateZakazControl : UserControl
    {
        Zakaz zakaz;
        HistoryZakaz historyZakaz;

        /// <summary>
        /// ктор
        /// </summary>
        public UpdateZakazControl(Zakaz zakaz, HistoryZakaz historyZakaz)
        {
            InitializeComponent();
            this.zakaz = zakaz;
            this.historyZakaz = historyZakaz;
            SetDataToControllsZakaz();
        }

        /// <summary>
        /// Заполнение полей
        /// </summary>
        private void SetDataToControllsZakaz()
        {
            labelArticul.Text = zakaz.Tovar.articyl_tovar.ToString();
            labelKolvo.Text = zakaz.kolvo_tovar_in_zakaz.ToString();
            labelDataStart.Text = zakaz.data_zakaz.ToString();
            labelDataEnd.Text = zakaz.data_dostav_zakaz.ToString();
            labelPunct.Text = zakaz.Punkt.index_punkt.ToString();
            labelFIO.Text = zakaz.Clietn.name_client;
         }

        /// <summary>
        /// Обновление заказа
        /// </summary>
        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var zakStat = context.Zakaz.Find(zakaz.id);

                zakStat.id_state_zakaz = 3;

                context.SaveChanges();
            }

            MessageBox.Show("Вы подтвердили заказ!");
            historyZakaz.SetDataClientHisstoryNoDone();
        }
    }
}
