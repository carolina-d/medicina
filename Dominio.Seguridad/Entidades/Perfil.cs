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
    [Table("Perfil")]
    [MetadataType(typeof(IValidacionPerfil))]
    public class Perfil : Entidad
    {
        // Propiedades
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        
        // Propiedades de Navegacion
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Formulario> Formularios { get; set; }
    }
}
