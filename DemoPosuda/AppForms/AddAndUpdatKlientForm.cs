using DemoPosuda.Models;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace DemoPosuda.AppForms
{
    public partial class AddAndUpdatKlientForm : Form
    {
        Clietn clietn;

        public AddAndUpdatKlientForm(Clietn clietn = null)
        {
            InitializeComponent();
            
            this.clietn = clietn;

            if (clietn != null)
            {
                using (var context = new KorobeynikovaPosudaEntities())
                {
                    var clientFind = context.Sotrydnik
                        .FirstOrDefault(x => x.fio_sotr == clietn.directort_client);

                    if (clientFind != null) 
                    {
                        textBoxLogin.Text = clientFind.login_sotr;
                        textBoxPass.Text = clientFind.pass_sotr;
                    }
                    else
                    {
                        textBoxLogin.Visible = false;
                        textBoxPass.Visible = false;
                    }

                    textBoxName.Text = clietn.directort_client;
                    comboBoxType.SelectedValue = clietn.id__type_client;
                    textBoxCompany.Text = clietn.name_client;
                    maskedTextBoxEmail.Text = clietn.email_client;
                    maskedTextBoxPhone.Text = clietn.phone_client;
                    maskedTextBoxIndex.Text = clietn.index_client.ToString();
                    maskedTextBoxInn.Text = clietn.inn_client.ToString();
                    numericUpDown1.Value = Convert.ToDecimal(clietn.rate_client);
                }
            }

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

                    if (login == null || password == null)
                    {
                        var newClientRole = new Sotrydnik
                        {
                            id_role_sotr = 3,
                            fio_sotr = name,
                            login_sotr = login,
                            pass_sotr = password,
                        };

                        context.Sotrydnik.Add(newClientRole);
                    }

                    context.Clietn.Add(newClient); 
                }
                else
                {
                    var findClient = context.Clietn.Find(clietn.id);

                    findClient.id__type_client = Convert.ToInt32(type);
                    findClient.name_client = name_client;
                    findClient.directort_client = name;
                    findClient.email_client = email;
                    findClient.phone_client = phone;
                    findClient.index_client = Convert.ToDouble(index);
                    findClient.inn_client = Convert.ToInt32(inn);
                    findClient.rate_client = Convert.ToDouble(rate);

                    var clientFind = context.Sotrydnik
                        .FirstOrDefault(x => x.fio_sotr == clietn.directort_client);

                    clientFind.fio_sotr = name;
                    clientFind.login_sotr = login;
                    clientFind.pass_sotr = password;
                }

                context.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
