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
    public partial class FrmAuditoria : Form
    {
        private readonly AuditoriaDAO auditoriaDAO;
        private List<AuditoriaProducto> listaActual;
        public FrmAuditoria()
        {
            InitializeComponent();
            auditoriaDAO = new AuditoriaDAO();
            listaActual = new List<AuditoriaProducto>();

            ConfigurarDataGridView();
            ConfigurarComboAccion();
            ConfigurarFechas();

            this.Load += FrmAuditoria_Load;
        }

        /// <summary>
        /// Configura las propiedades del DataGridView
        /// </summary>
        private void ConfigurarDataGridView()
        {
            dgvAuditoria.ReadOnly = true;
            dgvAuditoria.AllowUserToAddRows = false;
            dgvAuditoria.AllowUserToDeleteRows = false;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditoria.RowHeadersVisible = false;
        }

        /// <summary>
        /// Configura el ComboBox de acciones
        /// </summary>
        private void ConfigurarComboAccion()
        {
            cboAccion.Items.Clear();
            cboAccion.Items.Add("TODAS");
            cboAccion.Items.Add("INSERT");
            cboAccion.Items.Add("UPDATE");
            cboAccion.Items.Add("DELETE");
            cboAccion.SelectedIndex = 0;
        }

        /// <summary>
        /// Configura los controles de fecha
        /// </summary>
        private void ConfigurarFechas()
        {
            dtpFechaInicio.Value = DateTime.Today.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Today;
        }

        /// <summary>
        /// Carga inicial del formulario
        /// </summary>
        private void FrmAuditoria_Load(object? sender, EventArgs e)
        {
            CargarAuditoria();
        }

        /// <summary>
        /// Carga todos los registros de auditoría
        /// </summary>
        private void CargarAuditoria()
        {
            try
            {
                listaActual = auditoriaDAO.ListarTodos();
                MostrarAuditoria();

                if (listaActual.Count == 0)
                {
                    MessageBox.Show("No hay registros de auditoría.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar auditoría: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra la lista actual en el DataGridView
        /// </summary>
        private void MostrarAuditoria()
        {
            dgvAuditoria.DataSource = null;
            dgvAuditoria.DataSource = listaActual;

            // Personaliza columnas
            if (dgvAuditoria.Columns.Contains("IdAuditoria"))
            {
                dgvAuditoria.Columns["IdAuditoria"].HeaderText = "ID";
                dgvAuditoria.Columns["IdAuditoria"].Width = 60;
            }

            if (dgvAuditoria.Columns.Contains("FechaHora"))
            {
                dgvAuditoria.Columns["FechaHora"].HeaderText = "Fecha y Hora";
                dgvAuditoria.Columns["FechaHora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }

            if (dgvAuditoria.Columns.Contains("Accion"))
            {
                dgvAuditoria.Columns["Accion"].HeaderText = "Acción";
                dgvAuditoria.Columns["Accion"].Width = 80;
            }

            if (dgvAuditoria.Columns.Contains("IdProducto"))
            {
                dgvAuditoria.Columns["IdProducto"].HeaderText = "ID Producto";
                dgvAuditoria.Columns["IdProducto"].Width = 90;
            }

            if (dgvAuditoria.Columns.Contains("Usuario"))
                dgvAuditoria.Columns["Usuario"].HeaderText = "Usuario BD";

            if (dgvAuditoria.Columns.Contains("ValoresAnteriores"))
                dgvAuditoria.Columns["ValoresAnteriores"].HeaderText = "Valores Anteriores";

            if (dgvAuditoria.Columns.Contains("ValoresNuevos"))
                dgvAuditoria.Columns["ValoresNuevos"].HeaderText = "Valores Nuevos";

            // Colorea filas según la acción
            foreach (DataGridViewRow row in dgvAuditoria.Rows)
            {
                var auditoria = (AuditoriaProducto)row.DataBoundItem;

                switch (auditoria.Accion)
                {
                    case "INSERT":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "UPDATE":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "DELETE":
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.White;
                        break;
                }
            }

            ActualizarContador();
        }

        /// <summary>
        /// Actualiza el contador de registros
        /// </summary>
        private void ActualizarContador()
        {
            lblContador.Text = $"Total de registros: {listaActual.Count}";
        }

        /// <summary>
        /// Muestra todos los registros
        /// </summary>
        private void btnMostrarTodos_Click(object? sender, EventArgs e)
        {
            CargarAuditoria();
            cboAccion.SelectedIndex = 0;
        }

        /// <summary>
        /// Filtra por tipo de acción
        /// </summary>
        private void btnFiltrarAccion_Click(object? sender, EventArgs e)
        {
            try
            {
                string accionSeleccionada = cboAccion.SelectedItem?.ToString() ?? "TODAS";

                if (accionSeleccionada == "TODAS")
                {
                    listaActual = auditoriaDAO.ListarTodos();
                }
                else
                {
                    listaActual = auditoriaDAO.FiltrarPorAccion(accionSeleccionada);
                }

                MostrarAuditoria();

                if (listaActual.Count == 0)
                {
                    MessageBox.Show($"No hay registros de tipo {accionSeleccionada}.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Filtra por rango de fechas
        /// </summary>
        private void btnFiltrarFecha_Click(object? sender, EventArgs e)
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

                listaActual = auditoriaDAO.FiltrarPorFechas(inicio, fin);
                MostrarAuditoria();

                if (listaActual.Count == 0)
                {
                    MessageBox.Show($"No hay registros entre {inicio:dd/MM/yyyy} y {fin:dd/MM/yyyy}.",
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
        /// Busca auditoría de un producto específico
        /// </summary>
        private void btnBuscarProducto_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProducto.Text.Trim(), out int idProducto) || idProducto <= 0)
            {
                MessageBox.Show("Ingrese un ID de producto válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                listaActual = auditoriaDAO.FiltrarPorProducto(idProducto);
                MostrarAuditoria();

                if (listaActual.Count == 0)
                {
                    MessageBox.Show($"No hay registros para el producto ID {idProducto}.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar producto: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra detalles completos de un registro de auditoría
        /// </summary>
        private void dgvAuditoria_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var auditoria = (AuditoriaProducto)dgvAuditoria.Rows[e.RowIndex].DataBoundItem;

            string mensaje = $"═══════════════════════════════════\n" +
                           $"DETALLES DE AUDITORÍA\n" +
                           $"═══════════════════════════════════\n\n" +
                           $"ID: {auditoria.IdAuditoria}\n" +
                           $"Fecha/Hora: {auditoria.FechaHora:dd/MM/yyyy HH:mm:ss}\n" +
                           $"Acción: {auditoria.Accion}\n" +
                           $"ID Producto: {auditoria.IdProducto?.ToString() ?? "N/A"}\n" +
                           $"Usuario BD: {auditoria.Usuario}\n\n";

            if (!string.IsNullOrEmpty(auditoria.ValoresAnteriores))
            {
                mensaje += $"Valores Anteriores:\n{auditoria.ValoresAnteriores}\n\n";
            }

            if (!string.IsNullOrEmpty(auditoria.ValoresNuevos))
            {
                mensaje += $"Valores Nuevos:\n{auditoria.ValoresNuevos}\n";
            }

            MessageBox.Show(mensaje, "Detalles de Auditoría",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

