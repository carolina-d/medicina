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
    [Table("Pariente")]
    [MetadataType(typeof(IValidacionPariente))]
    public class Pariente : Entidad
    {

        public string Parentezco { get; set; }

        public bool Diabetes { get; set; }

        public bool Cancer { get; set; }

        public string CancerDescripcion { get; set; }


        public bool Hipertension { get; set; }


        public bool Cardiovascular { get; set; }


        public bool Asma { get; set; }


        public bool Alergia { get; set; }


        public string AlergiasDescripcion { get; set; }

        public bool Congenitos { get; set; }


        public string CongenitosDescripcion { get; set; }


        public bool Epilepsia { get; set; }


        public bool Tuberculosis { get; set; }


        public bool Tabaquismo { get; set; }


        public bool Alcoholismo { get; set; }


        public bool Drogadiccion { get; set; }


        public bool HIV { get; set; }


        public bool HepatitisB { get; set; }


        public bool Chagas { get; set; }


        public bool Otros { get; set; }

        public string OtrosDescripcion { get; set; }


        public bool Anorexia { get; set; }

    }
}