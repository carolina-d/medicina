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
    [Table("GrupoSanguineo")]
    [MetadataType(typeof(IValidacionGrupoSanguineo))]
    public class GrupoSanguineo : Entidad
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
