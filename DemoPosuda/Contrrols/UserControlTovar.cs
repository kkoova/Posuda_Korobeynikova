using DemoPosuda.Data;
using DemoPosuda.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.Contrrols
{
    public partial class UserControlTovar : UserControl
    {
        private Tovar tovar { get; set; }
        public UserControlTovar(Tovar tovar = null, string role = null)
        {
            InitializeComponent();

            this.tovar = tovar;

            SetData();

            if (role == "Администратор")
                buttonDellTovar.Enabled = true;
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

        private void buttonDellTovar_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удаить этот товар?", "удаление",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return; 

            using (var context = new KorobeynikovaPosudaEntities())
            {
                var booll = context.Zakaz
                    .Where(id => id.id_artic_zakaz == tovar.articyl_tovar)
                    .ToList();

                if (booll.Count != 0)
                {
                    MessageBox.Show("Этот товар уже заказали!", "Ошикбка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var delTovar = context.Tovar.Find(tovar.articyl_tovar);

                context.Tovar.Remove(delTovar);

                context.SaveChanges();

                MessageBox.Show("Вы удалили товар!. Обновите страницу");
            }

        }

        private void UserControlTovar_Click(object sender, System.EventArgs e)
        {
            using (var addTovar = new AddTovar(tovar))
            {
                if (addTovar.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Вы успешшно отредактировали товар", "Успех");

                    using (var context = new KorobeynikovaPosudaEntities())
                    {
                        tovar = context.Tovar.Find(tovar.articyl_tovar);
                        SetData();
                    }
                }
            }
        }
    }
}
