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
    [Table("Antecedente")]
    [MetadataType(typeof(IValidacionAntecedente))]
    public class Antecedente : Entidad
    {
        public int Codigo { get; set; }

        public string AntecedentesPersonales { get; set; }

        public DateTime Fecha { get; set; }

        public int ParienteId { get; set; }
    }
}