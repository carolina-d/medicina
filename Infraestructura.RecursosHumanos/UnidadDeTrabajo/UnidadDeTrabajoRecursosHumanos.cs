using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Entidades;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEmpresa;
using Infraestructura.Base.Contextos;
using Infraestructura.Base.Repositorios;
using Infraestructura.RecursosHumanos.Contexto;
using Dominio.RecursosHumanos.Servicios.Servicio.EmpleadoEspecialidad;
using Infraestructura.RecursosHumanos.Servicio.EmpleadoEspecialidad;

namespace Infraestructura.RecursosHumanos.UnidadDeTrabajo
{
    public class UnidadDeTrabajoRecursosHumanos : IUnidadDeTrabajoRecursosHumanos
    {
        private readonly ContextoRecursosHumanos _contexto;
        private bool _dispose;

        public UnidadDeTrabajoRecursosHumanos(ContextoRecursosHumanos contexto)
        {
            _contexto = contexto;
        }

        private IRepositorio<Empleado> _empleadoRepositorio;
        public IRepositorio<Empleado> EmpleadoRepositorio
        {
            get { return _empleadoRepositorio ?? (_empleadoRepositorio = new Repositorio<Empleado>(_contexto)); }
        }

        private IRepositorio<Empresa> _empresaRepositorio;
        public IRepositorio<Empresa> EmpresaRepositorio
        {
            get { return _empresaRepositorio ?? (_empresaRepositorio = new Repositorio<Empresa>(_contexto)); }
        }

        private IRepositorio<Especialidad> _especialidadRepositorio;
        public IRepositorio<Especialidad> EspecialidadRepositorio
        {
            get { return _especialidadRepositorio ?? (_especialidadRepositorio = new Repositorio<Especialidad>(_contexto)); }
        }

        private IRepositorio<Consultorio> _consultorioRepositorio;
        public IRepositorio<Consultorio> ConsultorioRepositorio
        {
            get { return _consultorioRepositorio ?? (_consultorioRepositorio = new Repositorio<Consultorio>(_contexto)); }
        }

        private IRepositorio<HorarioDeTrabajo> _horariodetrabajoRepositorio;
        public IRepositorio<HorarioDeTrabajo> HorarioDeTrabajoRepositorio
        {
            get { return _horariodetrabajoRepositorio ?? (_horariodetrabajoRepositorio = new Repositorio<HorarioDeTrabajo>(_contexto)); }
        }


        // ------------------------------------------------------------------------------------------------------------------- //

        private IEmpleadoEmpresaServicio _empleadoEmpresaServicio;
        public IEmpleadoEmpresaServicio EmpleadoEmpresaServicio
        {
            get { return _empleadoEmpresaServicio ?? (_empleadoEmpresaServicio = new EmpleadoEmpresaServicio(_contexto)); }
        }

        private IEmpleadoEspecialidadServicio _empleadoEspecialidadServicio;
        public IEmpleadoEspecialidadServicio EmpleadoEspecialidadServicio
        {
            get { return _empleadoEspecialidadServicio ?? (_empleadoEspecialidadServicio = new EmpleadoEspecialidadServicio(_contexto)); }
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public void Disposed()
        {
            _contexto.Dispose();
        }
    }
}
