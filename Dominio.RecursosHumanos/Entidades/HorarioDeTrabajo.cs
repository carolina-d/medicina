using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.RecursosHumanos.Entidades.Validaciones;

namespace Dominio.RecursosHumanos.Entidades
{
    [Table("HorarioDeTrabajo")]
    [MetadataType(typeof(IValidacionHorarioDeTrabajo))]
    public class HorarioDeTrabajo : Entidad
    {
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
