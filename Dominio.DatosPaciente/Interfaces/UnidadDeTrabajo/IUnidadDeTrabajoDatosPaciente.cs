using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base.Repositorios;
using Dominio.DatosPaciente.Entidades;

namespace Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo
{
    public interface IUnidadDeTrabajoDatosPaciente
    {
        IRepositorio<Paciente> PacienteRepositorio { get; }
        IRepositorio<Vacuna> VacunaRepositorio { get; }
        IRepositorio<CalendarioVacunacion> CalendarioVacunacionRepositorio { get; }
        IRepositorio<PlanVacunacion> PlanVacunacionRepositorio { get; }
        IRepositorio<Dosis> DosisRepositorio { get; }
        IRepositorio<GrupoSanguineo> GrupoSanguineoRepositorio { get; }
        IRepositorio<Patologia> PatologiaRepositorio { get; }
        IRepositorio<PacientePatologia> PacientePatologiaRepositorio { get; }
        IRepositorio<Antecedente> AntecedenteRepositorio { get; }
        IRepositorio<EnfermedadCronica> EnfermedadCronicaRepositorio { get;}
        IRepositorio<Habito> HabitoRepositorio { get; }
        IRepositorio<PacienteObraSocial> PacienteObraSocialRepositorio { get; }
        IRepositorio<Pariente> ParienteRepositorio { get; }

        void Commit();
        void Disposed();
    }
}
