using DemoPosuda.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.AppForms
{
    public partial class AddAndUpdatKlientForm : Form
    {
        Clietn clietn;

        public AddAndUpdatKlientForm()
        {
            InitializeComponent();

            using(var context = new KorobeynikovaPosudaEntities())
            {
                var type = context.TypeClient.ToList();

                comboBoxType.DataSource = type;
                comboBoxType.ValueMember = "id";
                comboBoxType.DisplayMember = "type_client";
            }
        }

        private void buttonGo_Click(object sender, System.EventArgs e)
        {
            var name = textBoxName.Text;
            var login = textBoxLogin.Text;
            var password = textBoxPass.Text;
            var type = comboBoxType.SelectedValue;
            var name_client = textBoxCompany.Text;
            var email = maskedTextBoxEmail.Text;
            var phone = maskedTextBoxPhone.Text;
            var index = maskedTextBoxIndex.Text;
            var inn = maskedTextBoxInn.Text;
            var rate = numericUpDown1.Value;

            using(var context = new KorobeynikovaPosudaEntities())
            {
                if (clietn == null)
                {
                    var newClient = new Clietn 
                    { 
                        id__type_client = Convert.ToInt32(type),
                        name_client = name_client,
                        directort_client = name,
                        email_client = email,
                        phone_client = phone,
                        index_client = Convert.ToDouble(index),
                        inn_client = Convert.ToInt32(inn),
                        rate_client = Convert.ToDouble(rate),
                    };

                    var newClientRole = new Sotrydnik
                    {
                        id_role_sotr = 3,
                        fio_sotr = name,
                        login_sotr = login,
                        pass_sotr = password,
                    };

                    context.Clietn.Add(newClient);
                    context.Sotrydnik.Add(newClientRole);

                    context.SaveChanges();
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
