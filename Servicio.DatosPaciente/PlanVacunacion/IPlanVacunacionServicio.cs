using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.DatosPaciente.PlanVacunacion
{
    public interface IPlanVacunacionServicio
    {
        void GenerarPlanDeVacunacionParaUnPaciente(int pacienteId);
    }
}
