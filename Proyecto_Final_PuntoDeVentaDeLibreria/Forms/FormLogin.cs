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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DAOUsuarios dao = new DAOUsuarios();

            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.");
                return;
            }

            string rol = dao.Login(usuario, contrasena);

            if (rol == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
            else
            {
                MessageBox.Show("Bienvenido: " + rol);

                if (rol == "admin")
                {
                    new FormMenuAdmin().Show();
                }
                else
                {
                    new FormMenuEmpleado().Show();
                }

                this.Hide();
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío si no necesitas manejar el evento ahora
            // o poner validaciones mínimas como:
            // btnIngresar.Enabled = !string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContrasena.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
