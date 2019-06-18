using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;

namespace Dominio.Seguridad.Entidades.Vistas
{
    [Table("vwEmpleadoUsuario")]
    public class VwEmpleadoUsuario : Entidad
    {
        public int EmpleadoId { get; set; }
        
        public int UsuarioId { get; set; }
        
        public string ApyNom { get; set; }
        public string Dni { get; set; }

        public string NombreUsuario { get; set; }

        public string EstaBloqueado { get; set; }
        public string EstaEliminado { get; set; }
    }
}
