using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.DatosPaciente.Entidades;

namespace Infraestructura.DatosPaciente.Contexto
{
    public interface IContextoDatosPaciente
    {
        IDbSet<GrupoSanguineo> GRUPOSANGUINEO { get; set; }
        IDbSet<Dosis> DOSIS { get; set; }
        IDbSet<Paciente> PACIENTE { get; set; }
        IDbSet<Vacuna> VACUNA { get; set; }
        IDbSet<PlanVacunacion> PLANVACUNACION { get; set; }
        IDbSet<CalendarioVacunacion> CALENDARIOVACUNACION { get; set; }
        IDbSet<Patologia> PATOLOGIA { get; set; }
        IDbSet<PacientePatologia> PACIENTEPATOLOGIA { get; set; }
        IDbSet<Antecedente> ANTECEDENTE  { get; set; }
        IDbSet<EnfermedadCronica> ENFERMEDADCRONICA { get; set; }
        IDbSet<PacienteObraSocial> PACIENTEOBRASOCIAL { get; set; }
        IDbSet<Habito> HABITO { get; set; }
        IDbSet<Pariente> PARIENTE { get; set; }




    }
}
