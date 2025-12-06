using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.DAO
{
    internal class Conexion
    {
        private readonly string cadena = "Server=localhost;Database=VENTAS;Uid=root;Pwd=Tacodeguayaba16;";
        private MySqlConnection conn;

        public MySqlConnection CrearConexion()
        {
            return new MySqlConnection(cadena);
        }

        public Conexion()
        {
            conn = new MySqlConnection("Server=localhost;Database=VENTAS;Uid=root;Pwd=Tacodeguayaba16;");
        }

        public MySqlConnection Abrir()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la conexión: " + ex.Message);
            }

            return conn;
        }

        public void Cerrar()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cerrar la conexión: " + ex.Message);
            }
        }
    }
}
