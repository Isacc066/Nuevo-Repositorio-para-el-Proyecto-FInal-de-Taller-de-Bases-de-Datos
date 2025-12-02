using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.DAO
{
    internal class AuditoriaDAO
    {
        private readonly Conexion conexion;

        public AuditoriaDAO()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Lista todos los registros de auditoría
        /// Ordenados del más reciente al más antiguo
        /// </summary>
        public List<AuditoriaProducto> ListarTodos()
        {
            var lista = new List<AuditoriaProducto>();

            try
            {
                var conn = conexion.Abrir();
                string query = @"SELECT idAuditoria, fechaHora, accion, idProducto, 
                                       usuario, valoresAnteriores, valoresNuevos 
                                FROM auditoria_productos 
                                ORDER BY fechaHora DESC";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var auditoria = new AuditoriaProducto
                    {
                        IdAuditoria = reader.GetInt32("idAuditoria"),
                        FechaHora = reader.GetDateTime("fechaHora"),
                        Accion = reader.GetString("accion"),
                        IdProducto = reader.IsDBNull(reader.GetOrdinal("idProducto"))
                            ? null
                            : reader.GetInt32("idProducto"),
                        Usuario = reader.IsDBNull(reader.GetOrdinal("usuario"))
                            ? ""
                            : reader.GetString("usuario"),
                        ValoresAnteriores = reader.IsDBNull(reader.GetOrdinal("valoresAnteriores"))
                            ? null
                            : reader.GetString("valoresAnteriores"),
                        ValoresNuevos = reader.IsDBNull(reader.GetOrdinal("valoresNuevos"))
                            ? null
                            : reader.GetString("valoresNuevos")
                    };
                    lista.Add(auditoria);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar auditoría: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }

            return lista;
        }

        /// <summary>
        /// Filtra auditoría por tipo de acción
        /// </summary>
        public List<AuditoriaProducto> FiltrarPorAccion(string accion)
        {
            var lista = new List<AuditoriaProducto>();

            try
            {
                var conn = conexion.Abrir();
                string query = @"SELECT idAuditoria, fechaHora, accion, idProducto, 
                                       usuario, valoresAnteriores, valoresNuevos 
                                FROM auditoria_productos 
                                WHERE accion = @accion
                                ORDER BY fechaHora DESC";

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accion", accion);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var auditoria = new AuditoriaProducto
                    {
                        IdAuditoria = reader.GetInt32("idAuditoria"),
                        FechaHora = reader.GetDateTime("fechaHora"),
                        Accion = reader.GetString("accion"),
                        IdProducto = reader.IsDBNull(reader.GetOrdinal("idProducto"))
                            ? null
                            : reader.GetInt32("idProducto"),
                        Usuario = reader.IsDBNull(reader.GetOrdinal("usuario"))
                            ? ""
                            : reader.GetString("usuario"),
                        ValoresAnteriores = reader.IsDBNull(reader.GetOrdinal("valoresAnteriores"))
                            ? null
                            : reader.GetString("valoresAnteriores"),
                        ValoresNuevos = reader.IsDBNull(reader.GetOrdinal("valoresNuevos"))
                            ? null
                            : reader.GetString("valoresNuevos")
                    };
                    lista.Add(auditoria);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar auditoría: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }

            return lista;
        }

        /// <summary>
        /// Filtra auditoría por rango de fechas
        /// </summary>
        public List<AuditoriaProducto> FiltrarPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = new List<AuditoriaProducto>();

            try
            {
                var conn = conexion.Abrir();
                string query = @"SELECT idAuditoria, fechaHora, accion, idProducto, 
                                       usuario, valoresAnteriores, valoresNuevos 
                                FROM auditoria_productos 
                                WHERE DATE(fechaHora) BETWEEN @fechaInicio AND @fechaFin
                                ORDER BY fechaHora DESC";

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Date);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var auditoria = new AuditoriaProducto
                    {
                        IdAuditoria = reader.GetInt32("idAuditoria"),
                        FechaHora = reader.GetDateTime("fechaHora"),
                        Accion = reader.GetString("accion"),
                        IdProducto = reader.IsDBNull(reader.GetOrdinal("idProducto"))
                            ? null
                            : reader.GetInt32("idProducto"),
                        Usuario = reader.IsDBNull(reader.GetOrdinal("usuario"))
                            ? ""
                            : reader.GetString("usuario"),
                        ValoresAnteriores = reader.IsDBNull(reader.GetOrdinal("valoresAnteriores"))
                            ? null
                            : reader.GetString("valoresAnteriores"),
                        ValoresNuevos = reader.IsDBNull(reader.GetOrdinal("valoresNuevos"))
                            ? null
                            : reader.GetString("valoresNuevos")
                    };
                    lista.Add(auditoria);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar por fechas: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }

            return lista;
        }

        /// <summary>
        /// Busca auditoría de un producto específico
        /// </summary>
        public List<AuditoriaProducto> FiltrarPorProducto(int idProducto)
        {
            var lista = new List<AuditoriaProducto>();

            try
            {
                var conn = conexion.Abrir();
                string query = @"SELECT idAuditoria, fechaHora, accion, idProducto, 
                                       usuario, valoresAnteriores, valoresNuevos 
                                FROM auditoria_productos 
                                WHERE idProducto = @idProducto
                                ORDER BY fechaHora DESC";

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var auditoria = new AuditoriaProducto
                    {
                        IdAuditoria = reader.GetInt32("idAuditoria"),
                        FechaHora = reader.GetDateTime("fechaHora"),
                        Accion = reader.GetString("accion"),
                        IdProducto = reader.GetInt32("idProducto"),
                        Usuario = reader.IsDBNull(reader.GetOrdinal("usuario"))
                            ? ""
                            : reader.GetString("usuario"),
                        ValoresAnteriores = reader.IsDBNull(reader.GetOrdinal("valoresAnteriores"))
                            ? null
                            : reader.GetString("valoresAnteriores"),
                        ValoresNuevos = reader.IsDBNull(reader.GetOrdinal("valoresNuevos"))
                            ? null
                            : reader.GetString("valoresNuevos")
                    };
                    lista.Add(auditoria);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al filtrar por producto: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }

            return lista;
        }
    }
}
