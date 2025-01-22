using DemoPosuda.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoPosuda.Forms
{
    /// <summary>
    /// Форма автоизации пользователя <see cref="SingIn"/>
    /// </summary>
    public partial class SingIn : Form
    {
        public Sotrydnik ReturnedValue { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public SingIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Валидация и попытка входа пользователя
        /// </summary>
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

        /// <summary>
        /// Отмена дейтсвия
        /// </summary>
        private void buttonGoNoSign_Click(object sender, EventArgs e)
        {
            ReturnedValue = null;
            DialogResult = DialogResult.OK;
        }
    }
}
