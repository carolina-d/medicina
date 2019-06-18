using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.CorreoElectronico.Entidades.Validacion
{
    public interface IValidacionConfiguracionMail
    {
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string NombreUsuario { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Password { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        bool UsaSSL { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string SMTPServer { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio")]
        int OutPort { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string DireccionEnvia { get; set; }
    }
}
