using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio.RecursosHumanos.Entidades.Validaciones
{
    public interface IValidacionEmpresa
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string RazonSocial { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string NombreFantasia { get; set; }
        
        DateTime FechaInicioActividades { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(20, ErrorMessage = "La cantidad Maxima de Caracteres es de 20")]
        string CuitCuil { get; set; }

        string IngresosBrutos { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(400, ErrorMessage = "La cantidad Maxima de Caracteres es de 400")]
        string Direccion { get; set; }

        [MaxLength(20, ErrorMessage = "La cantidad Maxima de Caracteres es de 20")]
        string Telefono { get; set; }

        byte[] Logo { get; set; }
    }
}
