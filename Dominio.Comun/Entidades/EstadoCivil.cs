using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.Comun.Entidades.Validaciones;

namespace Dominio.Comun.Entidades
{
    [Table("EstadoCivil")]
    [MetadataType(typeof(IValidacionEstadoCivil))]
    public class EstadoCivil : Entidad
    {
        // Propiedades
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
