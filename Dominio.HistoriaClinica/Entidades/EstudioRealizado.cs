using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Dominio.ConsultaPaciente.Entidades.Validaciones;
using Dominio.Base;
using System.Threading.Tasks;



namespace Dominio.ConsultaPaciente.Entidades
{

    [Table("EstudiosRealizados")]
    [MetadataType(typeof(IValidacionEstudioRealizado))]
    public class  EstudioRealizado :Entidad
    
    {
        public int ConsultaId { get; set; }
        public string Foto  { get; set; }
        public string Observaciones { get; set; }
        public string Resultado { get; set; }
        public DateTime FechaDeRealizado { get; set; }
        public string Valores { get; set; }
    }
}
