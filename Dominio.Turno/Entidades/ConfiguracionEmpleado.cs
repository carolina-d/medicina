using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;

namespace Dominio.Turno.Entidades
{
    public class ConfiguracionEmpleado : Entidad
    {
        int EmpleadoId { get; set; }
        DateTime Intervalo { get; set; }
        decimal MontoParticular { get; set; }
        decimal MontoPrimeraVez { get; set; }
        DateTime FechaVigencia { get; set; }
    }
}
