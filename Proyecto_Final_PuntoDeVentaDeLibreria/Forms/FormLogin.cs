using Proyecto_Final_PuntoDeVentaDeLibreria.Dao;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;

namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            //IT'S HERE
            // Evento eliminado, requerido por el diseñador
            try
            {
                Conexion c = new Conexion();
                c.Abrir();
                MessageBox.Show("Conexión exitosa");
                c.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento eliminado, requerido por el diseñador
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Evento eliminado, requerido por el diseñador
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Método requerido por el diseñador
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DAOUsuarios dao = new DAOUsuarios();

                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
                {
                    MessageBox.Show("Debe ingresar usuario y contraseña.");
                    return;
                }

                string contrasenaHash = Seguridad.HashSHA256(contrasena);

                Usuario? u = dao.Login(usuario, contrasenaHash);

                if (u == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return;
                }

                MessageBox.Show("Bienvenido, " + u.NombreUsuario);

                if (u.Rol == "admin")
                {
                    new FormMenuAdmin(u.IdUsuario).Show();
                }
                else
                {
                    new FormMenuEmpleado(u.IdUsuario).Show();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el Login: " + ex.Message);
            }
        }


    }
}
