using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.ConsultaPaciente.Entidades.Validaciones;

namespace Dominio.ConsultaPaciente.Entidades
{
    [Table("Historia Clinica")]
    [MetadataType(typeof(IValidacionHistoriaClinica ))]
     public class HistoriaClinica : Entidad 
    {

        public int ConsultaId { get; set; }
        public int EstudioPedidoId { get; set; }
        public int EstudioRealizadoId { get; set; }
        public int AntecedenteId { get; set; }
        public int HabitoId { get; set; }
        public int EnfermedadCronicaId { get; set; }
        public int CirugiaId { get; set; }  
        public int PatologiaPacienteId { get; set; }
          

    } 
}
