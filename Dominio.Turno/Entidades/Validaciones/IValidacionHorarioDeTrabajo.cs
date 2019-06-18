using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Turnos.Entidades.Validaciones
{
    public interface IValidacionHorarioDeTrabajo
    {
         [Required(ErrorMessage = "Campo Obligatorio")]
         int ConsultorioId { get; set; }
         [Required(ErrorMessage = "Campo Obligatorio")]
         int Dia { get; set; }
         [Required(ErrorMessage = "Campo Obligatorio")]
         decimal HoraInM { get; set; }
         [Required(ErrorMessage = "Campo Obligatorio")]
         decimal HoraInT { get; set; }
         [Required(ErrorMessage = "Campo Obligatorio")]
         int TipoM { get; set; }
         decimal HoraOutT { get; set; }
         decimal HoraOutM { get; set; }
         int TipoT { get; set; }
    }
}
