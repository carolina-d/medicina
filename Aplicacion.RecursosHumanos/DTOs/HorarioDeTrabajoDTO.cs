using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.RecursosHumanos.DTOs
{
    public class HorarioDeTrabajoDTO
    {
        public int Id { get; set; }

        public int ConsultorioId { get; set; }

        public int EmpleadoId { get; set; }

        public int Dia { get; set; }

        public string HoraInM { get; set; }

        public string HoraInT { get; set; }

        public int TipoM { get; set; }

        public string HoraOutT { get; set; }

        public string HoraOutM { get; set; }

        public int TipoT { get; set; }
    }
}
