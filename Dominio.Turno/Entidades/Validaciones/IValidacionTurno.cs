using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Turnos.Entidades.Validaciones
{
    public interface IValidacionTurno
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
         int PacienteId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
         int EmpleadoId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
         int EstadoTurnoId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
         int EstadoPagoConsutaId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
         bool PrimeraVez { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
         decimal CantidadAbonada { get; set; }
    }
}
