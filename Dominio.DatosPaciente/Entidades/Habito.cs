using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Dominio.Base;
using Dominio.DatosPaciente.Entidades.Validaciones;

namespace Dominio.DatosPaciente.Entidades
{
    [Table("Habitos")]
    [MetadataType(typeof(IValidacionHabito))]
    public class Habito : Entidad
    {
        public int Codigo { get; set; }
        public int PacienteId { get; set; }

        public string Descripcion { get; set; }
    }
}
