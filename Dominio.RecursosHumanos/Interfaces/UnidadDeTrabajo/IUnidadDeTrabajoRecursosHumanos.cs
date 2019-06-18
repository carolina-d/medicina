using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Entidades;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEmpresa;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEspecialidad;

namespace Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo
{
    public interface IUnidadDeTrabajoRecursosHumanos
    {
        // Repositorios
        IRepositorio<Empleado> EmpleadoRepositorio { get; }
        IRepositorio<Especialidad> EspecialidadRepositorio { get; }
        IRepositorio<Empresa> EmpresaRepositorio { get; }
        IRepositorio<HorarioDeTrabajo> HorarioDeTrabajoRepositorio { get; }
        IRepositorio<Consultorio> ConsultorioRepositorio { get; }

        // Servicios
        IEmpleadoEmpresaServicio EmpleadoEmpresaServicio { get; }
        IEmpleadoEspecialidadServicio EmpleadoEspecialidadServicio { get; }


        // ---------------------------------------------------------------------//
        void Commit();
        void Disposed();
    }
}
