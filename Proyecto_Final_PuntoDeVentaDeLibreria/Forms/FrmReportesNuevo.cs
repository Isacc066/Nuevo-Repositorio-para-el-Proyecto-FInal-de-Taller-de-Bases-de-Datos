using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    public partial class FrmReportesNuevo : Form
    {
        private readonly ReporteDAO reporteDAO;
        private readonly BindingList<ReporteProductoVendido> listaProductos;
        private readonly BindingList<ReporteVentasPorEmpleado> listaEmpleados;
        public FrmReportesNuevo()
        {
            InitializeComponent();
            reporteDAO = new ReporteDAO();
            listaProductos = new BindingList<ReporteProductoVendido>();
            listaEmpleados = new BindingList<ReporteVentasPorEmpleado>();

            // Eventos
            btnGenerarReporteProductos.Click += BtnGenerarReporteProductos_Click;
            btnGenerarReporteEmpleados.Click += BtnGenerarReporteEmpleados_Click;

            // Configuración inicial
            ConfigurarGridProductos();
            ConfigurarGridEmpleados();
            ConfigurarFechas();
        }

        // ========================================
        // CONFIGURACIÓN INICIAL
        // ========================================
        private void ConfigurarFechas()
        {
            // Configurar fechas para reporte de productos
            dtpInicioProductos.Value = DateTime.Now.AddMonths(-1);
            dtpFinProductos.Value = DateTime.Now;
            dtpInicioProductos.MaxDate = DateTime.Now;
            dtpFinProductos.MaxDate = DateTime.Now;

            // Configurar fechas para reporte de empleados
            dtpInicioEmpleados.Value = DateTime.Now.AddMonths(-1);
            dtpFinEmpleados.Value = DateTime.Now;
            dtpInicioEmpleados.MaxDate = DateTime.Now;
            dtpFinEmpleados.MaxDate = DateTime.Now;
        }

        // ========================================
        // CONFIGURACIÓN GRID PRODUCTOS
        // ========================================
        private void ConfigurarGridProductos()
        {
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ISBN",
                DataPropertyName = "ISBN",
                HeaderText = "ISBN",
                Width = 120
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                HeaderText = "TÍTULO",
                Width = 250
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                DataPropertyName = "Descripcion",
                HeaderText = "DESCRIPCIÓN",
                Width = 200
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Costo",
                DataPropertyName = "Costo",
                HeaderText = "COSTO",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnidadesVendidas",
                DataPropertyName = "UnidadesVendidas",
                HeaderText = "UNIDADES VENDIDAS",
                Width = 150
            });

            dgvProductos.DataSource = listaProductos;
        }

        // ========================================
        // CONFIGURACIÓN GRID EMPLEADOS
        // ========================================
        private void ConfigurarGridEmpleados()
        {
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Clave",
                DataPropertyName = "Clave",
                HeaderText = "ID USUARIO",
                Width = 100
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                HeaderText = "NOMBRE DE USUARIO",
                Width = 220
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MontoVendido",
                DataPropertyName = "MontoVendido",
                HeaderText = "MONTO VENDIDO",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumeroVentas",
                DataPropertyName = "NumeroVentas",
                HeaderText = "# VENTAS",
                Width = 100
            });

            dgvEmpleados.DataSource = listaEmpleados;
        }

        private void BtnGenerarReporteProductos_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpInicioProductos.Value.Date;
                DateTime fechaFin = dtpFinProductos.Value.Date;

                // Validar rango de fechas
                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin",
                        "Rango de fechas inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar indicador de carga
                Cursor = Cursors.WaitCursor;
                lblEstadoProductos.Text = "Generando reporte...";
                lblEstadoProductos.ForeColor = System.Drawing.Color.Blue;

                // Obtener datos
                var productos = reporteDAO.ObtenerReporteProductosVendidos(fechaInicio, fechaFin);

                // Limpiar y llenar lista
                listaProductos.Clear();
                foreach (var producto in productos)
                {
                    listaProductos.Add(producto);
                }

                // Actualizar estadísticas
                int totalUnidades = productos.Sum(p => p.UnidadesVendidas);
                decimal totalVentas = productos.Sum(p => p.TotalVendido);

                lblEstadoProductos.Text = $"Productos encontrados: {productos.Count} | " +
                                         $"Total unidades: {totalUnidades} | " +
                                         $"Total ventas: {totalVentas:C2}";
                lblEstadoProductos.ForeColor = System.Drawing.Color.Green;

                if (productos.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas de productos en el rango de fechas seleccionado",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                lblEstadoProductos.Text = "Error al generar reporte";
                lblEstadoProductos.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Error al generar reporte de productos:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnGenerarReporteEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpInicioEmpleados.Value.Date;
                DateTime fechaFin = dtpFinEmpleados.Value.Date;

                // Validar rango de fechas
                if (fechaInicio > fechaFin)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin",
                        "Rango de fechas inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar indicador de carga
                Cursor = Cursors.WaitCursor;
                lblEstadoEmpleados.Text = "Generando reporte...";
                lblEstadoEmpleados.ForeColor = System.Drawing.Color.Blue;

                // Obtener datos
                var empleados = reporteDAO.ObtenerReporteVentasPorEmpleado(fechaInicio, fechaFin);

                // Limpiar y llenar lista
                listaEmpleados.Clear();
                foreach (var empleado in empleados)
                {
                    listaEmpleados.Add(empleado);
                }

                // Actualizar estadísticas
                decimal totalVentas = empleados.Sum(e => e.MontoVendido);
                int totalOperaciones = empleados.Sum(e => e.NumeroVentas);

                lblEstadoEmpleados.Text = $"Usuarios con ventas: {empleados.Count} | " +
                                         $"Total ventas: {totalVentas:C2} | " +
                                         $"Total operaciones: {totalOperaciones}";
                lblEstadoEmpleados.ForeColor = System.Drawing.Color.Green;

                if (empleados.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                lblEstadoEmpleados.Text = "Error al generar reporte";
                lblEstadoEmpleados.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Error al generar reporte de empleados:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
