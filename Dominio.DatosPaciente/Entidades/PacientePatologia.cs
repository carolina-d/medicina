using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.DatosPaciente.Entidades.Validaciones;

namespace Dominio.DatosPaciente.Entidades
{
    [Table("PacientePatologia")]
    [MetadataType(typeof(IValidacionPacientePatologia))]
    public class PacientePatologia : Entidad
    {
        // Propiedades
        public int PatologiaId { get; set; }
        public int PacienteId { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string Observacion { get; set; }

        // Propiedades de Navegacion
        public virtual Patologia Patologia { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
