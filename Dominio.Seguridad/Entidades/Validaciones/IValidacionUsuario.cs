using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Seguridad.Entidades.Validaciones
{
    public interface IValidacionUsuario
    {
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string NombreUsuario { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Password { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool EstaBloqueado { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool EstaEliminado { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int EmpleadoId { get; set; }
    }
}
