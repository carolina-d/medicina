using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionPariente
    {

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Parentezco { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Diabetes { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Cancer { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string CancerDescripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Hipertension { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Cardiovascular { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Asma { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Alergia { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string AlergiasDescripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Congenitos { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string CongenitosDescripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Epilepsia { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Tuberculosis { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Tabaquismo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Alcoholismo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Drogadiccion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool HIV { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool HepatitisB { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Chagas { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Otros { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string OtrosDescripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        bool Anorexia { get; set; }


    }
}