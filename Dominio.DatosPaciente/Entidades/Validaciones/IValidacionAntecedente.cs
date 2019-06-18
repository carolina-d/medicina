using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionAntecedente
    {

        [Range(1, 999999, ErrorMessage = "El valor debe estar entre 1 y 999999")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Codigo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        string AntecedentesPersonales { get; set; }

        //[Required(ErrorMessage = "Campo Obligatorio")]
        //DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int ParienteId { get; set; }
    }
}
