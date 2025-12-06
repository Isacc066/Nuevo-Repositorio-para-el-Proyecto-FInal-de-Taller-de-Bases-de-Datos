using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    internal class ReporteProductoVendido
    {
        public string ISBN { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Costo { get; set; }
        public int UnidadesVendidas { get; set; }

        // Propiedad calculada para mostrar el costo formateado
        public string CostoFormateado => Costo.ToString("C2");

        // Propiedad calculada para el total vendido
        public decimal TotalVendido => Costo * UnidadesVendidas;
        public string TotalVendidoFormateado => TotalVendido.ToString("C2");
    }
}
