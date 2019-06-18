using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Turno.Entidades.Validaciones
{
    public interface IConfiguracionEmpleado
    {
         int EmpleadoId { get; set; }
         decimal MontoParticular { get; set; }
         decimal MontoPrimeraVez { get; set; }
    }
}
