using DemoPosuda.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.Forms
{
    public partial class SingIn : Form
    {
        public Sotrydnik ReturnedValue { get; set; }

        public SingIn()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPass.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Заполните поля!", "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            using (var context = new KorobeynikovaPosudaEntities())
            {
                var user = context.Sotrydnik
                    .FirstOrDefault(u => u.login_sotr == login && u.pass_sotr == pass);

                if (user == null)
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                ReturnedValue = user;
            }
            DialogResult = DialogResult.OK;
        }

        private void buttonGoNoSign_Click(object sender, EventArgs e)
        {
            ReturnedValue = null;
            DialogResult = DialogResult.OK;
        }
    }
}
