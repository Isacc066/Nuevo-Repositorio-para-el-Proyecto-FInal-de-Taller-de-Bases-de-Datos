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
    public partial class FrmVentas : Form
    {
        private readonly VentaDAO ventaDAO;
        private List<DetalleVenta> carrito;
        private int idUsuarioEnSesion;
        public FrmVentas(int idUsuario)
        {
            InitializeComponent();
            ventaDAO = new VentaDAO();
            carrito = new List<DetalleVenta>();
            idUsuarioEnSesion = idUsuario;

            ConfigurarGrid();
            txtCantidad.Text = "1";
            ActualizarTotal();
        }

        private void ConfigurarGrid()
        {
            dgvCarrito.ReadOnly = true;
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.AutoGenerateColumns = false;

            dgvCarrito.Columns.Clear();
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { Name = "ISBN", DataPropertyName = "ISBN", HeaderText = "ISBN" });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombreProducto", DataPropertyName = "NombreProducto", HeaderText = "Producto" });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad", DataPropertyName = "Cantidad", HeaderText = "Cant.", Width = 60 });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrecioUnitario", DataPropertyName = "PrecioUnitario", HeaderText = "Precio" });
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn { Name = "Subtotal", DataPropertyName = "Subtotal", HeaderText = "Subtotal" });

            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;
        }

        private void ActualizarGrid()
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = 0m;
            foreach (var d in carrito) total += d.Subtotal;
            lblTotal.Text = total.ToString("C2");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            if (string.IsNullOrEmpty(isbn)) { MessageBox.Show("Ingrese ISBN"); return; }

            if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            // Obtener producto
            var producto = ventaDAO.ObtenerProductoPorISBN(isbn);
            if (producto == null) { MessageBox.Show("Producto no encontrado"); return; }

            if (producto.Stock < cantidad) { MessageBox.Show("No hay stock suficiente"); return; }

            // Verificar si ya está en carrito
            var existe = carrito.Find(x => x.IdProducto == producto.IdProducto);
            if (existe != null)
            {
                if (producto.Stock < existe.Cantidad + cantidad) { MessageBox.Show("No hay stock suficiente"); return; }
                existe.Cantidad += cantidad;
            }
            else
            {
                carrito.Add(new DetalleVenta
                {
                    IdProducto = producto.IdProducto,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.Precio,
                    NombreProducto = producto.Nombre,
                    ISBN = producto.ISBN
                });
            }

            ActualizarGrid();
            txtISBN.Clear();
            txtCantidad.Text = "1";
            txtISBN.Focus();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0) { MessageBox.Show("Carrito vacío"); return; }

            try
            {
                int idVenta = ventaDAO.RegistrarVentaConDetalle(idUsuarioEnSesion, carrito);
                if (idVenta > 0)
                {
                    MessageBox.Show($"Venta registrada correctamente. ID venta: {idVenta}");
                    carrito.Clear();
                    ActualizarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registrando venta: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carrito.Clear();
            ActualizarGrid();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }

        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAgregar_Click(sender, e);
        }
    }
}
