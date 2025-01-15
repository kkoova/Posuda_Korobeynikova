using DemoPosuda.Contrrols;
using DemoPosuda.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DemoPosuda.Forms
{
    public partial class Main : Form
    {
        public Sotrydnik user;
        public Main(Sotrydnik user = null)
        {
            InitializeComponent();

            this.user = user;

            if (user != null)
            {
                AddUserLogin();
            }
        }

        public void AddUserLogin()
        {
            labelUserFio.Text = user.fio_sotr;
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

            using (var context = new KorobeynikovaPosudaEntities())
            {
                var tovars = context.Tovar
                    .Where(x => x.deck_tovar.ToLower().StartsWith($"{text}"))
                    .ToList();

                flowLayoutPanelTovar.Controls.Clear();

                foreach (var item in tovars)
                {
                    var tovar = new UserControlTovar(item);

                    flowLayoutPanelTovar.Controls.Add(tovar);
                }
            }
        }

        private void ShowTovar()
        {
            flowLayoutPanelTovar.Controls.Clear();

            using (var context = new KorobeynikovaPosudaEntities())
            {
                var tovars = context.Tovar.ToList();

                foreach (var item in tovars)
                {
                    var tovar = new UserControlTovar(item);

                    flowLayoutPanelTovar.Controls.Add(tovar);
                }
            }
        }

        private void radioButtonUp_EnabledChanged(object sender, System.EventArgs e)
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var tovars = context.Tovar
                    .OrderBy(t => t.cost_tovar)
                    .ToList();

                flowLayoutPanelTovar.Controls.Clear();

                foreach (var item in tovars)
                {
                    var tovar = new UserControlTovar(item);

                    flowLayoutPanelTovar.Controls.Add(tovar);
                }
            }
        }

        private void radioButtonDown_EnabledChanged(object sender, System.EventArgs e)
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var tovars = context.Tovar
                    .OrderByDescending(t => t.cost_tovar)
                    .ToList();

                flowLayoutPanelTovar.Controls.Clear();

                foreach (var item in tovars)
                {
                    var tovar = new UserControlTovar(item);

                    flowLayoutPanelTovar.Controls.Add(tovar);
                }
            }
        }
    }
}
