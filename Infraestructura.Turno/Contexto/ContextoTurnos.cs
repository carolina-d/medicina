using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio.Turnos.Entidades;
using Infraestructura.Base.Contextos;

namespace Infraestructura.Turnos.Contexto
{

    public class ContextoTurnos : ContextoBase ,IContextoTurnos
    {

        private IDbSet<Consultorio> _consultorio;
        public IDbSet<Consultorio> CONSULTORIO
        {
            get { return _consultorio ?? (_consultorio = Set<Consultorio>()); }
            set { }
        }

        private IDbSet<HorarioDeTrabajo> _horarioDeTrabajo;
        public IDbSet<HorarioDeTrabajo> HORARIOSDETRABAJO
        {
            get { return _horarioDeTrabajo ?? (_horarioDeTrabajo = Set<HorarioDeTrabajo>()); }
            set { }
        }

        private IDbSet<Dominio.Turnos.Entidades.Turno> _turno;
        public IDbSet<Dominio.Turnos.Entidades.Turno> TURNO
        {
            get { return _turno ?? (_turno = Set<Dominio.Turnos.Entidades.Turno>()); }
            set { }
        }
    }
}
