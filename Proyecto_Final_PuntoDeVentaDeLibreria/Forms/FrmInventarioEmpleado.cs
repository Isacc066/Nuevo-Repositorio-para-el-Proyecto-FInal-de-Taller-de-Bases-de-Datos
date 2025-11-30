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
    public partial class FrmInventarioEmpleado : Form
    {
        private ProductoDAO productoDAO;
        public FrmInventarioEmpleado()
        {
            InitializeComponent();
            productoDAO = new ProductoDAO();
        }

        private void FrmInventarioEmpleado_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void CargarInventario()
        {
            var lista = productoDAO.ListarTodos();

            dgvInventario.DataSource = null;
            dgvInventario.DataSource = lista;

            // Etiquetas más bonitas
            dgvInventario.Columns["IdProducto"].HeaderText = "ID";
            dgvInventario.Columns["ISBN"].HeaderText = "ISBN";
            dgvInventario.Columns["Nombre"].HeaderText = "Nombre";
            dgvInventario.Columns["Descripcion"].HeaderText = "Descripción";
            dgvInventario.Columns["Precio"].HeaderText = "Precio";
            dgvInventario.Columns["Stock"].HeaderText = "Stock";
        }
    }
}
