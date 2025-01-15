using DemoPosuda.Data;
using System.Windows.Forms;

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
    }
}
