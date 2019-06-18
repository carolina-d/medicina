using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.RecursosHumanos.Entidades.Validaciones
{
    public interface IValidacionEmpleado
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        int EspecialidadId { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Apellido { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Nombre { get; set; }

        [MaxLength(8, ErrorMessage = "La cantidad Maxima de Caracteres es de 8")]
        string Dni { get; set; }

        [MaxLength(20, ErrorMessage = "La cantidad Maxima de Caracteres es de 20")]
        string Telefono { get; set; }

        [MaxLength(20, ErrorMessage = "La cantidad Maxima de Caracteres es de 20")]
        string Celular { get; set; }

        [MaxLength(10, ErrorMessage = "La cantidad Maxima de Caracteres es de 10")]
        string MatriculaProvincial { get; set; }

        [MaxLength(10, ErrorMessage = "La cantidad Maxima de Caracteres es de 10")]
        string MatriculaNacional { get; set; }
    }
}
