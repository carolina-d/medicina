using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.ConsultaPaciente.Entidades.Validaciones;
namespace Dominio.ConsultaPaciente.Entidades

{   
    
    [Table("Certificado")]
    [MetadataType(typeof(IValidacionCertificado))]
    public class Certificado:Entidad
 
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        
    }
}
