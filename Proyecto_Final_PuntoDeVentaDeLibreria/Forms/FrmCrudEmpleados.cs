using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proyecto_Final_PuntoDeVentaDeLibreria.Models;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    public partial class FrmCrudEmpleados : Form
    {
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();
        private bool esNuevo = false;      // Modo Nuevo
        private int idEmpleadoSeleccionado; // Para editar

        private void CargarEmpleados()
        {
            dgvEmpleados.DataSource = empleadoDAO.ListarTodos();

            dgvEmpleados.Columns["IdEmpleado"].HeaderText = "ID";
            dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre";
            dgvEmpleados.Columns["Apellido"].HeaderText = "Apellido";
            dgvEmpleados.Columns["Telefono"].HeaderText = "Teléfono";
            dgvEmpleados.Columns["Direccion"].HeaderText = "Dirección";
            dgvEmpleados.Columns["NombreCompleto"].Visible = false;

            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }

        private void HabilitarFormulario(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;

            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;

            btnAgregar.Enabled = !habilitar;
            btnEditar.Enabled = !habilitar;
            btnEliminar.Enabled = !habilitar;
        }

        private void FrmCrudEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            HabilitarFormulario(false);
        }
        public FrmCrudEmpleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarFormulario();
            HabilitarFormulario(true);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para editar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            esNuevo = false;

            Empleado emp = (Empleado)dgvEmpleados.SelectedRows[0].DataBoundItem;

            idEmpleadoSeleccionado = emp.IdEmpleado;

            txtNombre.Text = emp.Nombre;
            txtApellido.Text = emp.Apellido;
            txtTelefono.Text = emp.Telefono;
            txtDireccion.Text = emp.Direccion;

            HabilitarFormulario(true);
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado emp = (Empleado)dgvEmpleados.SelectedRows[0].DataBoundItem;

            DialogResult resp = MessageBox.Show(
                $"¿Eliminar a {emp.NombreCompleto}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                if (empleadoDAO.Eliminar(emp.IdEmpleado))
                {
                    MessageBox.Show("Empleado eliminado correctamente.");
                    CargarEmpleados();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
        txtApellido.Text.Trim() == "" ||
        txtTelefono.Text.Trim() == "" ||
        txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            Empleado emp = new Empleado
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            bool resultado;

            if (esNuevo)
            {
                resultado = empleadoDAO.Insertar(emp);
                MessageBox.Show("Empleado agregado correctamente.");
            }
            else
            {
                emp.IdEmpleado = idEmpleadoSeleccionado;
                resultado = empleadoDAO.Actualizar(emp);
                MessageBox.Show("Empleado actualizado correctamente.");
            }

            if (resultado)
            {
                CargarEmpleados();
                LimpiarFormulario();
                HabilitarFormulario(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            HabilitarFormulario(false);
        }
    }
}
