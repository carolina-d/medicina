using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Base;
using Dominio.Seguridad.Entidades.Validaciones;

namespace Dominio.Seguridad.Entidades
{
    [Table("ConfiguracionSeguridad")]
    [MetadataType(typeof(IValidacionConfiguracionSeguridad))]
    public class ConfiguracionSeguridad : Entidad
    {
        public string PasswordDefecto { get; set; }
        public bool RequerirCambioPassword { get; set; }
        public int CantMaximoCaracteres { get; set; }
        public int CantMinimoCaracteres { get; set; }
        public int CantMayusculas { get; set; }
        public int CantMinusculas { get; set; }
        public int CantNumeros { get; set; }
        public int CantSimbolos { get; set; }
    }
}
