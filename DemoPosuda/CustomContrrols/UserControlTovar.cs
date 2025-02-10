using DemoPosuda.Forms;
using DemoPosuda.Logick;
using DemoPosuda.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoPosuda.Contrrols
{
    /// <summary>
    /// <see cref="UserControl"/> товара
    /// </summary>
    public partial class UserControlTovar : UserControl
    {
        private Tovar tovar { get; set; }
        private int role;
        Main main;

        /// <summary>
        /// Конструктор
        /// </summary>
        public UserControlTovar(Tovar tovar = null, int role = 4, Main main = null)
        {
            InitializeComponent();

            this.tovar = tovar;
            this.role = role;
            this.main = main;

            SetData();

            if (role == 1)
                buttonDellTovar.Visible = true;
            else if (role == 3)
                buttonAddToCart.Visible = true;
        }

        /// <summary>
        /// Установка значения по всему <see cref="UserControlTovar"/>
        /// </summary>
        private void SetData()
        {
            var sale = new SaleRachet();

            var costSale = sale.SaleSet(tovar);

            labelNameTovar.Text = tovar.TovarName.name_tovar;
            labelPriseTovar.Text = costSale.ToString();
            labelDeckTovar.Text = tovar.deck_tovar;
            labelKolSclad.Text = tovar.kolvo_tovar.ToString();
            labelProizvTovar.Text = tovar.Proizvod.name_proizvod;
            labelSale.Text = tovar.curent_sale_tovar.ToString();

            var picPath = tovar.image_tovar;

            var path = AppContext.BaseDirectory;

            if (picPath == null)
            {
                pictureBoxTovar.Image = Properties.Resources.picture;
                return;
            }

            try
            {
                pictureBoxTovar.Image = Image.FromFile($"{path}\\TovarImage\\{picPath}");
            }
            catch
            {
                MessageBox.Show("Ошибка изображения!");
            }
        }

        /// <summary>
        /// Попытка редакирования товара на форме <see cref="AddTovar"/>
        /// </summary>
        private void UserControlTovar_Click(object sender, EventArgs e)
        {
            if (role != 1) return;
                
            using (var edit = new AddTovar(tovar))
            {
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Вы отредактировали товар!");
                    main.ShowTovar();
                }
            }
        }

        /// <summary>
        /// Обновление списка выбранных товаров
        /// </summary>
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            main.UpdateCountTovar(tovar);
        }
    }
}
