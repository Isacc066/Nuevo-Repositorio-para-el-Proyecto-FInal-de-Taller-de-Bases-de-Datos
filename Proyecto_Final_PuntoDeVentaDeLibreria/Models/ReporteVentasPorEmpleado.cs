using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    /// <summary>
    /// Modelo para el reporte de ventas por usuario/empleado
    /// Muestra las ventas realizadas por cada usuario del sistema
    /// </summary>
    internal class ReporteVentasPorEmpleado
    {
        public int Clave { get; set; }              // idUsuario
        public string Nombre { get; set; } = string.Empty;  // usuario (nombre de usuario)
        public decimal MontoVendido { get; set; }
        public int NumeroVentas { get; set; }

        // Propiedad calculada para mostrar el monto formateado
        public string MontoVendidoFormateado => MontoVendido.ToString("C2");

        // Propiedad calculada para el promedio por venta
        public decimal PromedioPorVenta => NumeroVentas > 0 ? MontoVendido / NumeroVentas : 0;
        public string PromedioPorVentaFormateado => PromedioPorVenta.ToString("C2");

        // Propiedad para mostrar ID + Nombre juntos
        public string UsuarioCompleto => $"[{Clave}] {Nombre}";
    }
}
