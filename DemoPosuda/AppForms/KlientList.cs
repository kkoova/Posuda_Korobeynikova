using DemoPosuda.CustomContrrols;
using DemoPosuda.Models;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.AppForms
{
    public partial class KlientList : Form
    {
        public KlientList()
        {
            InitializeComponent();
            SetConrlossClient();
        }

        public void SetConrlossClient()
        {
            flowLayoutPanelKlient.Controls.Clear();

            using (var context = new KorobeynikovaPosudaEntities())
            {
                var client = context.Clietn.ToList();

                foreach (var item in client)
                {
                    var clientNew = new KlientControl(item, this);
                    flowLayoutPanelKlient.Controls.Add(clientNew);
                }
            }
        }

        private void buttoRegKlirnt_Click(object sender, System.EventArgs e)
        {
            using (var newKlient = new AddAndUpdatKlientForm()) 
            {
                if (newKlient.ShowDialog() == DialogResult.OK) 
                {
                    MessageBox.Show("Вы добавили пользователя!");
                    SetConrlossClient();
                }
            }
        }
    }
}
