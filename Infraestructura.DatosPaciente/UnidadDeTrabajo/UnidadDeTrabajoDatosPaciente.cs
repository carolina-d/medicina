using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.DatosPaciente.Entidades;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Infraestructura.Base.Repositorios;
using Infraestructura.DatosPaciente.Contexto;

namespace Infraestructura.DatosPaciente.UnidadDeTrabajo
{
    public class UnidadDeTrabajoDatosPaciente : IUnidadDeTrabajoDatosPaciente
    {
        private readonly ContextoDatosPaciente _contexto;
        private bool _dispose;

        public UnidadDeTrabajoDatosPaciente(ContextoDatosPaciente contexto)
        {
            this._contexto = contexto;
        }

        private IRepositorio<Paciente> _pacienteRepositorio;
        public IRepositorio<Paciente> PacienteRepositorio
        {
            get { return _pacienteRepositorio ?? (_pacienteRepositorio = new Repositorio<Paciente>(_contexto)); }
        }

        private IRepositorio<Vacuna> _vacunaRepositorio;
        public IRepositorio<Vacuna> VacunaRepositorio
        {
            get { return _vacunaRepositorio ?? (_vacunaRepositorio = new Repositorio<Vacuna>(_contexto)); }
        }

        private IRepositorio<PlanVacunacion> _planVacunacionRepositorio;
        public IRepositorio<PlanVacunacion> PlanVacunacionRepositorio
        {
            get { return _planVacunacionRepositorio ?? (_planVacunacionRepositorio = new Repositorio<PlanVacunacion>(_contexto)); }
        }

        private IRepositorio<CalendarioVacunacion> _calendarioVacunacionRepositorio;
        public IRepositorio<CalendarioVacunacion> CalendarioVacunacionRepositorio
        {
            get { return _calendarioVacunacionRepositorio ?? (_calendarioVacunacionRepositorio = new Repositorio<CalendarioVacunacion>(_contexto)); }
        }

        private IRepositorio<Dosis> _dosisRepositorio;
        public IRepositorio<Dosis> DosisRepositorio
        {
            get { return _dosisRepositorio ?? (_dosisRepositorio = new Repositorio<Dosis>(_contexto)); }
        }

        private IRepositorio<GrupoSanguineo> _grupoSanguineoRepositorio;
        public IRepositorio<GrupoSanguineo> GrupoSanguineoRepositorio
        {
            get { return _grupoSanguineoRepositorio ?? (_grupoSanguineoRepositorio = new Repositorio<GrupoSanguineo>(_contexto)); }
        }

        private IRepositorio<Patologia> _patologiaRepositorio;
        public IRepositorio<Patologia> PatologiaRepositorio
        {
            get { return _patologiaRepositorio ?? (_patologiaRepositorio = new Repositorio<Patologia>(_contexto)); }
        }

        private IRepositorio<PacientePatologia> _pacientePatologiaRepositorio;
        public IRepositorio<PacientePatologia> PacientePatologiaRepositorio
        {
            get { return _pacientePatologiaRepositorio ?? (_pacientePatologiaRepositorio = new Repositorio<PacientePatologia>(_contexto)); }
        }

        private IRepositorio<Antecedente> _antecedenteRepositorio;
        public IRepositorio<Antecedente> AntecedenteRepositorio
        {
            get { return _antecedenteRepositorio ?? (_antecedenteRepositorio = new Repositorio<Antecedente>(_contexto)); }
        }

        private IRepositorio<EnfermedadCronica> _enfermedadCronicaRepositorio;
        public IRepositorio<EnfermedadCronica> EnfermedadCronicaRepositorio
        {
            get { return _enfermedadCronicaRepositorio ?? (_enfermedadCronicaRepositorio = new Repositorio<EnfermedadCronica>(_contexto)); }
        }

        private IRepositorio<Habito> _habitoRepositorio;
        public IRepositorio<Habito> HabitoRepositorio
        {
            get { return _habitoRepositorio ?? (_habitoRepositorio = new Repositorio<Habito>(_contexto)); }
        }

        private IRepositorio<PacienteObraSocial> _pacienteObraSocialRepositorio;
        public IRepositorio<PacienteObraSocial> PacienteObraSocialRepositorio
        {
            get { return _pacienteObraSocialRepositorio ?? (_pacienteObraSocialRepositorio = new Repositorio<PacienteObraSocial>(_contexto)); }
        }

        private IRepositorio<Pariente> _parienteRepositorio;
        public IRepositorio<Pariente> ParienteRepositorio
        {
            get { return _parienteRepositorio ?? (_parienteRepositorio = new Repositorio<Pariente>(_contexto)); }
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
