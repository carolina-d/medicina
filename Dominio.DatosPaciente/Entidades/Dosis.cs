using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.DatosPaciente.Entidades.Validaciones;

namespace Dominio.DatosPaciente.Entidades
{
    [Table("Dosis")]
    [MetadataType(typeof(IValidacionDosis))]
    public class Dosis : Entidad
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public ICollection<CalendarioVacunacion> CalendarioVacunaciones { get; set; }
    }
}
