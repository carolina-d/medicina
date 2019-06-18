using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.Comun.Entidades.Validaciones;
using Dominio.RecursosHumanos.Entidades;

namespace Dominio.Comun.Entidades
{
    [Table("ObraSocial")]
    [MetadataType(typeof(IValidacionObraSocial))]
    public class ObraSocial : Entidad
    {
        // Propiedades
        public int Codigo { get; set; }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
