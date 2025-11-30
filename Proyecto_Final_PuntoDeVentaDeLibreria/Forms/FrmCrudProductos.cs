using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;
using Proyecto_Final_PuntoDeVentaDeLibreria.Dao;
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
    public partial class FrmCrudProductos : Form
    {
        private ProductoDAO productoDAO;

        public FrmCrudProductos()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();

            // Configuración del DataGridView
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Deshabilitar id
            txtIdProducto.Enabled = false;

            // Conectar Load si no lo hiciste en el diseñador
            this.Load += FrmCrudProductos_Load;
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Text = "";
            txtISBN.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void ListarProductos()
        {
            try
            {
                List<Producto> lista = productoDAO.ListarTodos();

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = lista;

                if (dgvProductos.Columns.Contains("IdProducto"))
                    dgvProductos.Columns["IdProducto"].HeaderText = "ID";

                if (dgvProductos.Columns.Contains("ISBN"))
                    dgvProductos.Columns["ISBN"].HeaderText = "ISBN";

                if (dgvProductos.Columns.Contains("Nombre"))
                    dgvProductos.Columns["Nombre"].HeaderText = "Nombre";

                if (dgvProductos.Columns.Contains("Descripcion"))
                    dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";

                if (dgvProductos.Columns.Contains("Precio"))
                    dgvProductos.Columns["Precio"].HeaderText = "Precio";

                if (dgvProductos.Columns.Contains("Stock"))
                    dgvProductos.Columns["Stock"].HeaderText = "Stock";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCrudProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
            txtISBN.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var p = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

            txtIdProducto.Text = p.IdProducto.ToString();
            txtISBN.Text = p.ISBN;
            txtNombre.Text = p.Nombre;
            txtDescripcion.Text = p.Descripcion;
            txtPrecio.Text = p.Precio.ToString();
            txtStock.Text = p.Stock.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out decimal precio, out int stock)) return;

            var p = new Producto
            {
                ISBN = txtISBN.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Stock = stock
            };

            try
            {
                if (productoDAO.Insertar(p))
                {
                    MessageBox.Show("Producto insertado correctamente.", "Éxito");
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insertando: " + ex.Message, "Error");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Atención");
                return;
            }

            if (!ValidarCampos(out decimal precio, out int stock)) return;

            var p = new Producto
            {
                IdProducto = int.Parse(txtIdProducto.Text),
                ISBN = txtISBN.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Stock = stock
            };

            try
            {
                if (productoDAO.Actualizar(p))
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito");
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizando: " + ex.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Atención");
                return;
            }

            var dlg = MessageBox.Show("¿Eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg != DialogResult.Yes) return;

            try
            {
                int id = int.Parse(txtIdProducto.Text);
                if (productoDAO.Eliminar(id))
                {
                    MessageBox.Show("Producto eliminado.", "Éxito");
                    ListarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminando: " + ex.Message, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool ValidarCampos(out decimal precio, out int stock)
        {
            precio = 0;
            stock = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Nombre requerido."); return false;
            }

            if (!decimal.TryParse(txtPrecio.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out precio))
            {
                MessageBox.Show("Precio inválido."); return false;
            }

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Stock inválido."); return false;
            }

            return true;
        }

        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string isbn = txtISBN.Text.Trim();

                if (string.IsNullOrEmpty(isbn))
                {
                    MessageBox.Show("Escanee un ISBN válido.");
                    return;
                }

                // Opcional: mover el cursor al siguiente campo
                txtNombre.Focus();

                // Evitar sonido "beep" del Enter
                e.SuppressKeyPress = true;
            }
        }
    }
}
