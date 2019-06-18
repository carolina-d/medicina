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
    [Table("MedicamentosRecetados")]
    [MetadataType(typeof(IValidacionMedicamentoRecetado))]
    public class MedicamentoRecetado:Entidad
    {

        
       public int ConsultaId { get; set; }
  
        public int VademecumId { get; set; }
        
       public string NombreMedicamento { get; set; }
    
       public string Indicaciones { get; set; }
    }
}
