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
    [Table("Sexo")]
    [MetadataType(typeof(IValidacionSexo))]
    public class Sexo : Entidad
    {
        // Propiedades
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
