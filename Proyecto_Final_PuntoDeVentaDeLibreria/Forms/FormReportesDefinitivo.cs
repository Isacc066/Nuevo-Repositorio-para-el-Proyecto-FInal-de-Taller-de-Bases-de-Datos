using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    public partial class FormReportesDefinitivo : Form
    {
        private readonly ReporteDAO reporteDAO;
        public FormReportesDefinitivo()
        {
            reporteDAO = new ReporteDAO();

            ConfigurarTablas();
        }

        private void ConfigurarTablas()
        {
            dgvReporteProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporteProductos.ReadOnly = true;
            dgvReporteUsuarios.ReadOnly = true;

            dgvReporteProductos.AllowUserToAddRows = false;
            dgvReporteUsuarios.AllowUserToAddRows = false;

            dgvReporteProductos.RowHeadersVisible = false;
            dgvReporteUsuarios.RowHeadersVisible = false;
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            var tabla = reporteDAO.ReporteProductos(dtpInicio.Value, dtpFin.Value);

            dgvReporteProductos.DataSource = tabla;

            dgvReporteProductos.Columns["ISBN"].HeaderText = "ISBN";
            dgvReporteProductos.Columns["Titulo"].HeaderText = "Título";
            dgvReporteProductos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvReporteProductos.Columns["Costo"].HeaderText = "Costo Unitario";
            dgvReporteProductos.Columns["UnidadesVendidas"].HeaderText = "Vendidos";
        }

        private void btnReporteUsuarios_Click(object sender, EventArgs e)
        {
            var tabla = reporteDAO.ReporteVentasPorUsuario(dtpInicio.Value, dtpFin.Value);

            dgvReporteUsuarios.DataSource = tabla;

            dgvReporteUsuarios.Columns["Usuario"].HeaderText = "Usuario";
            dgvReporteUsuarios.Columns["MontoVendido"].HeaderText = "Monto Vendido";
            dgvReporteUsuarios.Columns["MontoVendido"].DefaultCellStyle.Format = "C2";
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            // aquí cargas fechas, combos, formateo de dgv, etc.
            dgvReporteProductos.AutoGenerateColumns = true;
            dgvReporteUsuarios.AutoGenerateColumns = true;

            // Cargar fechas por defecto
            dtpInicio.Value = DateTime.Today.AddMonths(-1);
            dtpFin.Value = DateTime.Today;

            // Limpiar la vista
            dgvReporteProductos.DataSource = null;
            dgvReporteUsuarios.DataSource = null;
        }
    }
}
