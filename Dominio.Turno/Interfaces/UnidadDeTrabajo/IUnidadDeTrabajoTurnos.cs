using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;

namespace Dominio.Turnos.Interfaces.IUnidadDeTrabajo
{
    public interface IUnidadDeTrabajoTurno
    {
        IRepositorio<Dominio.Turnos.Entidades.Consultorio> ConsultorioRepositorio { get; }
        IRepositorio<Dominio.Turnos.Entidades.HorarioDeTrabajo> HorarioDeTrabajoRespositorio { get; }
        IRepositorio<Dominio.Turnos.Entidades.Turno> TurnoRepositorio { get; }
        IRepositorio<Dominio.Turno.Entidades.ConfiguracionEmpleado> ConfiguracionEmpleadoRepositorio { get; }
        void Commit();
        void Disposed();
    }
}
