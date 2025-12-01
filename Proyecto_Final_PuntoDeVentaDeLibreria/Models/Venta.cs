using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    internal class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }
    }
}
