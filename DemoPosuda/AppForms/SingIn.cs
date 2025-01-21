using DemoPosuda.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.Forms
{
    public partial class SingIn : Form
    {
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

                MessageBox.Show($"Добро пожаловать {user.fio_sotr} Роль: {user.RoleSotrudnik.role_sotr}");

                Hide();

                using (var main = new Main(user))
                {
                    if (main.ShowDialog() == DialogResult.Cancel){
                        main.Close();
                        Show();
                    }
                }
            }
        }

        private void buttonGoNoSign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать! Вы вошли как гость");

            using (var main = new Main())
            {
                if (main.ShowDialog() == DialogResult.Cancel)
                {
                    main.Close();
                    Show();
                }
            }
        }
    }
}
