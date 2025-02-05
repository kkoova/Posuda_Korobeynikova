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

        /// <summary>
        /// Конструктор
        /// </summary>
        public Main(Sotrydnik user = null)
        {
            InitializeComponent();

            this.user = user;

            AddUserLogin();

            ComboboxProizv();
        }

        /// <summary>
        /// Определение роли ползователя
        /// </summary>
        private void AddUserLogin()
        {
            if (user != null)
            {
                userRole = Convert.ToInt16(user.id_role_sotr);

                labelUserFio.Text = user.fio_sotr + user.RoleSotrudnik.role_sotr;

                if (userRole == 1)
                {
                    AddТоварToolStripMenuItem.Visible = true;
                    zakazToolStripMenuItem.Visible = true;
                }
                else if (userRole == 2) 
                {
                    AddТоварToolStripMenuItem.Visible = false;
                    zakazToolStripMenuItem.Visible = true;
                }

            }
            else
            {
                AddТоварToolStripMenuItem.Visible = false;
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
        private void ShowTovar()
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
                        .Where(x => x.deck_tovar.ToLower().StartsWith(findText.ToLower()));
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
                var tovar = new UserControlTovar(item, userRole);

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
        /// Открытие формы истории заказа
        /// </summary>
        private void shouZakazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var history = new HistoryZakaz();
            history.ShowDialog();
        }
    }
}
