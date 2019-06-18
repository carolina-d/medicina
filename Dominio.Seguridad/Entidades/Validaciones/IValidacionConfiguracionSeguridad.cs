using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Seguridad.Entidades.Validaciones
{
    public interface IValidacionConfiguracionSeguridad
    {
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string PasswordDefecto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool RequerirCambioPassword { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int CantMaximoCaracteres { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int CantMinimoCaracteres { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int CantMayusculas { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int CantMinusculas { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int CantNumeros { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int CantSimbolos { get; set; }
    }
}
