using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ConsultaPaciente.Entidades.Validaciones
{
    public interface IValidacionMedicamentoRecetado
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        int ConsultaId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        int VademecumId { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string NombreMedicamento { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Indicaciones { get; set; }
    }
}
