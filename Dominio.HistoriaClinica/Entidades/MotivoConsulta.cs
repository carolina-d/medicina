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
    [Table("MotivoConsulta")]
    [MetadataType(typeof(IValidacionMotivoConsulta))]
    public class MotivoConsulta:Entidad
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public virtual Consulta Consulta { get; set; }
    }
}
