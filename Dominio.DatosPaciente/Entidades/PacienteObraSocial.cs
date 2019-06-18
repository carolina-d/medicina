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
    [Table("PacienteObraSocial")]
    [MetadataType(typeof(IValidacionPacienteObraSocial))]

    public class PacienteObraSocial : Entidad
    {
        public string NumeroAfiliado { get; set; }

        public int ObraSocialId { get; set; }

        public int PacienteId { get; set; }

        public string PlanObraSocial { get; set; }
    }
}