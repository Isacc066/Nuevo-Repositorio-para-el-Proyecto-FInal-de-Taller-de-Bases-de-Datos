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
    public partial class FormMenuAdmin : Form
    {
        private int idUsuarioEnSesion;
        public FormMenuAdmin(int idUsuario)
        {
            InitializeComponent();
            idUsuarioEnSesion = idUsuario;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();  // ocultar menú mientras trabajas

            FrmCrudUsuarios frm = new FrmCrudUsuarios();
            frm.ShowDialog();   // abrir CRUD

            this.Show();   // volver a mostrar el menú cuando cierren el CRUD
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmCrudProductos frm = new FrmCrudProductos();
            frm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas(idUsuarioEnSesion);
            frm.ShowDialog();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            FrmAuditoria frmAuditoria = new FrmAuditoria();
            frmAuditoria.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmCrudEmpleados frm = new FrmCrudEmpleados();
            frm.ShowDialog();
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
