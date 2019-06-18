using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoObraSocial;
using System.Data.Entity;
using Dominio.Base.Repositorios;
using Dominio.Comun.Entidades;
using Infraestructura.Comun.Contexto;
using Infraestructura.RecursosHumanos.Contexto;
using Dominio.RecursosHumanos.Entidades;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoObraSocial;

namespace Infraestructura.Comun.Servicio.EmpleadoObraSocial
{
    public class EmpleadoObraSocialServicio : IEmpleadoObraSocialServicio
    {
        private readonly ContextoComun _contextoComun;
        private readonly ContextoRecursosHumanos _contextoRRHH;

        public EmpleadoObraSocialServicio(ContextoComun contexto)
        {
            this._contextoComun = contexto;
        }

        public EmpleadoObraSocialServicio(ContextoRecursosHumanos contexto)
        {
            this._contextoRRHH = contexto;
        }

        public void VincularEmpleadoObraSocial(List<int> listaIdEmpleado, int obraSocialId)
        {
            var obraSocial = _contextoComun.OBRASOCIAL.Find(obraSocialId);

            foreach (var empleado in listaIdEmpleado.Select(id => _contextoRRHH.EMPLEADO.Single(x => x.Id.Equals(obraSocialId))))
            {
                obraSocial.Empleados.Add(empleado);
            }
        }

        public void DesvincularEmpleadoObraSocial(List<int> listaIdEmpleado, int empresaId)
        {
            var empresa = _contextoComun.OBRASOCIAL.Find(empresaId);

            foreach (var empleado in listaIdEmpleado.Select(id => _contextoRRHH.EMPLEADO.Single(x => x.Id.Equals(empresaId))))
            {
                empresa.Empleados.Remove(empleado);
            }
        }

        public IEnumerable<Dominio.RecursosHumanos.Entidades.Empleado> MostrarEmpleadosNoAsignados(int obraSocialId, string cadena)
        {
            var obraSocial = _contextoComun.OBRASOCIAL.Include(x => x.Empleados).FirstOrDefault(x => x.Id.Equals(obraSocialId));

            if (obraSocial != null)
            {
                var resultado = _contextoRRHH.EMPLEADO.Except(obraSocial.Empleados)
                    .Where(x => x.Apellido.Contains(cadena)
                                || x.Nombre.Contains(cadena)
                                || x.Dni.Equals(cadena)).ToList();

                return resultado;
            }
            else
            {
                return _contextoRRHH.EMPLEADO.Where(x => x.Apellido.Contains(cadena)
                                                     || x.Nombre.Contains(cadena)
                                                     || x.Dni.Equals(cadena)).ToList();
            }
        }

        public IEnumerable<Dominio.RecursosHumanos.Entidades.Empleado> MostrarEmpleadosAsignados(int obraSocialId, string cadena)
        {
            var obraSocial = _contextoComun.OBRASOCIAL.Include(x => x.Empleados).FirstOrDefault(x => x.Id.Equals(obraSocialId));

            if (obraSocial != null)
            {
                var resultado = obraSocial.Empleados.Where(x => x.Apellido.Contains(cadena)
                                                             || x.Nombre.Contains(cadena)
                                                             || x.Dni.Equals(cadena)).ToList();

                return resultado;
            }
            else
            {
                return _contextoRRHH.EMPLEADO.Where(x => x.Id.Equals(-1));
            }
        }


    }
}
