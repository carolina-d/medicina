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
    [Table("PlanVacunacion")]
    [MetadataType(typeof (IValidacionPlanVacunacion))]
    public class PlanVacunacion: Entidad
    {
        public int PacienteId { get; set; }
        public int CalendarioVacunacionId { get; set; }
        public DateTime FechaPlan { get; set; }
        public DateTime? FechaReal { get; set; }
        public bool Estado { get; set; }
        public string Observacion { get; set; }

        public virtual Paciente Paciente { get; set; }
        
        public virtual CalendarioVacunacion CalendarioVacunacion { get; set; }
    }
}
