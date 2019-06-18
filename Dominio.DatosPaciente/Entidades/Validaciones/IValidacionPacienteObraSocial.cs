using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionPacienteObraSocial
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        string NumeroAfiliado { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int PacienteId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int ObraSocialId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        string PlanObraSocial { get; set; }

    }
}
