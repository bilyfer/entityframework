using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new LoginForm();
            formLogin.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
