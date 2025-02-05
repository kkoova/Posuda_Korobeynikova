using DemoPosuda.Models;
using System.Windows.Forms;

namespace DemoPosuda.CustomContrrols
{
    public partial class ZakazControl : UserControl
    {
        Zakaz zakaz;

        public ZakazControl(Zakaz zakaz)
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
            labelStatus.Text = zakaz.Status.name_state;
         }
    }
}
