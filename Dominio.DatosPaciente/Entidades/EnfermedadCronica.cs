using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.DatosPaciente.Entidades.Validaciones;
using Dominio.Base;

namespace Dominio.DatosPaciente.Entidades
{
    [Table("EnfermedadesCronicas")]
    [MetadataType(typeof(IValidacionEnfermedadCronica))]
    public class EnfermedadCronica : Entidad
    {
        public string Descripcion { get; set; }

        public DateTime Fecha { get; set; }
    }
}