using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        // --------------------------------------------------------
        // INSERTAR
        // --------------------------------------------------------
        public bool Insertar(Empleado empleado)
        {
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spInsertarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pNombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("pApellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("pTelefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar empleado: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // --------------------------------------------------------
        // ACTUALIZAR
        // --------------------------------------------------------
        public bool Actualizar(Empleado empleado)
        {
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spActualizarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pId", empleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("pNombre", empleado.Nombre);
                    cmd.Parameters.AddWithValue("pApellido", empleado.Apellido);
                    cmd.Parameters.AddWithValue("pTelefono", empleado.Telefono);
                    cmd.Parameters.AddWithValue("pDireccion", empleado.Direccion);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar empleado: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // --------------------------------------------------------
        // ELIMINAR
        // --------------------------------------------------------
        public bool Eliminar(int idEmpleado)
        {
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spEliminarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("pId", idEmpleado);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // --------------------------------------------------------
        // LISTAR TODOS
        // --------------------------------------------------------
        public List<Empleado> ListarTodos()
        {
            List<Empleado> empleados = new List<Empleado>();
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                using (var cmd = new MySqlCommand("spListarEmpleados", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleados.Add(new Empleado
                            {
                                IdEmpleado = reader.GetInt32("idEmpleado"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.IsDBNull(reader.GetOrdinal("apellido"))
                                            ? "" : reader.GetString("apellido"),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("telefono"))
                                            ? "" : reader.GetString("telefono"),
                                Direccion = reader.IsDBNull(reader.GetOrdinal("direccion"))
                                            ? "" : reader.GetString("direccion")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al listar empleados: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return empleados;
        }

        // --------------------------------------------------------
        // OBTENER POR ID
        // --------------------------------------------------------
        public Empleado ObtenerPorId(int idEmpleado)
        {
            Empleado empleado = null;
            Conexion conexion = new Conexion();

            try
            {
                var conn = conexion.Abrir();

                string query = "SELECT * FROM empleados WHERE idEmpleado = @id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);

                    using (var reader = cmd.ExecuteReader())
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
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al obtener empleado por ID: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            return empleado;
        }
    }
}