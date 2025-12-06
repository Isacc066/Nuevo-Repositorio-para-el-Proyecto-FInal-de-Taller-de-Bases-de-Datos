
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    internal class AuditoriaProducto
    {
        public int IdAuditoria { get; set; }
        public DateTime FechaHora { get; set; }
        public string Accion { get; set; }  // INSERT, UPDATE, DELETE
        public int? IdProducto { get; set; }
        public string Usuario { get; set; }
        public string ValoresAnteriores { get; set; }
        public string ValoresNuevos { get; set; }
    }
}
