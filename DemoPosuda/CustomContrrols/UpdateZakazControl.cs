using DemoPosuda.Models;
using System.Windows.Forms;

namespace DemoPosuda.CustomContrrols
{
    public partial class UpdateZakazControl : UserControl
    {
        Zakaz zakaz;

        public UpdateZakazControl(Zakaz zakaz)
        {
            InitializeComponent();
            this.zakaz = zakaz;
            SetDataToControllsZakaz();
        }

        private void SetDataToControllsZakaz()
        {
            labelArticul.Text = zakaz.Tovar.articyl_tovar.ToString();
            labelKolvo.Text = zakaz.kolvo_tovar_in_zakaz.ToString();
            labelDataStart.Text = zakaz.data_zakaz.ToString();
            labelDataEnd.Text = zakaz.data_dostav_zakaz.ToString();
            labelPunct.Text = zakaz.Punkt.index_punkt.ToString();
            labelFIO.Text = zakaz.Clietn.name_client;
         }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var zakStat = context.Zakaz.Find(zakaz.id);

                zakaz.id_state_zakaz = 3;

                context.SaveChanges();
            }
        }
    }
}
