using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Turno.DTOs
{
    public class TurnoDTO
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int EmpleadoId { get; set; }
        public bool EstadoTurnoId { get; set; }
        public bool EstadoPagoConsutaId { get; set; }
        public bool PrimeraVez { get; set; }
        public decimal CantidadAbonada { get; set; }
    }
}
