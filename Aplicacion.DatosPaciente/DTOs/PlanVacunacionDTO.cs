using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DatosPaciente.DTOs
{
    public class PlanVacunacionDTO
    {
        public int Id { get; set; }
        public string Vacuna { get; set; }
        public string Dosis { get; set; }
        public string FechaTentativa { get; set; }
        public string FechaReal { get; set; }
        public string Estado { get; set; }
    }
}
