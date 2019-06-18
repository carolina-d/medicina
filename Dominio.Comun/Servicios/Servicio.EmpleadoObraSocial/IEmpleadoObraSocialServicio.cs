using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoObraSocial;
using Dominio.RecursosHumanos.Entidades;

namespace Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoObraSocial
{
    public interface IEmpleadoObraSocialServicio
    {
        void VincularEmpleadoObraSocial(List<int> listaIdEmpleado, int obraSocialId);
        void DesvincularEmpleadoObraSocial(List<int> listaIdEmpleado, int obraSocialId);

        IEnumerable<Empleado> MostrarEmpleadosNoAsignados(int obraSocialId, string cadena);
        IEnumerable<Empleado> MostrarEmpleadosAsignados(int obraSocialId, string cadena);
    }
}
