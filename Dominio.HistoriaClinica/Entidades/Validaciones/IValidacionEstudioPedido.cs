using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ConsultaPaciente.Entidades.Validaciones
{
    public interface IValidacionEstudioPedido
    {

        [Required(ErrorMessage = "Campo Obligatorio")]
        int Consulta { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string NombreEstudios { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        string TipoEstudioId { get; set; }
      

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Obsevaciones { get; set; }


        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Ubicacion { get; set; } 


    }
}
