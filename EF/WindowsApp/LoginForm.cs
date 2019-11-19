using AppBL;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class LoginForm : Form
    {
        SeguridadBL _seguridad;

        public LoginForm()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autenticar();
        }

        private void Autenticar()
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Verificando...";
            Application.DoEvents();

            var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

            button1.Enabled = true;
            button1.Text = "Aceptar";
        }
    }
}
