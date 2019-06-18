using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionVacuna
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        string Abreviatura { get; set; }
    }
}
