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
    [Table("CalendarioVacunacion")]
    [MetadataType(typeof (IValidacionCalendarioVacunacion))]
    public class CalendarioVacunacion : Entidad
    {
        public int VacunaId { get; set; }
        public int DosisId { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public bool Obligatoria { get; set; }

        public virtual Vacuna Vacuna { get; set; }
        public virtual Dosis Dosis { get; set; }
        public ICollection<PlanVacunacion> PlanVacunaciones { get; set; }
    }
}
