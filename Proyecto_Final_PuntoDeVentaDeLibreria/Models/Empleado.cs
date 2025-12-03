using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_PuntoDeVentaDeLibreria.Models
{
    /// <summary>
    /// MODELO QUE REPRESENTA UN EMPLEADO DE LA LIBRERÍA
    /// </summary>

    internal class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}