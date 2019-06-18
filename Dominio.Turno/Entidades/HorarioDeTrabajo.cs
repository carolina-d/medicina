using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Turnos.Entidades.Validaciones;
using Dominio.Base;

namespace Dominio.Turnos.Entidades
{
    [Table("HorarioDeTrabajo")]
    [MetadataType(typeof(IValidacionHorarioDeTrabajo))]
    public class HorarioDeTrabajo:Entidad
    {
        public int ConsultorioId { get; set; }
        public int Dia { get; set; }
        public decimal HoraInM { get; set; }
        public decimal HoraInT { get; set; }
        public int TipoM { get; set; }
        public decimal HoraOutT { get; set; }
        public decimal HoraOutM { get; set; }
        public int TipoT { get; set; }
        public DateTime FechaVigencia { get; set; }

    }
}
