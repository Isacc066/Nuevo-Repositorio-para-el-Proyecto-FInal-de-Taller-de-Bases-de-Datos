namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
