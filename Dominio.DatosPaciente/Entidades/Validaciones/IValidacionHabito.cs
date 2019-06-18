using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionHabito
    {

        [Range(1, 999999, ErrorMessage = "El valor debe estar entre 1 y 999999")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Codigo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int PacienteId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Descripcion { get; set; }
    }
}
