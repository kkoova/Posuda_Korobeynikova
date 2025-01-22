using DemoPosuda.Models;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.Forms
{
    /// <summary>
    /// Форма добавление товара <see cref="AddTovar"/>
    /// </summary>
    public partial class AddTovar : Form
    {
        private readonly Tovar tovar;

        /// <summary>
        /// Конструктор
        /// </summary>
        public AddTovar(Tovar tovar = null)
        {
            InitializeComponent();

            this.tovar = tovar;
            Combobox();
            if (tovar != null) UpdateTovar();
        }

        /// <summary>
        /// Добавление данных для <see cref="ComboBox"/> на форме
        /// </summary>
        private void Combobox()
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var name = context.TovarName.ToList();
                var categoty = context.TovarCategory.ToList();
                var post = context.Postavchik.ToList();
                var proizv = context.Proizvod.ToList();

                comboBoxName.DataSource = name;
                comboBoxName.DisplayMember = "name_tovar";
                comboBoxName.ValueMember = "id";

                comboBoxCategoty.DataSource = categoty;
                comboBoxCategoty.DisplayMember = "kategory_tovar";
                comboBoxCategoty.ValueMember = "id";

                comboBoxPostavchik.DataSource = post;
                comboBoxPostavchik.DisplayMember = "name_post";
                comboBoxPostavchik.ValueMember = "id";

                comboBoxProizvod.DataSource = proizv;
                comboBoxProizvod.DisplayMember = "name_proizvod";
                comboBoxProizvod.ValueMember = "id";
            }
        }

        /// <summary>
        /// Вставка данных для последующего обновления
        /// </summary>
        private void UpdateTovar()
        {
            Text = "Обновление товара";
            buttonAdd.Text = "Обновить товар";

            comboBoxName.SelectedValue = tovar.id_name_tovar;
            comboBoxCategoty.SelectedValue = tovar.id_kategiry_tovar;
            numericUpDownColVo.Value = Convert.ToDecimal(tovar.kolvo_tovar);
            textBoxEdIS.Text = tovar.ediz_tovar;
            comboBoxPostavchik.SelectedValue = tovar.id_poctavchik_tovar;
            textBoxCost.Text = tovar.cost_tovar.ToString();
            textBoxDeck.Text = tovar.deck_tovar;
            buttonImage.Text = tovar.image_tovar;
            comboBoxProizvod.SelectedValue = tovar.id_proizvod_tovar;
        }

        /// <summary>
        /// Валидация формы для добавления или редактирования товара
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach(var control in this.Controls)
            {
                if (control is TextBox textBox 
                    && string.IsNullOrWhiteSpace(textBox.Text)) 
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            AddOrUpdateTovarNew();
        }

        /// <summary>
        /// Добавление или редактирование товара
        /// </summary>
        private void AddOrUpdateTovarNew()
        {
            var name = Convert.ToInt16(comboBoxName.SelectedValue);
            var kat = Convert.ToInt16(comboBoxCategoty.SelectedValue);
            var kolVo = Convert.ToDouble(numericUpDownColVo.Value);
            var edIs = textBoxEdIS.Text;
            var postav = Convert.ToInt16(comboBoxPostavchik.SelectedValue);
            var cost = Convert.ToDouble(textBoxCost.Text);
            var deck = textBoxDeck.Text;
            var image = buttonImage.Text;
            var proizv = Convert.ToInt16(comboBoxProizvod.SelectedValue);

            using (var context = new KorobeynikovaPosudaEntities())
            {
                if (tovar == null)
                {
                    var newTovar = new Tovar
                    {
                        id_name_tovar = name,
                        ediz_tovar = edIs,
                        cost_tovar = cost,
                        id_poctavchik_tovar = postav,
                        id_kategiry_tovar = kat,
                        kolvo_tovar = kolVo,
                        deck_tovar = deck,
                        image_tovar = image,
                        id_proizvod_tovar = proizv,
                    };

                    context.Tovar.Add(newTovar);
                }
                else
                {
                    var upTovar = context.Tovar.Find(tovar.articyl_tovar);

                    upTovar.id_name_tovar = name;
                    upTovar.ediz_tovar = edIs;
                    upTovar.cost_tovar = cost;
                    upTovar.id_poctavchik_tovar = postav;
                    upTovar.id_kategiry_tovar = kat;
                    upTovar.kolvo_tovar = kolVo;
                    upTovar.deck_tovar = deck;
                    upTovar.image_tovar = image;
                    upTovar.id_proizvod_tovar = proizv;
                }

                context.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Добавление и загрузка изображения
        /// </summary>
        private void buttonImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                string selectImage = openFileDialogImage.FileName;

                buttonImage.Text = $"{Path.GetFileName(selectImage)}";

                string projectPath = Path.GetDirectoryName(AppContext.BaseDirectory);

                string imagesFolder = Path.Combine(projectPath, "TovarImage");

                try
                {
                    File.Copy(selectImage, Path.Combine(imagesFolder, Path.GetFileName(selectImage)), true);
                    MessageBox.Show("Изоброажение добавленно", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка добавления изображения: {ex.Message}", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
