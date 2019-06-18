using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Turnos.Entidades.Validaciones
{
    public interface IValidacionConsultorio
    {
        int Numero { get; set; }
        string Descripcion { get; set; }
    }
}
