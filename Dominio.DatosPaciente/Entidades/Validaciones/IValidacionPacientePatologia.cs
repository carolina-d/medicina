using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionPacientePatologia
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        int PatologiaId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int PacienteId { get; set; }

        [Range(0, 9999, ErrorMessage = "El valor debe estar entre 0 y 9999")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Anio { get; set; }

        [Range(0, 11, ErrorMessage = "El valor debe estar entre 0 y 11")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Mes { get; set; }

        string Observacion { get; set; }
    }
}
