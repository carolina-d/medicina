using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionPaciente
    {
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Apellido { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Nombre { get; set; }

        [MaxLength(10, ErrorMessage = "La cantidad Maxima de Caracteres es de 10")]
        string Dni { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int SexoId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int GrupoSanguineoId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int ObraSocialId { get; set; }

        [MaxLength(400, ErrorMessage = "La cantidad Maxima de Caracteres es de 400")]
        string Domicilio { get; set; }

        [MaxLength(20, ErrorMessage = "La cantidad Maxima de Caracteres es de 20")]
        string Telefono { get; set; }
        
        [MaxLength(20, ErrorMessage = "La cantidad Maxima de Caracteres es de 20")]
        string Celular { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "El mail se encuentra mal escrito")]
        string Mail { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        byte[] Foto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool EsDown { get; set; }

        [MaxLength(20, ErrorMessage = "La cantidad Maxima de Caracteres es de 20")]
        string NumeroAfiliado { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string PlanObraSocial { get; set; }
    }
}
