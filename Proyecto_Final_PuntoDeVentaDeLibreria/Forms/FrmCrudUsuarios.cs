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
using Proyecto_Final_PuntoDeVentaDeLibreria.Dao;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    public partial class FrmCrudUsuarios : Form
    {
        private readonly DAOUsuarios dao;

        public FrmCrudUsuarios()
        {
            InitializeComponent();

            dao = new DAOUsuarios();

            txtIdUsuario.Enabled = false; // No se edita el ID
            ConfigurarComboRol();
            ConfigurarDataGrid();
        }

        // ==========================================
        // CONFIGURACIÓN INICIAL
        // ==========================================
        private void ConfigurarComboRol()
        {
            cboRol.Items.Clear();
            cboRol.Items.Add("admin");
            cboRol.Items.Add("empleado");
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.SelectedIndex = 0;
        }

        private void ConfigurarDataGrid()
        {
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.AutoGenerateColumns = false;

            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdUsuario",
                Name = "IdUsuario",
                HeaderText = "ID",
                Width = 60
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreUsuario",
                Name = "NombreUsuario",
                HeaderText = "Usuario",
                Width = 200
            });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Rol",
                Name = "Rol",
                HeaderText = "Rol",
                Width = 100
            });
        }

        // ==========================================
        // CARGAR USUARIOS EN EL DGV
        // ==========================================
        private void ListarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = dao.Listar();
            dgvUsuarios.ClearSelection();
        }

        private void FrmCrudUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        // ==========================================
        // BOTÓN AGREGAR
        // ==========================================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Debe llenar usuario y contraseña.");
                return;
            }

            Usuario u = new Usuario
            {
                NombreUsuario = txtUsuario.Text.Trim(),
                Contrasena = Seguridad.HashSHA256(txtContrasena.Text.Trim()),
                Rol = cboRol.SelectedItem.ToString()
            };

            if (dao.Insertar(u))
            {
                MessageBox.Show("Usuario insertado correctamente.");
                ListarUsuarios();
                Limpiar();
            }
        }

        // ==========================================
        // BOTÓN ACTUALIZAR
        // ==========================================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            Usuario u = new Usuario
            {
                IdUsuario = int.Parse(txtIdUsuario.Text),
                NombreUsuario = txtUsuario.Text.Trim(),
                Contrasena = Seguridad.HashSHA256(txtContrasena.Text.Trim()),
                Rol = cboRol.SelectedItem.ToString()
            };

            if (dao.Actualizar(u))
            {
                MessageBox.Show("Usuario actualizado.");
                ListarUsuarios();
                Limpiar();
            }
        }

        // ==========================================
        // BOTÓN ELIMINAR
        // ==========================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id = int.Parse(txtIdUsuario.Text);

            if (MessageBox.Show("¿Seguro que desea eliminar?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dao.Eliminar(id))
                {
                    MessageBox.Show("Usuario eliminado.");
                    ListarUsuarios();
                    Limpiar();
                }
            }
        }

        // ==========================================
        // CUANDO SE HACE CLIC EN UNA FILA DEL GRID
        // ==========================================
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtIdUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
            txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
            cboRol.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString();

            txtContrasena.Text = ""; // Nunca se muestra
        }

        // ==========================================
        // LIMPIAR CAMPOS
        // ==========================================
        private void Limpiar()
        {
            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            cboRol.SelectedIndex = 0;
            dgvUsuarios.ClearSelection();
        }
    }
}
