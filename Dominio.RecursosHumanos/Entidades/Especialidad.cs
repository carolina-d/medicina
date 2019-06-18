using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.RecursosHumanos.Entidades.Validaciones;

namespace Dominio.RecursosHumanos.Entidades
{
    [Table("Especialidad")]
    [MetadataType(typeof(IValidacionEspecialidad))]
    public class Especialidad : Entidad
    {
        // Propiedades
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        // Propiedades de Navegacion
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
