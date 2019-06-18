using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ConsultaPaciente.Entidades.Validaciones;
using Dominio.Base;



namespace Dominio.ConsultaPaciente.Entidades
{
    
    [Table("Consulta")]
    [MetadataType(typeof(IValidacionConsulta))]
     public class Consulta: Entidad 
    {
        public int MotivoConsultaId{ get; set; }
        public DateTime Fecha { get; set; }
        public int Paciente  { get; set; }
        public string DiagnosticoPresunto { get; set; }
        public string DiagnosticoConfirmado { get; set; }
        public int  Empleado { get; set; }
        public string Observaciones { get; set; }
        public int CertificadoId { get; set; }
        public int EstudioPedidoId { get; set; }

        // Propiedad de Navegación
       
        public virtual ICollection<Certificado> Certificados { get; set; }
        
        public virtual MotivoConsulta MotivoConsulta { get; set; }
    }


}
