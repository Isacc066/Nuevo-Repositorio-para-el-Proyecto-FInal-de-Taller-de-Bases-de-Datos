using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Final_PuntoDeVentaDeLibreria.Models;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.DAO
{
    internal class ReporteDAO
    {
        private readonly Conexion conexion;

        public ReporteDAO()
        {
            conexion = new Conexion();
        }

        /// <summary>
        /// Obtiene el total de ventas de una fecha específica
        /// Usa la función fnTotalVentasPorFecha
        /// </summary>
        public decimal ObtenerTotalVentasPorFecha(DateTime fecha)
        {
            decimal total = 0m;
            try
            {
                var conn = conexion.Abrir();
                string query = "SELECT fnTotalVentasPorFecha(@fecha) AS total";

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);

                var resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    total = Convert.ToDecimal(resultado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener total de ventas: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
            return total;
        }

        /// <summary>
        /// Obtiene el total de productos vendidos
        /// Usa la función fnTotalProductosVendidos
        /// </summary>
        public int ObtenerTotalProductosVendidos()
        {
            int total = 0;
            try
            {
                var conn = conexion.Abrir();
                string query = "SELECT fnTotalProductosVendidos() AS total";

                using var cmd = new MySqlCommand(query, conn);
                var resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    total = Convert.ToInt32(resultado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener total de productos vendidos: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
            return total;
        }

        /// <summary>
        /// Obtiene el nombre del producto más vendido
        /// Usa la función fnProductoMasVendido
        /// </summary>
        public string ObtenerProductoMasVendido()
        {
            string producto = "Sin ventas";
            try
            {
                var conn = conexion.Abrir();
                string query = "SELECT fnProductoMasVendido() AS producto";

                using var cmd = new MySqlCommand(query, conn);
                var resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    producto = resultado.ToString() ?? "Sin ventas";
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener producto más vendido: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
            return producto;
        }

        /// <summary>
        /// Obtiene el reporte detallado de todas las ventas
        /// Usa la vista vwReporteVentas
        /// </summary>
        public List<ReporteVenta> ObtenerReporteDetalladoVentas()
        {
            var lista = new List<ReporteVenta>();
            try
            {
                var conn = conexion.Abrir();
                string query = "SELECT * FROM vwReporteVentas";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var reporte = new ReporteVenta
                    {
                        IdVenta = reader.GetInt32("idVenta"),
                        Fecha = reader.GetDateTime("fecha"),
                        UsuarioQueVendio = reader.GetString("usuarioQueVendio"),
                        IdProducto = reader.GetInt32("idProducto"),
                        Producto = reader.GetString("producto"),
                        Cantidad = reader.GetInt32("cantidad"),
                        PrecioUnitario = reader.GetDecimal("precioUnitario"),
                        Subtotal = reader.GetDecimal("subtotal"),
                        Total = reader.GetDecimal("total")
                    };
                    lista.Add(reporte);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener reporte detallado: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
            return lista;
        }

        /// <summary>
        /// Obtiene reporte filtrado por rango de fechas
        /// </summary>
        public List<ReporteVenta> ObtenerReportePorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = new List<ReporteVenta>();
            try
            {
                var conn = conexion.Abrir();
                string query = @"SELECT * FROM vwReporteVentas 
                               WHERE DATE(fecha) BETWEEN @fechaInicio AND @fechaFin
                               ORDER BY fecha DESC";

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date);
                cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Date);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var reporte = new ReporteVenta
                    {
                        IdVenta = reader.GetInt32("idVenta"),
                        Fecha = reader.GetDateTime("fecha"),
                        UsuarioQueVendio = reader.GetString("usuarioQueVendio"),
                        IdProducto = reader.GetInt32("idProducto"),
                        Producto = reader.GetString("producto"),
                        Cantidad = reader.GetInt32("cantidad"),
                        PrecioUnitario = reader.GetDecimal("precioUnitario"),
                        Subtotal = reader.GetDecimal("subtotal"),
                        Total = reader.GetDecimal("total")
                    };
                    lista.Add(reporte);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener reporte por fechas: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
            return lista;
        }

        /// <summary>
        /// Obtiene ventas por ID de venta específico
        /// </summary>
        public List<ReporteVenta> ObtenerVentaPorId(int idVenta)
        {
            var lista = new List<ReporteVenta>();
            try
            {
                var conn = conexion.Abrir();
                string query = "SELECT * FROM vwReporteVentas WHERE idVenta = @idVenta";

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);

                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var reporte = new ReporteVenta
                    {
                        IdVenta = reader.GetInt32("idVenta"),
                        Fecha = reader.GetDateTime("fecha"),
                        UsuarioQueVendio = reader.GetString("usuarioQueVendio"),
                        IdProducto = reader.GetInt32("idProducto"),
                        Producto = reader.GetString("producto"),
                        Cantidad = reader.GetInt32("cantidad"),
                        PrecioUnitario = reader.GetDecimal("precioUnitario"),
                        Subtotal = reader.GetDecimal("subtotal"),
                        Total = reader.GetDecimal("total")
                    };
                    lista.Add(reporte);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar venta: {ex.Message}");
            }
            finally
            {
                conexion.Cerrar();
            }
            return lista;
        }
    }
}
