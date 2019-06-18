using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionCalendarioVacunacion
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        int VacunaId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int DosisId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int Anio { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int Mes { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int Dia { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Obligatoria { get; set; }
    }
}
