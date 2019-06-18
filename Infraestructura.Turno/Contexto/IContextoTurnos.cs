using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infraestructura.Turnos.Contexto
{
    public interface IContextoTurnos
    {
        IDbSet<Dominio.Turnos.Entidades.Consultorio> CONSULTORIO { get; set; }
        IDbSet<Dominio.Turnos.Entidades.HorarioDeTrabajo> HORARIOSDETRABAJO { get; set; }
        IDbSet<Dominio.Turnos.Entidades.Turno> TURNO { get; set; } 
    }
}
