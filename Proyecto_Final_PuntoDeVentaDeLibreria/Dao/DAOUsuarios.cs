using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Dao
{
    internal class DAOUsuarios
    {
        private Conexion conexion;

        public DAOUsuarios()
        {
            conexion = new Conexion();
        }

        public string Login(string usuario, string contrasena)
        {
            string hash = Seguridad.HashSHA256(contrasena);

            string query = "SELECT rol FROM usuarios WHERE usuario = @user AND contrasena = @pass LIMIT 1";

            try
            {
                using (MySqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", usuario);
                    cmd.Parameters.AddWithValue("@pass", hash);

                    var rol = cmd.ExecuteScalar();

                    if (rol != null)
                        return rol.ToString();   // admin o empleado
                    else
                        return null;             // NO existe
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
