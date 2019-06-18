using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.RecursosHumanos.Entidades;

namespace Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEmpresa
{
    public interface IEmpleadoEmpresaServicio
    {
        void VincularEmpleadoEmpresa(List<int> listaIdEmpleado, int empresaId);
        void DesvincularEmpleadoEmpresa(List<int> listaIdEmpleado, int empresaId);

        IEnumerable<Empleado> MostrarEmpleadosNoAsignados(int empresaId, string cadena);
        IEnumerable<Empleado> MostrarEmpleadosAsignados(int empresaId, string cadena);
    }
}
