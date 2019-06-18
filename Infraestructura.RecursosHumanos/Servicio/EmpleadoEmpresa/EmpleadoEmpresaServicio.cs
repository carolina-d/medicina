using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Entidades;
using Infraestructura.RecursosHumanos.Contexto;
using System.Data.Entity;

namespace Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEmpresa
{
    public class EmpleadoEmpresaServicio : IEmpleadoEmpresaServicio
    {
        private readonly ContextoRecursosHumanos _contexto;

        public EmpleadoEmpresaServicio(ContextoRecursosHumanos contexto)
        {
            this._contexto = contexto;
        }

        public void VincularEmpleadoEmpresa(List<int> listaIdEmpleado, int empresaId)
        {
            var empresa = _contexto.EMPRESA.Find(empresaId);

            foreach (var empleado in listaIdEmpleado.Select(id => _contexto.EMPLEADO.Single(x => x.Id.Equals(empresaId))))
            {
                empresa.Empleados.Add(empleado);
            }
        }

        public void DesvincularEmpleadoEmpresa(List<int> listaIdEmpleado, int empresaId)
        {
            var empresa = _contexto.EMPRESA.Find(empresaId);

            foreach (var empleado in listaIdEmpleado.Select(id => _contexto.EMPLEADO.Single(x => x.Id.Equals(empresaId))))
            {
                empresa.Empleados.Remove(empleado);
            }
        }
        
        public IEnumerable<Entidades.Empleado> MostrarEmpleadosNoAsignados(int empresaId, string cadena)
        {
            var empresa = _contexto.EMPRESA.Include(x => x.Empleados).FirstOrDefault(x => x.Id.Equals(empresaId));

            if (empresa != null)
            {
                var resultado = _contexto.EMPLEADO.Except(empresa.Empleados)
                    .Where(x => x.Apellido.Contains(cadena)
                                || x.Nombre.Contains(cadena)
                                || x.Dni.Equals(cadena)).ToList();

                return resultado;
            }
            else
            {
                return _contexto.EMPLEADO.Where(x => x.Apellido.Contains(cadena)
                                                     || x.Nombre.Contains(cadena)
                                                     || x.Dni.Equals(cadena)).ToList();
            }
        }

        public IEnumerable<Entidades.Empleado> MostrarEmpleadosAsignados(int empresaId, string cadena)
        {
            var empresa = _contexto.EMPRESA.Include(x=>x.Empleados).FirstOrDefault(x => x.Id.Equals(empresaId));

            if (empresa != null)
            {
                var resultado = empresa.Empleados.Where(x => x.Apellido.Contains(cadena)
                                                             || x.Nombre.Contains(cadena)
                                                             || x.Dni.Equals(cadena)).ToList();

                return resultado;
            }
            else
            {
                return _contexto.EMPLEADO.Where(x => x.Id.Equals(-1));
            }
        }
    }
}
