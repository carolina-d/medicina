using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.RecursosHumanos.Entidades.Validaciones
{
    interface IValidacionConsultorio
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Descripcion { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Numero { get; set; }
    }
}
