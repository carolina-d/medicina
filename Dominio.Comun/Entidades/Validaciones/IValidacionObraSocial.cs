using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Comun.Entidades.Validaciones
{
    public interface IValidacionObraSocial
    {
        [Range(1, 999999, ErrorMessage = "El valor debe estar entre 1 y 999999")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Codigo { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Descripcion { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Abreviatura { get; set; }
    }
}
