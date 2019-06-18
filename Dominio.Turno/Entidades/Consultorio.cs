using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Turnos.Entidades.Validaciones;
using Dominio.Base;

namespace Dominio.Turnos.Entidades
{
    [Table("Consultorio")]
    [MetadataType(typeof(IValidacionConsultorio))]
    public class Consultorio:Entidad
    {
        public int Numero { get; set; }
        public string Descripcion { get; set; }
    }
}
