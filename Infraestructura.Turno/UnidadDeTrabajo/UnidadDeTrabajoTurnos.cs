using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.Turnos.Entidades;
using Dominio.Turnos.Interfaces.IUnidadDeTrabajo;
using Infraestructura.Base.Repositorios;
using Infraestructura.Turnos.Contexto;
using Dominio.Turnos.Entidades;

namespace Infraestructura.Turno.UnidadDeControl
{
    public class UnidadDeTrabajoTurnos : IUnidadDeTrabajoTurno
    {
        
        private readonly ContextoTurnos _contexto;
        private bool _dispose;

        public UnidadDeTrabajoTurnos(ContextoTurnos contexto)
        {
            _contexto = contexto;
        }
        private IRepositorio<Consultorio> _consultorioRepositorio;
        public IRepositorio<Consultorio> ConsultorioRepositorio
        {
            get{ return _consultorioRepositorio ?? (_consultorioRepositorio = new Repositorio<Consultorio>(_contexto));}
        }
        private IRepositorio<HorarioDeTrabajo> _horarioDeTrabajoRepositorio;
        public IRepositorio<HorarioDeTrabajo> HorarioDeTrabajoRespositorio
        {
            get
            {
                return _horarioDeTrabajoRepositorio ?? (_horarioDeTrabajoRepositorio = new Repositorio<HorarioDeTrabajo>(_contexto));
            }            
        }
        private IRepositorio<Dominio.Turnos.Entidades.Turno> _turnoRepositorio;
        public IRepositorio<Dominio.Turnos.Entidades.Turno> TurnoRepositorio
        {
            get
            {
                return _turnoRepositorio ?? (_turnoRepositorio = new Repositorio<Dominio.Turnos.Entidades.Turno>(_contexto));
            }            
        }

        private IRepositorio<Dominio.Turno.Entidades.ConfiguracionEmpleado> _configuracionEmpleadoRepositorio;
        public IRepositorio<Dominio.Turno.Entidades.ConfiguracionEmpleado> ConfiguracionEmpleadoRepositorio
        {
            get { return _configuracionEmpleadoRepositorio ?? (_configuracionEmpleadoRepositorio = new Repositorio<Dominio.Turno.Entidades.ConfiguracionEmpleado>(_contexto)); }
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
