using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.RecursosHumanos.Entidades.Validaciones;

namespace Dominio.RecursosHumanos.Entidades
{
    [Table("Empresa")]
    [MetadataType(typeof(IValidacionEmpresa))]
    public class Empresa : Entidad
    {
        public string RazonSocial { get; set; }
        public string NombreFantasia { get; set; }
        public DateTime FechaInicioActividades { get; set; }
        public string CuitCuil { get; set; }
        public string IngresosBrutos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public byte[] Logo { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; } 
    }
}
