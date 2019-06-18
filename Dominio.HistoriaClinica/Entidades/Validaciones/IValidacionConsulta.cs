using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ConsultaPaciente.Entidades.Validaciones
{
       
     
    public interface  IValidacionConsulta
    
    {   
        [Required(ErrorMessage = "Campo Obligatorio")]
        int MotivoConsultaId { get; set; }
       
        [Required(ErrorMessage = "Campo Obligatorio")]
        DateTime Fecha { get; set; }

       
        [Required(ErrorMessage = "Campo Obligatorio")]
        int PacienteId { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string DiagnosticoPresunto { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string DiagnosticoConfirmado { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        int EmpleadoId { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
         string Obsevacones { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int CertificadoId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        int EstudioPedidoId { get; set; }
    }
}
