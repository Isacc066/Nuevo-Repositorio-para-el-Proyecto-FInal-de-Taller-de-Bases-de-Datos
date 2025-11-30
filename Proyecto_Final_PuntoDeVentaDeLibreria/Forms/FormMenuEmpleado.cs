using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    public partial class FormMenuEmpleado : Form
    {
        public FormMenuEmpleado()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}
