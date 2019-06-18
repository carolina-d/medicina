using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionPlanVacunacion
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        int PacienteId { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        int CalendarioVacunacionId { get; set; }
        
        //[Required(ErrorMessage = "Campo Obligatorio")]
        //DateTime FechaPlan { get; set; }
        
        //DateTime FechaReal { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Estado { get; set; }

        string Observacion { get; set; }
    }
}
