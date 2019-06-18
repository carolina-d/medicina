using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.Comun.Entidades;
using Dominio.DatosPaciente.Entidades.Validaciones;

namespace Dominio.DatosPaciente.Entidades
{
    [Table("Paciente")]
    [MetadataType(typeof (IValidacionPaciente))]
    public class Paciente : Entidad
    {
        public int SexoId { get; set; }
        public int GrupoSanguineoId { get; set; }
        public int ObraSocialId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        
        [NotMapped]
        public string ApyNom
        {
            get { return string.Format("{0} {1}", Apellido, Nombre); }
        }

        public string Dni { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [NotMapped]
        public string Edad
        {
            get { return Aplicacion.DatosPaciente.Clases.Edad.Calcular(FechaNacimiento, DateTime.Today); }
        }

        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Mail { get; set; }
        public byte[] Foto { get; set; }
        public bool EsDown { get; set; }
        
        
        public string NumeroAfiliado { get; set; }
        public string PlanObraSocial { get; set; }

        public virtual Comun.Entidades.ObraSocial ObraSocial { get; set; }
        public virtual Sexo Sexo { get; set; }
        public virtual GrupoSanguineo GrupoSanguineo { get; set; }

        public ICollection<PlanVacunacion> PlanVacunaciones { get; set; }
    }
}
