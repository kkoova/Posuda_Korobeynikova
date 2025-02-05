using DemoPosuda.Contrrols;
using DemoPosuda.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DemoPosuda.AppForms
{
    public partial class CanForm : Form
    {
        Sotrydnik clietn;
        List<Tovar> tovarsList;

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
    }
}
