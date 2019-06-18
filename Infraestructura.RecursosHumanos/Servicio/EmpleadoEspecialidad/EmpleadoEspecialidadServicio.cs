using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.RecursosHumanos.Entidades;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEspecialidad;
using Infraestructura.Base;
using System.Data.Entity;

namespace Infraestructura.RecursosHumanos.Servicio.EmpleadoEspecialidad
{
    public class EmpleadoEspecialidadServicio : IEmpleadoEspecialidadServicio
    {
        private readonly Contexto.ContextoRecursosHumanos _contexto;

        public EmpleadoEspecialidadServicio(Contexto.ContextoRecursosHumanos contexto)
        {
            this._contexto = contexto;
        }

        public void VincularEmpleadoEspecialidad(List<int> listaIdEmpleado, int especialidadId)
        {
            var especialidad = _contexto.ESPECIALIDAD.Find(especialidadId);

            foreach (var empleado in listaIdEmpleado.Select(id => _contexto.EMPLEADO.Single(x => x.Id.Equals(especialidadId))))
            {
                especialidad.Empleados.Add(empleado);
            }
        }

        public void DesvincularEmpleadoEspecialidad(List<int> listaIdEmpleado, int especialidadId)
        {
            var especialidad = _contexto.ESPECIALIDAD.Find(especialidadId);

            foreach (var empleado in listaIdEmpleado.Select(id => _contexto.EMPLEADO.Single(x => x.Id.Equals(especialidadId))))
            {
                especialidad.Empleados.Remove(empleado);
            }
        }

        public IEnumerable<Empleado> MostrarEmpleadosNoAsignados(int especialidadId, string cadena)
        {
            var empleadosAsignados =
                _contexto.ESPECIALIDAD.Include(e => e.Empleados).FirstOrDefault(x => x.Id.Equals(especialidadId)).Empleados;

            var resultado = _contexto.EMPLEADO
                .Except(empleadosAsignados)
                .Where(e => e.Apellido.Contains(cadena)
                            || e.Nombre.Contains(cadena)
                            || e.Dni.Equals(cadena));

            return resultado.ToList();
        }

        public IEnumerable<Empleado> MostrarEmpleadosAsignados(int especialidadId, string cadena)
        {
            var resultado = _contexto.ESPECIALIDAD.Include(e => e.Empleados).FirstOrDefault(x => x.Id.Equals(especialidadId)).Empleados
                .Where(e => e.Apellido.Contains(cadena)
                            || e.Nombre.Contains(cadena)
                            || e.Dni.Equals(cadena));

            return resultado.ToList();
        }
    }
}
