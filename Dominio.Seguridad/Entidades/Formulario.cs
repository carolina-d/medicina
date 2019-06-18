using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.Seguridad.Entidades.Validaciones;

namespace Dominio.Seguridad.Entidades
{
    [Table("Formulario")]
    [MetadataType(typeof(IValidacionFormulario))]
    public class Formulario : Entidad
    {
        // Propiedades
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }

        // Propiedades de Navegacion
        public virtual ICollection<Perfil> Perfiles { get; set; }
    }
}
