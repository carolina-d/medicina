using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.RecursosHumanos.Entidades;
using Dominio.Seguridad.Entidades.Validaciones;

namespace Dominio.Seguridad.Entidades
{
    [Table("Usuario")]
    [MetadataType(typeof(IValidacionUsuario))]
    public class Usuario : Entidad
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public bool EstaBloqueado { get; set; }
        public bool EstaEliminado { get; set; }

        public int EmpleadoId { get; set; }
        
        // Propiedades de Navegacion
        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<Perfil>  Perfiles { get; set; }
    }
}
