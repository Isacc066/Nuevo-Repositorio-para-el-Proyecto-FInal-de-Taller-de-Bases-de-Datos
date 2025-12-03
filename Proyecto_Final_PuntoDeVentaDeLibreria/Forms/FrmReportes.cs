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
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    public partial class FrmReportes : Form
    {
        private readonly ReporteDAO reporteDAO;
        private List<ReporteVenta> reporteActual;
        public FrmReportes()
        {
            InitializeComponent();
            reporteDAO = new ReporteDAO();
            reporteActual = new List<ReporteVenta>();

            ConfigurarDataGridView();
            ConfigurarFechas();

            this.Load += FrmReportes_Load;
        }

        private void ConfigurarDataGridView()
        {
            dgvReporte.ReadOnly = true;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.RowHeadersVisible = false;
        }

        /// <summary>
        /// Configura los controles de fecha
        /// </summary>
        private void ConfigurarFechas()
        {
            dtpFechaInicio.Value = DateTime.Today.AddDays(-30);
            dtpFechaFin.Value = DateTime.Today;
            dtpFechaConsulta.Value = DateTime.Today;
        }

        /// <summary>
        /// Carga inicial del formulario
        /// </summary>
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarEstadisticasGenerales();
        }

        /// <summary>
        /// Carga las estadísticas generales usando las funciones SQL
        /// </summary>
        private void CargarEstadisticasGenerales()
        {
            try
            {
                // Total de productos vendidos
                int totalProductos = reporteDAO.ObtenerTotalProductosVendidos();
                lblTotalProductosVendidos.Text = $"Total productos vendidos: {totalProductos:N0}";

                // Producto más vendido
                string productoTop = reporteDAO.ObtenerProductoMasVendido();
                lblProductoMasVendido.Text = $"Producto más vendido: {productoTop}";

                // Total de ventas del día actual
                decimal totalHoy = reporteDAO.ObtenerTotalVentasPorFecha(DateTime.Today);
                lblTotalVentasHoy.Text = $"Ventas de hoy: {totalHoy:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estadísticas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra el reporte detallado completo
        /// </summary>
        private void btnReporteCompleto_Click(object sender, EventArgs e)
        {
            try
            {
                reporteActual = reporteDAO.ObtenerReporteDetalladoVentas();
                MostrarReporte();

                if (reporteActual.Count == 0)
                {
                    MessageBox.Show("No hay ventas registradas.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Filtra reporte por rango de fechas
        /// </summary>
        private void btnFiltrarPorFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime inicio = dtpFechaInicio.Value.Date;
                DateTime fin = dtpFechaFin.Value.Date;

                if (inicio > fin)
                {
                    MessageBox.Show("La fecha inicial no puede ser mayor a la fecha final.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                reporteActual = reporteDAO.ObtenerReportePorRangoFechas(inicio, fin);
                MostrarReporte();

                if (reporteActual.Count == 0)
                {
                    MessageBox.Show($"No hay ventas entre {inicio:dd/MM/yyyy} y {fin:dd/MM/yyyy}.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar por fechas: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Consulta total de ventas de una fecha específica
        /// </summary>
        private void btnConsultarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dtpFechaConsulta.Value.Date;
                decimal total = reporteDAO.ObtenerTotalVentasPorFecha(fecha);

                string mensaje = $"Total de ventas del {fecha:dd/MM/yyyy}:\n\n{total:C2}";
                MessageBox.Show(mensaje, "Total de Ventas por Fecha",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar fecha: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Busca una venta específica por su ID
        /// </summary>
        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscarVenta.Text.Trim(), out int idVenta) || idVenta <= 0)
            {
                MessageBox.Show("Ingrese un ID de venta válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                reporteActual = reporteDAO.ObtenerVentaPorId(idVenta);
                MostrarReporte();

                if (reporteActual.Count == 0)
                {
                    MessageBox.Show($"No se encontró la venta con ID {idVenta}.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar venta: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra el reporte actual en el DataGridView
        /// </summary>
        private void MostrarReporte()
        {
            dgvReporte.DataSource = null;
            dgvReporte.DataSource = reporteActual;

            // Personalizar columnas
            if (dgvReporte.Columns.Contains("IdVenta"))
            {
                dgvReporte.Columns["IdVenta"].HeaderText = "ID Venta";
                dgvReporte.Columns["IdVenta"].Width = 80;
            }

            if (dgvReporte.Columns.Contains("Fecha"))
            {
                dgvReporte.Columns["Fecha"].HeaderText = "Fecha";
                dgvReporte.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvReporte.Columns.Contains("UsuarioQueVendio"))
                dgvReporte.Columns["UsuarioQueVendio"].HeaderText = "Vendedor";

            if (dgvReporte.Columns.Contains("IdProducto"))
                dgvReporte.Columns["IdProducto"].Visible = false;

            if (dgvReporte.Columns.Contains("Producto"))
                dgvReporte.Columns["Producto"].HeaderText = "Producto";

            if (dgvReporte.Columns.Contains("Cantidad"))
            {
                dgvReporte.Columns["Cantidad"].HeaderText = "Cant.";
                dgvReporte.Columns["Cantidad"].Width = 60;
            }

            if (dgvReporte.Columns.Contains("PrecioUnitario"))
            {
                dgvReporte.Columns["PrecioUnitario"].HeaderText = "Precio Unit.";
                dgvReporte.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
            }

            if (dgvReporte.Columns.Contains("Subtotal"))
            {
                dgvReporte.Columns["Subtotal"].HeaderText = "Subtotal";
                dgvReporte.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            }

            if (dgvReporte.Columns.Contains("Total"))
            {
                dgvReporte.Columns["Total"].HeaderText = "Total Venta";
                dgvReporte.Columns["Total"].DefaultCellStyle.Format = "C2";
            }

            ActualizarResumen();
        }

        /// <summary>
        /// Actualiza el resumen de totales del reporte actual
        /// </summary>
        private void ActualizarResumen()
        {
            if (reporteActual.Count == 0)
            {
                lblResumen.Text = "No hay datos para mostrar";
                return;
            }

            // Agrupar por idVenta para contar ventas únicas
            int totalVentas = reporteActual.Select(r => r.IdVenta).Distinct().Count();
            int totalProductos = reporteActual.Sum(r => r.Cantidad);
            decimal totalIngresos = reporteActual.GroupBy(r => r.IdVenta)
                                                  .Sum(g => g.First().Total);

            lblResumen.Text = $"Ventas: {totalVentas} | Productos: {totalProductos} | Total: {totalIngresos:C2}";
        }

        /// <summary>
        /// Actualiza las estadísticas generales
        /// </summary>
        private void btnActualizarEstadisticas_Click(object sender, EventArgs e)
        {
            CargarEstadisticasGenerales();
            MessageBox.Show("Estadísticas actualizadas.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
