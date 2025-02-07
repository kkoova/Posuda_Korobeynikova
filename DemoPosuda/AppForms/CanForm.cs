using DemoPosuda.Contrrols;
using DemoPosuda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.AppForms
{
    public partial class CanForm : Form
    {
        Sotrydnik clietn;
        List<Tovar> tovarsList;
        Random rand = new Random();
        public CanForm(List<Tovar> tovarsList, Sotrydnik clietn)
        {
            InitializeComponent();

            this.tovarsList = tovarsList;
            this.clietn = clietn;

            SetTovar();

            var time = DateTime.Now;

            textBoxName.Text = clietn.fio_sotr;
            textBoxDataStart.Text = time.ToString();
            textBoxDataEdn.Text = time.AddDays(5).ToString();

            using (var context = new KorobeynikovaPosudaEntities())
            {
                var index = context.Punkt.ToList();

                comboBoxPunkt.DataSource = index;
                comboBoxPunkt.ValueMember = "id";
                comboBoxPunkt.DisplayMember = "index_punkt";

                double? cost = 0;

                foreach (var item in tovarsList) 
                {
                    cost += item.cost_tovar;
                }

                labelCost.Text = cost.ToString();
            }
        }

        private void SetTovar()
        {
            flowLayoutPanelTovar.Controls.Clear();

            foreach (var item in tovarsList)
            {
                var tovar = new UserControlTovar(item);

                flowLayoutPanelTovar.Controls.Add(tovar);
            }
        }

        private void buttonAddZakaz_Click(object sender, EventArgs e)
        {
            using (var context = new KorobeynikovaPosudaEntities())
            {
                var clientt = context.Clietn
                            .Where(f => f.directort_client == clietn.fio_sotr)
                            .FirstOrDefault();

                var dicktToavr = new Dictionary<int, Zakaz>();

                foreach (var item in tovarsList) 
                {
                    if (dicktToavr.ContainsKey(item.id))
                    {
                        dicktToavr[item.id].kolvo_tovar_in_zakaz++;
                    }
                    else
                    {
                        dicktToavr[item.id] = new Zakaz 
                        { 
                            id_artic_zakaz = item.id, 
                            kolvo_tovar_in_zakaz = 1,
                            data_zakaz = Convert.ToDateTime(textBoxDataStart.Text),
                            data_dostav_zakaz = Convert.ToDateTime(textBoxDataEdn.Text),
                            id_punkt_zakaz = Convert.ToInt16(comboBoxPunkt.SelectedValue),
                            id_name_client = clientt.id,
                            kod_zakaz = rand.Next(600, 900),
                            id_state_zakaz = 2,
                        };
                    }

                    context.Zakaz.Add(dicktToavr[item.id]);
                }

                context.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
