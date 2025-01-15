using DemoPosuda.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DemoPosuda.Contrrols
{
    public partial class UserControlTovar : UserControl
    {
        private Tovar tovar { get; set; }
        public UserControlTovar(Tovar tovar = null)
        {
            InitializeComponent();

            this.tovar = tovar;

            SetData();
        }

        private void SetData()
        {
            labelNameTovar.Text = tovar.TovarName.name_tovar;
            labelPriseTovar.Text = tovar.cost_tovar.ToString();
            labelDeckTovar.Text = tovar.deck_tovar;
            labelKolSclad.Text = tovar.kolvo_tovar.ToString();
            labelProizvTovar.Text = tovar.Proizvod.name_proizvod;

            var picPath = tovar.image_tovar;

            var path = Path.GetDirectoryName(picPath);

            if (picPath == null)
            {
                pictureBoxTovar.Image = Properties.Resources.picture;
                return;
            }

            pictureBoxTovar.Image = Image.FromFile($@"C:\Users\1101-22\Desktop\DemoPosuda\DemoPosuda\TovarImage\{tovar.image_tovar}");
        }
    }
}
