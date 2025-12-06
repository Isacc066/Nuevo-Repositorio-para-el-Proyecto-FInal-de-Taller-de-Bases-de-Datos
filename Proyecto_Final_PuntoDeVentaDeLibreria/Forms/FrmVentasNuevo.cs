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
    public partial class FrmVentasNuevo : Form
    {
        private readonly VentaDAO ventaDAO;
        private readonly BindingList<DetalleVenta> carrito; // ⭐ CAMBIO: BindingList en lugar de List
        private readonly int idUsuarioEnSesion;
        private int indiceFilaSeleccionada = -1; // ⭐ NUEVO

        public FrmVentasNuevo(int idUsuario)
        {
            InitializeComponent();
            ventaDAO = new VentaDAO();
            carrito = new BindingList<DetalleVenta>(); // ⭐ CAMBIO
            idUsuarioEnSesion = idUsuario;

            // EVENTOS
            dgvCarrito.CellClick += dgvCarrito_CellClick;
            txtISBN.KeyDown += txtISBN_KeyDown;

            // CONFIGURACIÓN INICIAL
            ConfigurarGrid();
            txtCantidad.Text = "1";
            ActualizarTotal();
        }

        // -------------------------
        // CONFIGURACIÓN DEL GRID
        // -------------------------
        private void ConfigurarGrid()
        {
            dgvCarrito.ReadOnly = true;
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;
            dgvCarrito.RowHeadersVisible = true;
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ISBN",
                DataPropertyName = "ISBN",
                HeaderText = "ISBN",
                Width = 120
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreProducto",
                DataPropertyName = "NombreProducto",
                HeaderText = "Producto",
                Width = 220
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                DataPropertyName = "Cantidad",
                HeaderText = "Cant.",
                Width = 60
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioUnitario",
                DataPropertyName = "PrecioUnitario",
                HeaderText = "Precio",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // ⭐ ASIGNAR DataSource UNA SOLA VEZ
            dgvCarrito.DataSource = carrito;
        }

        // -------------------------
        // ACTUALIZAR TOTAL
        // -------------------------
        private void ActualizarTotal()
        {
            decimal total = carrito.Sum(x => x.Subtotal);
            lblTotal.Text = total.ToString("C2");
        }

        // -------------------------
        // AGREGAR PRODUCTO
        // -------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = txtISBN.Text.Trim();
                if (string.IsNullOrEmpty(isbn))
                {
                    MessageBox.Show("Ingrese un ISBN válido", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtISBN.Focus();
                    return;
                }

                if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor a 0", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }

                var producto = ventaDAO.ObtenerProductoPorISBN(isbn);
                if (producto == null)
                {
                    MessageBox.Show($"No se encontró un producto con ISBN: {isbn}", "Producto no encontrado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtISBN.Focus();
                    return;
                }

                if (producto.Stock < cantidad)
                {
                    MessageBox.Show($"Stock insuficiente. Disponible: {producto.Stock}", "Stock insuficiente",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si ya existe en el carrito
                var existe = carrito.FirstOrDefault(x => x.IdProducto == producto.IdProducto);
                if (existe != null)
                {
                    int nuevaCantidad = existe.Cantidad + cantidad;
                    if (producto.Stock < nuevaCantidad)
                    {
                        MessageBox.Show($"Stock insuficiente. Ya tiene {existe.Cantidad} en el carrito. " +
                            $"Disponible: {producto.Stock}", "Stock insuficiente",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    existe.Cantidad = nuevaCantidad;
                }
                else
                {
                    // ⭐ AGREGAR NUEVO ITEM AL CARRITO
                    carrito.Add(new DetalleVenta
                    {
                        IdProducto = producto.IdProducto,
                        Cantidad = cantidad,
                        PrecioUnitario = producto.Precio,
                        NombreProducto = producto.Nombre,
                        ISBN = producto.ISBN
                    });
                }

                // ⭐ ACTUALIZAR TOTAL Y SELECCIONAR ÚLTIMA FILA
                ActualizarTotal();

                if (dgvCarrito.Rows.Count > 0)
                {
                    dgvCarrito.ClearSelection();
                    int ultimaFila = dgvCarrito.Rows.Count - 1;
                    dgvCarrito.Rows[ultimaFila].Selected = true;
                    indiceFilaSeleccionada = ultimaFila;
                }

                // Limpiar y enfocar
                txtISBN.Clear();
                txtCantidad.Text = "1";
                txtISBN.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // PAGAR / REGISTRAR VENTA
        // -------------------------
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío", "Carrito vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Confirmar venta por un total de {lblTotal.Text}?",
                "Confirmar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                // ⭐ Convertir BindingList a List para el DAO
                int idVenta = ventaDAO.RegistrarVentaConDetalle(idUsuarioEnSesion, carrito.ToList());

                if (idVenta > 0)
                {
                    MessageBox.Show($"✓ Venta registrada correctamente\n\nID Venta: {idVenta}\nTotal: {lblTotal.Text}",
                        "Venta exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Limpiar carrito
                    carrito.Clear();
                    indiceFilaSeleccionada = -1;
                    ActualizarTotal();
                    txtISBN.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // CANCELAR PRODUCTO DEL CARRITO
        // -------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío", "Carrito vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (indiceFilaSeleccionada < 0 || indiceFilaSeleccionada >= carrito.Count)
            {
                MessageBox.Show("Seleccione un producto del carrito para eliminarlo", "Seleccione producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemEliminado = carrito[indiceFilaSeleccionada];

            var confirmacion = MessageBox.Show(
                $"¿Eliminar '{itemEliminado.NombreProducto}' del carrito?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            carrito.RemoveAt(indiceFilaSeleccionada);
            indiceFilaSeleccionada = -1;
            ActualizarTotal();

            MessageBox.Show($"Producto eliminado del carrito", "Eliminado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // -------------------------
        // ENTER = AGREGAR
        // -------------------------
        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el beep
                btnAgregar.PerformClick();
            }
        }

        // -------------------------
        // SELECCIÓN DEL GRID
        // -------------------------
        private void dgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= carrito.Count)
            {
                indiceFilaSeleccionada = -1;
                return;
            }

            indiceFilaSeleccionada = e.RowIndex;
            dgvCarrito.Rows[e.RowIndex].Selected = true;
        }
    }
}
