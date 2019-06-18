using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionEnfermedadCronica
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Descripcion { get; set; }

        //[Required(ErrorMessage = "Campo Obligatorio")]        
        //DateTime Fecha { get; set; }
    }
}
