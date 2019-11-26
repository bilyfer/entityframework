using AppBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class formVentas : Form
    {
        VentasBL _ventasBL;

        public formVentas()
        {
            InitializeComponent();

            _ventasBL = new VentasBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listadeVentas = _ventasBL.ObtenerVentas();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listadeVentas;
        }
    }
}
