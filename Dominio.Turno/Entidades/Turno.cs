using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Dominio.Base;
using Dominio.Turnos.Entidades.Validaciones;

namespace Dominio.Turnos.Entidades
{
    [Table("Turno")]
    [MetadataType(typeof(IValidacionTurno))]
    public class Turno : Entidad
    {
        public int PacienteId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaDelTurno { get; set; }
        public bool EstadoTurnoId { get; set; }
        public bool EstadoPagoConsutaId { get; set; }
        public bool PrimeraVez { get; set; }
        public decimal CantidadAbonada { get; set; }
    }
}
