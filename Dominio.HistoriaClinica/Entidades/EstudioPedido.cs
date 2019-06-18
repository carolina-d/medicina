using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.ConsultaPaciente.Entidades.Validaciones;

namespace Dominio.ConsultaPaciente.Entidades
{

     [Table ("Estudios Pedidos")]
     [MetadataType(typeof(IValidacionEstudioPedido))]
      public class EstudioPedido: Entidad
      {         
          public string NombreEstudio { get; set; }
          public int TipoEstudioId { get; set; }
          public string Obsevaciones { get; set; }
          public string Ubicacion { get; set; } 
    }
}
