using Proyecto_Final_PuntoDeVentaDeLibreria.Models;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    public partial class FrmPruebaEmpleadoDAO : Form
    {
        private EmpleadoDAO empleadoDAO;
        public FrmPruebaEmpleadoDAO()
        {
            InitializeComponent();
            empleadoDAO = new EmpleadoDAO();
        }

        /// <summary>
        /// Prueba insertar un empleado
        /// </summary>
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Solicitar datos al usuario
                string nombre = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el nombre del empleado:", "Nombre", "Juan");

                if (string.IsNullOrEmpty(nombre)) return;

                string apellido = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el apellido:", "Apellido", "Pérez");

                string telefono = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el teléfono:", "Teléfono", "443-555-0000");

                string direccion = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la dirección:", "Dirección", "Calle Principal 123");

                Empleado nuevoEmpleado = new Empleado
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Direccion = direccion
                };

                bool resultado = empleadoDAO.Insertar(nuevoEmpleado);

                if (resultado)
                {
                    txtResultado.Text = $"✅ Empleado {nombre} {apellido} insertado correctamente\r\n" + txtResultado.Text;
                    MessageBox.Show("Empleado insertado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnListar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                txtResultado.Text = $"❌ ERROR: {ex.Message}\r\n" + txtResultado.Text;
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prueba listar todos los empleados
        /// </summary>
        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Empleado> empleados = empleadoDAO.ListarTodos();

                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = empleados;

                // Configurar columnas para mejor visualización
                dgvEmpleados.Columns["IdEmpleado"].HeaderText = "ID";
                dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre";
                dgvEmpleados.Columns["Apellido"].HeaderText = "Apellido";
                dgvEmpleados.Columns["Telefono"].HeaderText = "Teléfono";
                dgvEmpleados.Columns["Direccion"].HeaderText = "Dirección";
                dgvEmpleados.Columns["NombreCompleto"].HeaderText = "Nombre Completo";

                // Ajustar ancho de columnas
                dgvEmpleados.Columns["IdEmpleado"].Width = 50;
                dgvEmpleados.Columns["Nombre"].Width = 100;
                dgvEmpleados.Columns["Apellido"].Width = 100;
                dgvEmpleados.Columns["Telefono"].Width = 120;
                dgvEmpleados.Columns["Direccion"].Width = 200;

                txtResultado.Text = $"✅ Se encontraron {empleados.Count} empleados\r\n" + txtResultado.Text;
            }
            catch (Exception ex)
            {
                txtResultado.Text = $"❌ ERROR: {ex.Message}\r\n" + txtResultado.Text;
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prueba actualizar el primer empleado de la lista
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado del grid para actualizar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el empleado seleccionado
                Empleado empleado = (Empleado)dgvEmpleados.SelectedRows[0].DataBoundItem;

                // Solicitar nuevos datos
                string nombre = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nuevo nombre:", "Actualizar", empleado.Nombre);

                if (string.IsNullOrEmpty(nombre)) return;

                string apellido = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nuevo apellido:", "Actualizar", empleado.Apellido);

                string telefono = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nuevo teléfono:", "Actualizar", empleado.Telefono);

                string direccion = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nueva dirección:", "Actualizar", empleado.Direccion);

                // Actualizar datos
                empleado.Nombre = nombre;
                empleado.Apellido = apellido;
                empleado.Telefono = telefono;
                empleado.Direccion = direccion;

                bool resultado = empleadoDAO.Actualizar(empleado);

                if (resultado)
                {
                    txtResultado.Text = $"✅ Empleado ID {empleado.IdEmpleado} actualizado\r\n" + txtResultado.Text;
                    MessageBox.Show("Empleado actualizado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnListar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                txtResultado.Text = $"❌ ERROR: {ex.Message}\r\n" + txtResultado.Text;
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prueba eliminar el último empleado de la lista
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un empleado del grid para eliminar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el empleado seleccionado
                Empleado empleado = (Empleado)dgvEmpleados.SelectedRows[0].DataBoundItem;

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de eliminar a {empleado.NombreCompleto}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool resultado = empleadoDAO.Eliminar(empleado.IdEmpleado);

                    if (resultado)
                    {
                        txtResultado.Text = $"✅ Empleado ID {empleado.IdEmpleado} eliminado\r\n" + txtResultado.Text;
                        MessageBox.Show("Empleado eliminado exitosamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnListar_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                txtResultado.Text = $"❌ ERROR: {ex.Message}\r\n" + txtResultado.Text;
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga inicial del formulario
        /// </summary>
        private void FrmPruebaEmpleadoDAO_Load(object sender, EventArgs e)
        {
            // Cargar empleados al iniciar
            btnListar_Click(null, null);
        }
    }
}
