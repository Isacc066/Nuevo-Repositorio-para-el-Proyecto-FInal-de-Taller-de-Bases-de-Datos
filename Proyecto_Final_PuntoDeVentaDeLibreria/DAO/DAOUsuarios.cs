using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.Dao;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.DAO
{
    internal class DAOUsuarios
    {
        private Conexion conexion;

        public DAOUsuarios()
        {
            conexion = new Conexion();
        }

        // -----------------------------
        // LOGIN
        // -----------------------------
        public Usuario? Login(string usuario, string contrasenaHash)
        {
            Usuario? u = null;

            try
            {
                var conn = conexion.Abrir();
                string query = "SELECT * FROM usuarios WHERE usuario=@u AND contrasena=@c";

                using var cmd = new MySqlCommand(query, conn);
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en Login: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return u;
        }

        // -----------------------------
        // LISTAR
        // -----------------------------
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new();

            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spListarUsuarios", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Usuario
                    {
                        IdUsuario = reader.GetInt32("idUsuario"),
                        NombreUsuario = reader.GetString("usuario"),
                        Rol = reader.GetString("rol"),
                        Contrasena = ""
                    });
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al listar usuarios: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return lista;
        }

        // -----------------------------
        // INSERTAR
        // -----------------------------
        public bool Insertar(Usuario u)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spInsertarUsuario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // NOTA: Mantengo EXACTAMENTE tus parámetros
                cmd.Parameters.AddWithValue("@pUsuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@pContrasena", u.Contrasena);
                cmd.Parameters.AddWithValue("@pRol", u.Rol);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar usuario: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // -----------------------------
        // ACTUALIZAR
        // -----------------------------
        public bool Actualizar(Usuario u)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spActualizarUsuario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pId", u.IdUsuario);
                cmd.Parameters.AddWithValue("@pUsuario", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@pContrasena", u.Contrasena);
                cmd.Parameters.AddWithValue("@pRol", u.Rol);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // -----------------------------
        // ELIMINAR
        // -----------------------------
        public bool Eliminar(int id)
        {
            try
            {
                var conn = conexion.Abrir();
                using var cmd = new MySqlCommand("spEliminarUsuario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pId", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar usuario: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
