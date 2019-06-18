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
    [Table("Sintomas")]
    [MetadataType(typeof(IValidacionSintoma))]
    public class Sintoma:Entidad
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }
    }
}
