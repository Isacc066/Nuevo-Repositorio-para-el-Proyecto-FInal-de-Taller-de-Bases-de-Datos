using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.DAO
{
    /// <summary>
    /// CLASE DE ACCESO A DATOS PARA EMPLEADOS USANDO PROCEDIMIENTOS ALMACENADOS
    /// </summary>

    internal class EmpleadoDAO
    {
        /// <summary>
        /// INSERTA UN NUEVO EMPLEADO USANDO STORED PROCEDURE
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Insertar(Empleado empleado)
        {
            Conexion conexion = new Conexion();
            try
            {
                MySqlConnection conn = conexion.Abrir();
                MySqlCommand cmd = new MySqlCommand("spInsertarEmpleado", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Parámetros del stored procedure
                cmd.Parameters.AddWithValue("pNombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("pApellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("pTelefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar empleado: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// ACTUALIZA UN EMPLEADO EXISTENTE USANDO STORED PROCEUDRE
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Actualizar(Empleado empleado)
        {
            Conexion conexion = new Conexion();
            try
            {
                MySqlConnection conn = conexion.Abrir();
                MySqlCommand cmd = new MySqlCommand("spActualizarEmpleado", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Parámetros del stored procedure
                cmd.Parameters.AddWithValue("pId", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("pNombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("pApellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("pTelefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar empleado: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// ELIMINA UN NEMPLEADO USANDO STORED PROCEDURE
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Eliminar(int idEmpleado)
        {
            Conexion conexion = new Conexion();
            try
            {
                MySqlConnection conn = conexion.Abrir();
                MySqlCommand cmd = new MySqlCommand("spEliminarEmpleado", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("pId", idEmpleado);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar empleado: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        /// <summary>
        /// LISTA TODOS LOS EMPLEADOS USANDO STORED PROCEDURE
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Empleado> ListarTodos()
        {
            List<Empleado> empleados = new List<Empleado>();
            Conexion conexion = new Conexion();

            try
            {
                MySqlConnection conn = conexion.Abrir();
                MySqlCommand cmd = new MySqlCommand("spListarEmpleados", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Empleado emp = new Empleado
                        {
                            IdEmpleado = reader.GetInt32("idEmpleado"),
                            Nombre = reader.GetString("nombre"),
                            Apellido = reader.IsDBNull(reader.GetOrdinal("apellido"))
                                ? "" : reader.GetString("apellido"),
                            Telefono = reader.IsDBNull(reader.GetOrdinal("telefono"))
                                ? "" : reader.GetString("telefono"),
                            Direccion = reader.IsDBNull(reader.GetOrdinal("direccion"))
                                ? "" : reader.GetString("direccion")
                        };
                        empleados.Add(emp);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar empleados: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }

            return empleados;
        }

        /// <summary>
        /// BUSCA UN EMPLEADO POR ID
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Empleado ObtenerPorId(int idEmpleado)
        {
            Empleado empleado = null;
            Conexion conexion = new Conexion();

            try
            {
                MySqlConnection conn = conexion.Abrir();
                string query = "SELECT * FROM empleados WHERE idEmpleado = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idEmpleado);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        empleado = new Empleado
                        {
                            IdEmpleado = reader.GetInt32("idEmpleado"),
                            Nombre = reader.GetString("nombre"),
                            Apellido = reader.IsDBNull(reader.GetOrdinal("apellido"))
                                ? "" : reader.GetString("apellido"),
                            Telefono = reader.IsDBNull(reader.GetOrdinal("telefono"))
                                ? "" : reader.GetString("telefono"),
                            Direccion = reader.IsDBNull(reader.GetOrdinal("direccion"))
                                ? "" : reader.GetString("direccion")
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener empleado: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }

            return empleado;
        }
    }
}