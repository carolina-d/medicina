using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Seguridad.DTOs
{
    public class FormularioDTO
    {
        public int? Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public bool ExisteBase { get; set; }
    }
}
