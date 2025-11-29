using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.DAO;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    /// <summary>
    /// Clase de acceso a datos para Empleados usando Stored Procedures
    /// </summary>

    internal class EmpleadoDAO
    {
        /// <summary>
        /// Inserta un nuevo empleado usando stored procedure
        /// </summary>
        /// <param name="empleado">Objeto empleado con los datos</param>
        /// <returns>True si se insertó correctamente</returns>
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
                cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion); // ← NUEVA LÍNEA

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
        /// Actualiza un empleado existente usando stored procedure
        /// </summary>
        /// <param name="empleado">Objeto empleado con los datos actualizados</param>
        /// <returns>True si se actualizó correctamente</returns>
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
                cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion); // ← NUEVA LÍNEA

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
        /// Elimina un empleado usando stored procedure
        /// </summary>
        /// <param name="idEmpleado">ID del empleado a eliminar</param>
        /// <returns>True si se eliminó correctamente</returns>
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
        /// Lista todos los empleados usando stored procedure
        /// </summary>
        /// <returns>Lista de empleados</returns>
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
        /// Busca un empleado por ID
        /// </summary>
        /// <param name="idEmpleado">ID del empleado</param>
        /// <returns>Objeto Empleado o null si no existe</returns>
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
