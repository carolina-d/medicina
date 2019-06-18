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
    [Table("Empleado")]
    [MetadataType(typeof(IValidacionEmpleado))]
    public class Empleado : Entidad
    {
        // Propiedades
        
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        [NotMapped]
        public string ApyNom
        {
            get { return string.Format("{0} {1}", Apellido, Nombre); }
        }

        public string Dni { get; set; }

        public string Telefono { get; set; }
        public string Celular { get; set; }

        public string MatriculaProvincial { get; set; }
        public string MatriculaNacional { get; set; }

        public byte[] FotoEmpleado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }

        public string Mail { get; set; }

        public int EspecialidadId { get; set; }
        
        // Propiedad de Navegación
        public virtual Especialidad Especialidad { get; set; }
        public virtual ICollection<Empresa> Empresas { get; set; }
    }
}
