using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ConsultaPaciente.Entidades.Validaciones
{
    public interface IValidacionTipoEstudio
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Codigo { get; set;  }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Descripcion { get; set; }
    }
}
