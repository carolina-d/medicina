using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ConsultaPaciente.Entidades.Validaciones;
using Dominio.Base;
namespace Dominio.ConsultaPaciente.Entidades
{
    [Table("Vademecum")]
    [MetadataType(typeof(IValidacionVademecum))]
    public class Vademecum:Entidad
    {
       public string PrincipioActivo { get; set; }
       public string Dosificacion { get; set; }
       public string NombreComercial { get; set; }
       public string Composicion { get; set; }
       public string ContraindicacionesPA { get; set; }
       public string Precaucion { get; set; }
       public string Interaccion { get; set; }
       public string Nombre { get; set; }
       public string Farmacologia { get; set; }
       public string Farmacodinamia { get; set; }
       public string Farmacocinetica { get; set; }
       public string ReaccionesAdversa { get; set; }
       public string Indicacion { get; set; }
       public string Sobredosificacion { get; set; }
       public string Presentacion { get; set; }
       public string Advertencia { get; set; }
       public string AccionTerapeutica { get; set; }
       public string Contraindicacion { get; set; }
    }
}
