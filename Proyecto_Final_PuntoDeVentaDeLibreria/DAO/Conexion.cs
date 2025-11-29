using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.DAO
{
    internal class Conexion
    {
        private readonly string cadena = "Server=localhost;Database=VENTAS;Uid=root;Pwd=Tacodeguayaba16;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(cadena);
        }

        private MySqlConnection conn;

        public Conexion()
        {
            conn = new MySqlConnection("Server=localhost;Database=VENTAS;Uid=root;Pwd=Tacodeguayaba16;");
        }

        public MySqlConnection Abrir()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public void Cerrar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
