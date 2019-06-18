using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.RecursosHumanos.DTOs
{
    public class EmpresaDTO
    {
        public int Id { get; set; }
        
        public string RazonSocial { get; set; }
        public string NombreFantasia { get; set; }
        public string Telefono { get; set; }

        public int CantidadEmpleado { get; set; }
    }
}
