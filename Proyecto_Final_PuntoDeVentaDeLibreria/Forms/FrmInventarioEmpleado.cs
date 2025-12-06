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
    public partial class FrmInventarioEmpleado : Form
    {
        private ProductoDAO productoDAO;

        public FrmInventarioEmpleado()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();
            ConfigurarGrid();
        }

        private void FrmInventarioEmpleado_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        /// <summary>
        /// Configura las propiedades del DataGridView
        /// </summary>
        private void ConfigurarGrid()
        {
            dgvInventario.ReadOnly = true;
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.RowHeadersVisible = false;
        }

        /// <summary>
        /// Carga el inventario de productos
        /// </summary>
        private void CargarInventario()
        {
            try
            {
                var lista = productoDAO.ListarTodos();
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = lista;

                // Personalizar columnas
                PersonalizarColumnas();

                // Colorear filas con stock bajo
                ColorearFilasBajoStock();

                // Actualizar estadísticas
                ActualizarEstadisticas(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar inventario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Personaliza los encabezados y anchos de columnas
        /// </summary>
        private void PersonalizarColumnas()
        {
            if (dgvInventario.Columns.Contains("IdProducto"))
            {
                dgvInventario.Columns["IdProducto"].HeaderText = "ID";
                dgvInventario.Columns["IdProducto"].Width = 60;
            }

            if (dgvInventario.Columns.Contains("ISBN"))
            {
                dgvInventario.Columns["ISBN"].HeaderText = "ISBN";
                dgvInventario.Columns["ISBN"].Width = 120;
            }

            if (dgvInventario.Columns.Contains("Nombre"))
            {
                dgvInventario.Columns["Nombre"].HeaderText = "Nombre del Producto";
                dgvInventario.Columns["Nombre"].Width = 250;
            }

            if (dgvInventario.Columns.Contains("Descripcion"))
            {
                dgvInventario.Columns["Descripcion"].HeaderText = "Descripción";
                dgvInventario.Columns["Descripcion"].Width = 200;
            }

            if (dgvInventario.Columns.Contains("Precio"))
            {
                dgvInventario.Columns["Precio"].HeaderText = "Precio";
                dgvInventario.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dgvInventario.Columns["Precio"].Width = 100;
            }

            if (dgvInventario.Columns.Contains("Stock"))
            {
                dgvInventario.Columns["Stock"].HeaderText = "Stock";
                dgvInventario.Columns["Stock"].Width = 80;
            }
        }

        /// <summary>
        /// Colorea las filas con stock bajo (menos de 10 unidades)
        /// </summary>
        private void ColorearFilasBajoStock()
        {
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                var producto = (Producto)row.DataBoundItem;

                if (producto.Stock <= 5)
                {
                    // Stock crítico (≤5): Rojo
                    row.DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60);
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.Font = new Font(dgvInventario.Font, FontStyle.Bold);
                }
                else if (producto.Stock <= 10)
                {
                    // Stock bajo (≤10): Amarillo
                    row.DefaultCellStyle.BackColor = Color.FromArgb(241, 196, 15);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (producto.Stock >= 50)
                {
                    // Stock alto (≥50): Verde claro
                    row.DefaultCellStyle.BackColor = Color.FromArgb(212, 239, 223);
                }
            }
        }

        /// <summary>
        /// Actualiza las estadísticas del inventario
        /// </summary>
        private void ActualizarEstadisticas(List<Producto> productos)
        {
            int totalProductos = productos.Count;
            int productosBajoStock = productos.Count(p => p.Stock <= 10);
            decimal valorTotal = productos.Sum(p => p.Precio * p.Stock);

            lblTotalProductos.Text = $"Total de productos: {totalProductos}";
            lblProductosBajoStock.Text = $"⚠️ Productos bajo stock: {productosBajoStock}";
            lblValorTotal.Text = $"Valor total: {valorTotal:C2}";

            // Cambiar color si hay productos bajo stock
            if (productosBajoStock > 0)
            {
                lblProductosBajoStock.ForeColor = Color.FromArgb(231, 76, 60);
            }
            else
            {
                lblProductosBajoStock.ForeColor = Color.FromArgb(46, 204, 113);
                lblProductosBajoStock.Text = "✓ Stock saludable";
            }
        }
    }
}
