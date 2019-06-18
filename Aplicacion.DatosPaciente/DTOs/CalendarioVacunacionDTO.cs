using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DatosPaciente.DTOs
{
    public class CalendarioVacunacionDTO
    {
        public int Id { get; set; }
        public int VacunaId { get; set; }
        public string Vacuna { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }
        public string Dosis { get; set; }
        public string EsObligatoria { get; set; }
    }
}
