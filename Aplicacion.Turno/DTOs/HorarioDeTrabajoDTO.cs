using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Turno.DTOs
{
    public class HorarioDeTrabajoDTO
    {
        public int Id { get; set; }
        public int ConsultorioId { get; set; }
        public int Dia { get; set; }
        public decimal HoraInM { get; set; }
        public decimal HoraInT { get; set; }
        public int TipoM { get; set; }
        public decimal HoraOutT { get; set; }
        public decimal HoraOutM { get; set; }
        public int TipoT { get; set; }
        
    }
}
