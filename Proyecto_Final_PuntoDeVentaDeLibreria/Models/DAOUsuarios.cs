using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.Dao;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    internal class DAOUsuarios
    {
        private Conexion conexion;

        public DAOUsuarios()
        {
            conexion = new Conexion();
        }

        public Usuario? Login(string usuario, string contrasenaHash)
        {
            Usuario? u = null;

            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand(
                    "SELECT * FROM usuarios WHERE usuario=@u AND contrasena=@c", conn);

                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", contrasenaHash);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    u = new Usuario
                    {
                        IdUsuario = reader.GetInt32("idUsuario"),
                        NombreUsuario = reader.GetString("usuario"),
                        Contrasena = reader.GetString("contrasena"),
                        Rol = reader.GetString("rol")
                    };
                }
            }
            finally
            {
                conexion.Cerrar();
            }

            return u;
        }
    }
}
