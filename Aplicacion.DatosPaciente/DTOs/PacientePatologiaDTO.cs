using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DatosPaciente.DTOs
{
    public class PacientePatologiaDTO
    {
        public int Id { get; set; }
        public int  PacienteId { get; set; }
        public int PatologiaId { get; set; }
        public string Patologia { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string Observacion { get; set; }
    }
}
