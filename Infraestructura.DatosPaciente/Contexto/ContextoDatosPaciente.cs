using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.DatosPaciente.Entidades;
using Infraestructura.Base.Contextos;

namespace Infraestructura.DatosPaciente.Contexto
{
    public class ContextoDatosPaciente : ContextoBase, IContextoDatosPaciente
    {
        private IDbSet<GrupoSanguineo> _grupoSanguineo;
        public IDbSet<GrupoSanguineo> GRUPOSANGUINEO
        {
            get { return _grupoSanguineo ?? (_grupoSanguineo = Set<GrupoSanguineo>()); }
            set { }
        }

        private IDbSet<Dosis> _dosis;
        public IDbSet<Dosis> DOSIS
        {
            get { return _dosis ?? (_dosis = Set<Dosis>()); }
            set { }
        }

        private IDbSet<Paciente> _paciente;
        public IDbSet<Paciente> PACIENTE
        {
            get { return _paciente ?? (_paciente = Set<Paciente>()); }
            set { }
        }

        private IDbSet<Vacuna> _vacuna;
        public IDbSet<Vacuna> VACUNA
        {
            get { return _vacuna ?? (_vacuna = Set<Vacuna>()); }
            set { }
        }

        private IDbSet<PlanVacunacion> _planVacunacion;
        public IDbSet<PlanVacunacion> PLANVACUNACION
        {
            get { return _planVacunacion ?? (_planVacunacion = Set<PlanVacunacion>()); }
            set { }
        }

        private IDbSet<CalendarioVacunacion> _calendarioVacunacion;
        public IDbSet<CalendarioVacunacion> CALENDARIOVACUNACION
        {
            get { return _calendarioVacunacion ?? (_calendarioVacunacion = Set<CalendarioVacunacion>()); }
            set { }
        }

        private IDbSet<Patologia> _patologia;
        public IDbSet<Patologia> PATOLOGIA
        {
            get { return _patologia ?? (_patologia = Set<Patologia>()); }
            set { }
        }

        private IDbSet<PacientePatologia> _pacientePatologia;
        public IDbSet<PacientePatologia> PACIENTEPATOLOGIA
        {
            get { return _pacientePatologia ?? (_pacientePatologia = Set<PacientePatologia>()); }
            set { }
        }

        private IDbSet<Antecedente> _antecedente;
        public IDbSet<Antecedente> ANTECEDENTE
        {
            get { return _antecedente ?? (_antecedente = Set<Antecedente>()); }
            set { }
        }

        private IDbSet<EnfermedadCronica> _enfermedadCronica;
        public IDbSet<EnfermedadCronica> ENFERMEDADCRONICA
        {
            get { return _enfermedadCronica ?? (_enfermedadCronica = Set<EnfermedadCronica>()); }
            set { }
        }

        private IDbSet<Habito> _habito;
        public IDbSet<Habito> HABITO
        {
            get { return _habito ?? (_habito = Set<Habito>()); }
            set { }
        }

        private IDbSet<PacienteObraSocial> _pacienteObraSocial;
        public IDbSet<PacienteObraSocial> PACIENTEOBRASOCIAL
        {
            get { return _pacienteObraSocial ?? (_pacienteObraSocial = Set<PacienteObraSocial>()); }
            set { }
        }

        private IDbSet<Pariente> _pariente;
        public IDbSet<Pariente> PARIENTE
        {
            get { return _pariente ?? (_pariente = Set<Pariente>()); }
            set { }
        }
    }
}
