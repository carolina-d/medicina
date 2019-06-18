using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;

namespace Dominio.Seguridad.Entidades.Vistas
{
    [Table("vwAccesoSistema")]
    public class vwAccesoSistema : Entidad
    {
        public string DescripcionLarga { get; set; }
        public string NombreUsuario { get; set; }
    }
}
