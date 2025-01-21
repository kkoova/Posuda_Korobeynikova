using DemoPosuda.Contrrols;
using DemoPosuda.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace DemoPosuda.Forms
{
    public partial class Main : Form
    {
        public Sotrydnik user;
        public string userRole;
        public List<Tovar> tovarList;
        public Main(Sotrydnik user = null)
        {
            InitializeComponent();

            this.user = user;

            if (user != null)
            {
                AddUserLogin();
            }
            else
            {
                userRole = "Гость";
            }

            ComboboxProizv();
        }

        public void AddUserLogin()
        {
            userRole = user.RoleSotrudnik.role_sotr;

            labelUserFio.Text = user.fio_sotr;

            if (userRole == "Администратор")
                AddТоварToolStripMenuItem.Visible = true;
        }

        public void Stats()
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var all = context.Tovar.Count();

                labelStats.Text = $"{tovarList.Count}/{all}";
            }
        }

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

        private void ShowToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowTovar();
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxFindName_TextChanged(object sender, System.EventArgs e)
        {
            var text = textBoxFindName.Text;
            ApplyFilters(text);
        }

        private void ShowTovar()
        {
            ApplyFilters();
        }

        private void radioButtonUp_CheckedChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

        private void radioButtonDown_CheckedChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

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

        private void comboBoxProizvod_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ApplyFilters();
        }

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

        private void AddТоварToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var addTovar = new AddTovar())
            {
                if (addTovar.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Вы успешшно добавили товар", "Успех");
                }
            }
        }
    }
}
