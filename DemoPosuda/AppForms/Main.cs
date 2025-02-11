using DemoPosuda.AppForms;
using DemoPosuda.Contrrols;
using DemoPosuda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.Forms
{
    /// <summary>
    /// Главная фома приложения <see cref="Main"/>
    /// </summary>
    public partial class Main : Form
    {
        public Sotrydnik user;
        public int userRole;
        public List<Tovar> tovarList;
        public List<Tovar> tovarClientList = new List<Tovar>();

        /// <summary>
        /// Конструктор
        /// </summary>
        public Main(Sotrydnik user = null)
        {
            InitializeComponent();

            this.user = user;

            AddUserLogin();

            ComboboxProizv();

            ShowTovar();
        }

        /// <summary>
        /// Отображение количества товаров
        /// </summary>
        private void SetCurrentCountTovar()
        {
            if (tovarClientList != null)
            {
                if (tovarClientList.Count > 0 && userRole == 3)
                {
                    labelKolvoToar.Visible = true;
                    labelKolvoToar.Text = tovarClientList.Count.ToString();
                }
                else
                    labelKolvoToar.Visible = false;
            }
            else
                labelKolvoToar.Visible = false;
        }

        /// <summary>
        /// Определение роли ползователя
        /// </summary>
        private void AddUserLogin()
        {
            if (user != null)
            {
                userRole = Convert.ToInt16(user.id_role_sotr);

                labelUserFio.Text = user.fio_sotr;

                if (userRole == 1)
                {
                    AddТоварToolStripMenuItem.Enabled = true;
                    просмотрПользователейToolStripMenuItem.Enabled = false;
                    pfToolStripMenuItem.Enabled = false;
                    pictureBoxCan.Visible = false;
                    labelUserFio.Text += " Администратор";
                }
                else if (userRole == 2) 
                {
                    AddТоварToolStripMenuItem.Enabled = false;
                    pfToolStripMenuItem.Enabled = true;
                    pictureBoxCan.Visible = false;
                    просмотрПользователейToolStripMenuItem.Enabled = true;
                    labelUserFio.Text += " Менеджер";
                }
                else if (userRole == 3)
                {
                    labelUserFio.Text += " Клиент";
                    pictureBoxCan.Visible = true;
                    AddТоварToolStripMenuItem.Enabled = false;
                    pfToolStripMenuItem.Enabled = false;
                    просмотрПользователейToolStripMenuItem.Enabled = false;
                }

            }
            else
            {
                AddТоварToolStripMenuItem.Enabled = false;
                pictureBoxCan.Visible = false;
                pfToolStripMenuItem.Enabled = false;
                просмотрПользователейToolStripMenuItem.Enabled = false;
                labelUserFio.Text = "Гость";
            }
        }

        /// <summary>
        /// Вывод статистики
        /// </summary>
        public void Stats()
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var all = context.Tovar.Count();

                labelStats.Text = $"{tovarList.Count}/{all}";
            }
        }

        /// <summary>
        /// Заполнение <see cref="ComboboxProizv"/>
        /// </summary>
        public void ComboboxProizv()
        {
            comboBoxProizvod.SelectedIndex = -1;
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var proizvod = context.Proizvod.ToList();

                comboBoxProizvod.Items.Add("Все производители");

                foreach (var item in proizvod)
                {
                    comboBoxProizvod.Items.Add(item.name_proizvod);
                }
            }
        }

        /// <summary>
        /// Показ списка товаров
        /// </summary>
        private void ShowToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowTovar();
        }

        /// <summary>
        /// Выход из аккаунта пользователя
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var sing = new SingIn())
            {
                if (sing.ShowDialog() == DialogResult.OK)
                {
                    var user = sing.ReturnedValue;
                    this.user = user;
                }
            }

            AddUserLogin();
            ShowTovar();
        }

        /// <summary>
        /// Применение фильтра
        /// </summary>
        private void textBoxFindName_TextChanged(object sender, System.EventArgs e)
        {
            var text = textBoxFindName.Text;
            ApplyFilters(text);
        }

        /// <summary>
        /// Применение фильтра
        /// </summary>
        public void ShowTovar()
        {
            ApplyFilters();
        }

        /// <summary>
        /// Применение фильтра
        /// </summary>
        private void radioButtonUp_CheckedChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        /// <summary>
        /// Применение фильтра
        /// </summary>
        private void radioButtonDown_CheckedChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        /// <summary>
        /// Поиск товаров с фильтрацией
        /// </summary>
        private void ApplyFilters(string findText = null)
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var query = context.Tovar.AsQueryable();

                if (!string.IsNullOrEmpty(findText))
                {
                    query = query
                        .Where(x => x.TovarName.name_tovar.ToLower().StartsWith(findText.ToLower()));
                }

                if (radioButtonDown.Checked)
                {
                    query = query
                    .OrderByDescending(t => t.cost_tovar);
                }

                if (radioButtonUp.Checked)
                {
                    query = query
                    .OrderBy(t => t.cost_tovar);
                }

                if (comboBoxProizvod.SelectedIndex > 0)
                {
                    var proizvod = comboBoxProizvod.Text;

                    query = query
                    .Where(p => p.Proizvod.name_proizvod.Equals(proizvod));
                }

                tovarList = query.ToList();

                FlowShow();
            }
        }

        /// <summary>
        /// Применение фильтра
        /// </summary>
        private void comboBoxProizvod_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        /// <summary>
        /// Вывод списка товараов в виде <see cref="UserControlTovar"/>
        /// </summary>
        public void FlowShow()
        {
            flowLayoutPanelTovar.Controls.Clear();

            foreach (var item in tovarList)
            {
                var tovar = new UserControlTovar(item, userRole, this);

                flowLayoutPanelTovar.Controls.Add(tovar);
            }

            Stats();
        }

        /// <summary>
        /// Обработка добавлении товара с формы <see cref="AddTovar"/>
        /// </summary>
        private void AddТоварToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var addTovar = new AddTovar())
            {
                if (addTovar.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Вы успешшно добавили товар", "Успех");
                }
            }

            ShowTovar();
        }

        /// <summary>
        /// Форма просмотра пользователей
        /// </summary>
        private void просмотрПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var klient = new KlientList();
            klient.ShowDialog();
        }

        /// <summary>
        /// Обновление количества товаров
        /// </summary>
        public void UpdateCountTovar(Tovar tovar)
        {
            tovarClientList.Add(tovar);
            SetCurrentCountTovar();
        }

        /// <summary>
        /// Форма корзины
        /// </summary>
        private void pictureBoxCan_Click(object sender, EventArgs e)
        {
            var canForm = new CanForm(tovarClientList, user);
            if (canForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вы оформили заказ!");
                tovarClientList.Clear();
                SetCurrentCountTovar();
            }
        }

        /// <summary>
        /// Форма для подтверджения заказов
        /// </summary>
        private void подтвердитьЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newGistForm = new HistoryZakaz();
            newGistForm.ShowDialog();
        }
    }
}
