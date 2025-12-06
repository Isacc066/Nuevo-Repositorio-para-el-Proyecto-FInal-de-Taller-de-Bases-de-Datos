using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    /// <summary>
    /// Modelo que representa una venta en el sistema
    /// </summary>
    internal class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }

        // Propiedades adicionales para mostrar información relacionada
        public string NombreUsuario { get; set; } = string.Empty;

        // Propiedades calculadas
        public string TotalFormateado => Total.ToString("C2");
        public string FechaFormateada => Fecha.ToString("dd/MM/yyyy HH:mm");
        public string FechaCorta => Fecha.ToString("dd/MM/yyyy");
    }
}
