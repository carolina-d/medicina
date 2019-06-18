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
    [Table("Vacuna")]
    [MetadataType(typeof(IValidacionVacuna))]
    public class Vacuna : Entidad
    {
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }

        public virtual ICollection<CalendarioVacunacion> CalendarioVacunaciones { get; set; }
    }
}
