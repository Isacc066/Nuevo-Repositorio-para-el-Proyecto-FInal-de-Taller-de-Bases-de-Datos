using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    internal class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Propiedades conveniencia para mostrar en el grid:
        public string NombreProducto { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
