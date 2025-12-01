using Proyecto_Final_PuntoDeVentaDeLibreria.Forms;
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
        private int idUsuarioEnSesion;
        public FormMenuEmpleado(int idUsuario)
        {
            InitializeComponent();
            idUsuarioEnSesion = idUsuario;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas(idUsuarioEnSesion);
            frm.ShowDialog();
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmInventarioEmpleado frm = new FrmInventarioEmpleado();
            frm.ShowDialog();
        }

        private void FormMenuEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
