using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ConsultaPaciente.Entidades.Validaciones
{
    public interface  IValidacionEstudioRealizado
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Consulta { get; set; }

      
        [Required(ErrorMessage = "Campo Obligatorio")]
        String Foto { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Obsevaciones { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Resultado { get; set; }


        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        DateTime FechaDeRealizado { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Valores { get; set; }

    }
}
