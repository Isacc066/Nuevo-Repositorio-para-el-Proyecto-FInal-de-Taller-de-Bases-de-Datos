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

        private void button1_Click(object sender, EventArgs e)
        {
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
            DAOUsuarios dao = new DAOUsuarios();

            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.");
                return;
            }

            // Convertir a hash la contraseña antes de comparar
            string contrasenaHash = Seguridad.HashSHA256(contrasena);

            // Ahora dao.Login devuelve un Usuario completo O null
            Usuario? u = dao.Login(usuario, contrasenaHash);

            if (u == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }

            // Mensaje opcional
            MessageBox.Show("Bienvenido, " + u.NombreUsuario);

            // Abrir menú según el rol
            if (u.Rol == "admin")
            {
                FormMenuAdmin menu = new FormMenuAdmin(u.IdUsuario);
                menu.Show();
            }
            else
            {
                FormMenuEmpleado menu = new FormMenuEmpleado(u.IdUsuario);
                menu.Show();
            }

            this.Hide();
        }
    }
}
