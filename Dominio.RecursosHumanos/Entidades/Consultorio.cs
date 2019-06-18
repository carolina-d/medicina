using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.RecursosHumanos.Entidades.Validaciones;
using Dominio.Base;

namespace Dominio.RecursosHumanos.Entidades
{
        [Table("Consultorio")]
        [MetadataType(typeof(IValidacionConsultorio))]
        public class Consultorio : Entidad
        {
            public int Numero { get; set; }
            public string Descripcion { get; set; }
        }
}
