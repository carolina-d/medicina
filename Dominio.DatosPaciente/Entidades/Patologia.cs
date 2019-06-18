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
    [Table("Patologia")]
    [MetadataType(typeof(IValidacionPatologia))]
    public class Patologia : Entidad
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PacientePatologia> PacientePatologias { get; set; }
    }
}
