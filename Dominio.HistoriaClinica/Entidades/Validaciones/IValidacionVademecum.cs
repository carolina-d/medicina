using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ConsultaPaciente.Entidades.Validaciones
{
    public interface IValidacionVademecum
    {
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string PrincipioActivo { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Dosificacion { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string NombreComercial { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Composicion { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string ContraindicacionesPA { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Precauciones { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Interacciones { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Nombre { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Farmacologia { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Farmacodinamia { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Farmacocinetica { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string ReaccionesAdversas { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Indicaciones { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Sobredosificacion { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Presentaciones { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Advertencias { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string AccionTerapeutica { get; set; }
        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        string Contraindicaciones { get; set; }

    }
}
