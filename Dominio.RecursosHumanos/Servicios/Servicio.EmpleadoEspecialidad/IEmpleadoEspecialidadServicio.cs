using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.RecursosHumanos.Entidades;

namespace Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEspecialidad
{
    public interface IEmpleadoEspecialidadServicio
    {
        void VincularEmpleadoEspecialidad(List<int> listaIdEmpleado, int especialidadId);

        void DesvincularEmpleadoEspecialidad(List<int> listaIdEmpleado, int especialidadId);

        IEnumerable<Empleado> MostrarEmpleadosNoAsignados(int empresaId, string cadena);

        IEnumerable<Empleado> MostrarEmpleadosAsignados(int empresaId, string cadena);
    }
}
